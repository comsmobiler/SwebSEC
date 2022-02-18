using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwebSECUI.Layout;
using System.Data;
using SMOSEC.Domain.Entity;
using SwebSECUI.MasterData;
using SMOSEC.CommLib;
using SMOSEC.DTOs.Enum;

namespace SwebSECUI.MasterData
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmLocationRows : Swebui.Controls.SwebUserControl
    {
        public frmLocationRows() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        public String ID;       //区域编号或者类别编号
        public bool Enable = false;    //是否启用
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLocationRows_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        public void Bind()
        {
            try
            {
                DataTable table = new DataTable();
                List<AssLocation> locs = autofacConfig.assLocationService.GetAll();
                table.Columns.Add("LOCATIONID");
                table.Columns.Add("NAME");
                table.Columns.Add("MANAGER");
                table.Columns.Add("ISENABLE");
                foreach (AssLocation Row in locs)
                {
                    if (Row.ISENABLE == 1)      //启用
                    {
                        table.Rows.Add(Row.LOCATIONID, Row.NAME, Row.MANAGER, "启用");
                    }
                    else
                    {
                        table.Rows.Add(Row.LOCATIONID, Row.NAME, Row.MANAGER, "禁用");
                    }
                    gridView1.DataSource = table;
                    gridView1.DataBind();
                }
                //if (locs.Count > 0)
                //{
                //    foreach (var data in locs)
                //    {
                //        table.Rows.Add(data.LOCATIONID,data.NAME,data.MANAGER,data.ISENABLE);
                //    }
                //    gridView1.DataSource = table;
                //    gridView1.DataBind();
                //}
                //foreach (ListViewRow Row in listLocation.)   //根据启用或者禁用，设置对应颜色
                //{
                //    frmLcoationRowsLayout frm = Row.Control as frmLcoationRowsLayout;
                //    frm.setColor();
                //}
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 创建区域弹出框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmLocationRowsCreate frm = new frmLocationRowsCreate();
            frm.Flex = 1;
            this.Parent.Controls.Add(frm);
            this.Parent.Controls.RemoveAt(0);
            frm.isCreate = true;
            this.ShowDialog(frm, (o, a) =>
            {
                if (frm.ShowResult == ShowResult.Yes)
                {
                    Bind();
                }
            });
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];
                    string id = selectrow["LOCATIONID"].ToString();
                    frmLocationRowsEdit frm = new frmLocationRowsEdit();
                    frm.ID = id;
                    frm.Flex = 1;
                    frm.isCreate = false;
                    this.Parent.Controls.Add(frm);
                    this.Parent.Controls.RemoveAt(0);
                }
                else
                {
                    Toast("未选择行！");
                }
            });
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                try
                {
                    if (args.SelectedRows.Count > 0)
                    {
                        Dictionary<string, object> selectrow = args.SelectedRows[0];
                        string id = selectrow["LOCATIONID"].ToString();
                        AssLocation ass = autofacConfig.assLocationService.GetByID(id);
                        if (ass.ISENABLE != (int)IsEnable.禁用) throw new Exception("资产处于启用状态中，无法删除!");
                        MessageBox.Show("是否确定删除该区域？", "系统提示", MessageBoxButtons.YesNo, (object sender1, MessageBoxHandlerArgs args1) =>
                        {

                            if (args1.Result == ShowResult.Yes)
                            {
                                ReturnInfo RInfo = autofacConfig.assLocationService.DeleteAssLocation(id);
                                if (RInfo.IsSuccess)
                                {
                                    Toast("删除成功!");
                                    RefreshBtn_Click(null, null);
                                }
                                else
                                {
                                    throw new Exception(RInfo.ErrorInfo);
                                }
                            }
                        });
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
            DataTable table = new DataTable();
            List<AssLocation> locs = autofacConfig.assLocationService.GetAll();
            table.Columns.Add("LOCATIONID");
            table.Columns.Add("NAME");
            table.Columns.Add("MANAGER");
            table.Columns.Add("ISENABLE");
            foreach (AssLocation Row in locs)
            {
                if (Row.ISENABLE == 1)      //启用
                {
                    table.Rows.Add(Row.LOCATIONID, Row.NAME, Row.MANAGER, "启用");
                }
                else
                {
                    table.Rows.Add(Row.LOCATIONID, Row.NAME, Row.MANAGER, "禁用");
                }
                gridView1.DataSource = table;
                gridView1.DataBind();
            }
            gridView1.Reload(table);
        }

        private void StatuBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];
                    string id = selectrow["LOCATIONID"].ToString();
                    frmLocationRowsEditStatu frm = new frmLocationRowsEditStatu();
                    frm.ID = id;
                    frm.Flex = 1;
                    frm.isCreate = false;
                    this.Parent.Controls.Add(frm);
                    this.Parent.Controls.RemoveAt(0);
                }
                else
                {
                    Toast("未选择行！");
                }
            });
        }
    }
}