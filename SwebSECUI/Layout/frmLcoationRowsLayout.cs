using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.CommLib;
using SMOSEC.DTOs.Enum;
using SwebSECUI.MasterData;

namespace SwebSECUI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmLcoationRowsLayout : Swebui.Controls.SwebUserControl
    {
        public frmLcoationRowsLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        public String ID;       //区域编号或者类别编号
        public bool Enable = false;    //是否启用
        #endregion
        public void setColor()
        {
            if (lblEnable.Text == "启用")
            {
                lblEnable.ForeColor = System.Drawing.Color.DodgerBlue;
            }
            else
            {
                lblEnable.ForeColor = System.Drawing.Color.Red;
            }
        }
        /// <summary>
        /// 启用或者禁用区域
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plEnable_Press(object sender, EventArgs e)
        {
            if (lblEnable.Text == "启用")
            {
                MessageBox.Show("你确定要启用该区域吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                {
                    try
                    {
                        if (args.Result == ShowResult.OK)     //启用该区域
                        {
                            ReturnInfo r = autofacConfig.assLocationService.ChangeEnable(lblName.BindDataValue.ToString(), IsEnable.启用);
                            if (r.IsSuccess == true)
                            {
                                this.Form.Toast("区域启用成功");
                                ((frmLocationRows)Owner).Bind();      //刷新数据

                            }
                            else
                            {
                                throw new Exception(r.ErrorInfo);
                            }
                        }
                        this.ShowResult = ShowResult.Yes;
                    }
                    catch (Exception ex)
                    {
                        Form.Toast(ex.Message);
                    }
                });
            }
            else
            {
                MessageBox.Show("你确定要禁用该区域吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                {
                    try
                    {
                        if (args.Result == ShowResult.OK)     //禁用该区域
                        {
                            ReturnInfo r = autofacConfig.assLocationService.ChangeEnable(lblName.BindDataValue.ToString(), IsEnable.禁用);
                            if (r.IsSuccess == true)
                            {
                                this.Form.Toast("区域禁用成功");
                                ((frmLocationRows)Owner).Bind();      //刷新数据

                            }
                            else
                            {
                                throw new Exception(r.ErrorInfo);
                            }

                        }
                        this.ShowResult = ShowResult.Yes;
                    }
                    catch (Exception ex)
                    {
                        Form.Toast(ex.Message);
                    }
                });
            }
        }
        /// <summary>
        /// 对当前行项区域进行编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plEdit_Press(object sender, EventArgs e)
        {
                frmLocationCreateLayout frm = new frmLocationCreateLayout();
                frm.ID = ID;  //区域编码
                frm.isEdit = true;
                this.Form.ShowDialog(frm);
        }
        /// <summary>
        /// 对当前行项区域进行删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plDelete_Press(object sender, EventArgs e)
        {
            this.Close();
            try
            {
                    MessageBox.Show("你确定要删除该区域吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                    {
                        try
                        {
                            if (args.Result == ShowResult.OK)     //删除该区域
                            {
                                ReturnInfo r = autofacConfig.assLocationService.DeleteAssLocation(ID);
                                if (r.IsSuccess == true)
                                {
                                    this.Form.Toast("删除成功");
                                    ((frmLocationRows)Owner).Bind();      //刷新数据
                                }
                                else
                                {
                                    throw new Exception(r.ErrorInfo);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Form.Toast(ex.Message);
                        }
                    });
            
                    if (Enable)        //禁用该分类
                    {
                        MessageBox.Show("你确定要禁用该分类吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                        {
                            try
                            {
                                if (args.Result == ShowResult.OK)
                                {
                                    if (autofacConfig.assTypeService.HasAssets(ID))
                                    {
                                        throw new Exception("当前资产分类有相关的资产数据，不允许禁用!");
                                    }
                                    else if (autofacConfig.assTypeService.IsParent(ID))
                                    {
                                        throw new Exception("当前资产分类有子分类，不允许禁用!");
                                    }
                                    else
                                    {
                                        ReturnInfo r = autofacConfig.assTypeService.ChangeEnable(ID, SMOSEC.DTOs.Enum.IsEnable.禁用);
                                        if (r.IsSuccess == true)
                                        {
                                            this.Form.Toast("分类禁用成功!");
                                            //((frmAssetsTypeRows)Parent).Bind();
                                        }
                                        else
                                        {
                                            throw new Exception(r.ErrorInfo);
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Form.Toast(ex.Message);
                            }
                        });
                    
                   
                        MessageBox.Show("你确定要启用该分类吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                        {
                            try
                            {
                                if (args.Result == ShowResult.OK)
                                {
                                    ReturnInfo r = autofacConfig.assTypeService.ChangeEnable(ID, SMOSEC.DTOs.Enum.IsEnable.启用);
                                    if (r.IsSuccess == true)
                                    {
                                        this.Form.Toast("分类启用成功!");
                                        //((frmAssetsTypeRows)Parent).Bind();
                                    }
                                    else
                                    {
                                        throw new Exception(r.ErrorInfo);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Form.Toast(ex.Message);
                            }
                        });
                    
                }
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}