using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using SMOSEC.DTOs.Enum;
using SwebSECUI.Layout;
using SMOSEC.CommLib;
using SMOSEC.DTOs.InputDTO;
using SwebSECUI.AssetsManager;
using SMOSEC.DTOs.OutputDTO;

namespace SwebSECUI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssInventory : Swebui.Controls.SwebUserControl
    {
        public frmAssInventory() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 初始化界面时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssInventory_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 添加盘点单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmAssInventoryCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
            Bind();
        }
        //绑定数据
        public void Bind()
        {
            try
            {

                string LocationId = "";
                string UserId = Client.Session["UserID"].ToString();
                if (Client.Session["Role"].ToString() == "SMOSECAdmin")
                {
                    var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                    LocationId = user.USER_LOCATIONID;
                }

                DataTable assInventoryList = _autofacConfig.AssInventoryService.GetAssInventoryList(Client.Session["Role"].ToString() == "SMOSECUser" ? Client.Session["UserID"].ToString() : "", LocationId);

                if (assInventoryList.Rows.Count > 0)
                {
                    gridView1.DataSource = assInventoryList;
                    gridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 编辑盘点单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                try
                {
                    if (args.SelectedRows.Count > 0)
                    {
                        Dictionary<string, object> selectrow = args.SelectedRows[0];
                        string id = selectrow["IID"].ToString();
                        AddAIResultInputDto inputDto = new AddAIResultInputDto { IID = id };
                        var inventory = _autofacConfig.AssInventoryService.GetAssInventoryById(id);
                        if (inventory.STATUS == 0)
                        {
                            throw new Exception("资产已盘点结束，无法修改!");
                        }
                        frmAssInventoryEdit frm = new frmAssInventoryEdit() { Flex = 1 };
                        frm.IID = id;
                        this.Parent.Controls.Add(frm);
                        this.Parent.Controls.RemoveAt(0);
                    }
                    else
                    {
                        Toast("未选择行！");
                    }
                }
                catch (Exception ex)
                {
                    Toast(ex.Message);
                }
            });
        }
        /// <summary>
        /// 删除盘点单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];
                    string id = selectrow["IID"].ToString();
                    MessageBox.Show("你确定要该盘点单吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args1) =>
                    {
                        try
                        {
                            if (args1.Result == ShowResult.OK)     //删除该盘点单
                            {
                                ReturnInfo rInfo = _autofacConfig.AssInventoryService.DeleteInventory(id);
                                if (rInfo.IsSuccess)
                                {
                                    Toast("删除盘点单成功.");
                                    RefreshBtn_Click(null, null);
                                }
                                else
                                {
                                    throw new Exception(rInfo.ErrorInfo);
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            Form.Toast(ex.Message);
                        }
                    });
                }
                else
                {
                    Toast("未选择行！");
                }
            });
        }
        /// <summary>
        /// 开始盘点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                try
                {
                    if (args.SelectedRows.Count > 0)
                    {
                        Dictionary<string, object> selectrow = args.SelectedRows[0];
                        string id = selectrow["IID"].ToString();
                        AddAIResultInputDto inputDto = new AddAIResultInputDto { IID = id };
                        var inventory = _autofacConfig.AssInventoryService.GetAssInventoryById(id);
                        if (inventory.STATUS == 0)
                        {
                            throw new Exception("资产已盘点结束，无法盘点!");
                        }
                        ReturnInfo returnInfo = _autofacConfig.AssInventoryService.AddAssInventoryResult(inputDto);
                        if (returnInfo.IsSuccess)
                        {
                            frmAssInventoryResult frm = new frmAssInventoryResult() { Flex = 1 };
                            frm.IID = id;
                            this.Parent.Controls.Add(frm);
                            this.Parent.Controls.RemoveAt(0);
                            frmAssInventoryResult result = new frmAssInventoryResult { IID = id, LocationId = inventory.LOCATIONID, DepartmentId = inventory.DEPARTMENTID, typeId = inventory.TYPEID };
                            Bind();
                        }
                        else
                        {
                            Toast(returnInfo.ErrorInfo);
                        }
                    }
                    else
                    {
                        Toast("未选择行！");
                    }
                }
                catch (Exception ex)
                {
                    Toast(ex.Message);
                }
            });
        }
        

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            string LocationId = "";
            string UserId = Client.Session["UserID"].ToString();
            if (Client.Session["Role"].ToString() == "SMOSECAdmin")
            {
                var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                LocationId = user.USER_LOCATIONID;
            }
            DataTable assInventoryList = _autofacConfig.AssInventoryService.GetAssInventoryList(Client.Session["Role"].ToString() == "SMOSECUser" ? Client.Session["UserID"].ToString() : "", LocationId);
            if (assInventoryList.Rows.Count > 0)
            {
                gridView1.DataSource = assInventoryList;
                gridView1.DataBind();
            }
            gridView1.Reload(assInventoryList);
        }

        private void WatchBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];
                    string id = selectrow["IID"].ToString();
                    var inventory = _autofacConfig.AssInventoryService.GetAssInventoryById(id);
                    frmAssInventoryResult result = new frmAssInventoryResult { IID = id, LocationId = inventory.LOCATIONID, DepartmentId = inventory.DEPARTMENTID, typeId = inventory.TYPEID };
                    frmAssInventoryResult frm = new frmAssInventoryResult() { Flex = 1 };
                    frm.IID = id;
                    frm.SaveBtn.Visible = false;
                    frm.SuccessBtn.Visible = false;
                    frm.panel5.Visible = false;
                    frm.panel6.Visible = false;
                    this.Parent.Controls.Add(frm);
                    this.Parent.Controls.RemoveAt(0);
                    Bind();
                }
                else
                {
                    Toast("未选择行！");
                }
            });
        }
    } 
}