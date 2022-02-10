using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwebSECUI.Layout;
using System.Data;
using SMOSEC.Application.Services;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;
using SMOSEC.CommLib;
using SwebSECUI.MasterData;



namespace SwebSECUI.MasterData
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssetsTypeRows : Swebui.Controls.SwebUserControl
    {
        public frmAssetsTypeRows() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        public Int32 MaxLevel = 3;         //最深层级
        public Int32 NowLevel = 1;     //当前层级
        public String ID;              //选择资产分类编号
        public String LocName;    //区域名称
        public bool Enable = false;    //是否启用
        #endregion
        /// <summary>
        /// 新建资产分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAssetsTypeCreateLayout frm = new frmAssetsTypeCreateLayout();
            frm.isCreate = true;
            frm.plFID.Visible = false;
            frm.plFName.Visible = false;
            frm.plFDate.Visible = false;
            this.ShowDialog(frm);
            this.ShowDialog(frm, (obj, args) => {
                if (frm.ShowResult == ShowResult.Yes)
                {
                    Bind();
                }
            });
        }
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsTypeRows_Load(object sender, EventArgs e)
        {
            Bind();
            if (this.Form.ToString() == "SMOSEC.UI.MasterData.frmLocationRows")
            {
                EditBtn.Text = "编辑此区域";
                DeleteBtn.Text = "删除此区域";
            }
            else if (this.Form.ToString() == "SMOSEC.UI.MasterData.frmAssetsTypeRows")
            {
                EditBtn.Text = "编辑此分类";
                if (Enable)
                {
                    DeleteBtn.Text = "禁用此分类";
                }
                else
                {
                    DeleteBtn.Text = "启用此分类";
                }
            }
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        public void Bind()
        {
            try
            {
                treeAssetsType.Nodes.Clear();       //数据清除
                List<AssetsType> Data = autofacConfig.assTypeService.GetAll();
                if (Data.Count > 0)
                {
                    foreach (AssetsType Row in Data)
                    {
                        if (Row.TLEVEL == 1)
                        {
                            TreeViewNode Node = new TreeViewNode(Row.TYPEID,Row.NAME);
                            TreeViewNode SonNode = getData(2, Data, Row.TYPEID);
                            if (SonNode.Nodes.Count > 0)
                            {
                                foreach (TreeViewNode SonRow in SonNode.Nodes)
                                {
                                    Node.Nodes.Add(SonRow);
                                }
                            }
                            if (Row.ISENABLE == (int)IsEnable.禁用)
                            {
                                //Node.Text = System.Drawing.Color.Red;
                            }
                            treeAssetsType.Nodes.Add(Node);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 添加子级资产分类(总共三级)
        /// </summary>
        /// <param name="Level"></param>
        /// <param name="Data"></param>
        /// <param name="ParentID"></param>
        /// <returns></returns>
        public TreeViewNode getData(Int32 Level, List<AssetsType> Data, String ParentID)
        {
            TreeViewNode TreeData = new TreeViewNode();
            if (Level < MaxLevel)
            {
                foreach (AssetsType Row in Data)
                {
                    if (Row.TLEVEL == Level && Row.PARENTTYPEID == ParentID)
                    {
                        TreeViewNode Node = new TreeViewNode(Row.TYPEID, Row.NAME);
                        TreeViewNode SonNode = getData(Level + 1, Data, Row.TYPEID);
                        if (SonNode.Nodes.Count > 0)
                        {
                            foreach (TreeViewNode SonRow in SonNode.Nodes)
                            {
                                Node.Nodes.Add(SonRow);
                            }
                        }
                        if (Row.ISENABLE == (int)IsEnable.禁用)
                        {
                            //Node.Text.C = System.Drawing.Color.Red;
                        }
                        TreeData.Nodes.Add(Node);
                    }
                }
            }
            else if (Level == MaxLevel)
            {
                foreach (AssetsType Row in Data)
                {
                    if (Row.TLEVEL == Level && Row.PARENTTYPEID == ParentID)
                    {
                        TreeViewNode Node = new TreeViewNode(Row.TYPEID, Row.NAME);
                        if (Row.ISENABLE == (int)IsEnable.禁用)
                        {
                            //Node.TextColor = System.Drawing.Color.Red;
                        }
                        TreeData.Nodes.Add(Node);
                    }
                }
            }
            return TreeData;
        }
        /// <summary>
        /// 添加下级资产分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(ID)) throw new Exception("请先选择父类资产类别");
                if (autofacConfig.assTypeService.GetByID(ID).TLEVEL == 3) throw new Exception("当前所选类别为最低级，无法创建下级!");
                frmAssetsTypeCreateLayout frm = new frmAssetsTypeCreateLayout();
                frm.isCreateSon = true;
                frm.ID = ID;
                ShowDialog(frm);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 进行编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(ID)) throw new Exception("请先选择要操作的资产类别");
                AssetsType assetsType = autofacConfig.assTypeService.GetByID(ID);
                if (this.Form.ToString() == "SMOSEC.UI.MasterData.frmLocationRows")
                {
                    frmLocationCreateLayout frm = new frmLocationCreateLayout();
                    frm.ID = ID;  //区域编码
                    frm.isEdit = true;
                    this.Close();
                    this.Form.ShowDialog(frm);
                }
                else if (this.Form.ToString() == "SMOSEC.UI.MasterData.frmAssetsTypeRows")
                {
                    frmAssetsTypeCreateLayout frm = new frmAssetsTypeCreateLayout();
                    frm.ID = ID;      //类别编码
                    frm.isEdit = true;     //编辑状态
                    this.Close();
                    this.Form.ShowDialog(frm);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
            
        }
        /// <summary>
        /// 选择资产
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeAssetsType_Press(object sender, TreeViewOnPressEventArgs e)
        {
            ID = e.TreeID;        //所选资产分类编号
            try
            {
                if (treeAssetsType.Tag != null)
                {

                   lblName.Text = treeAssetsType.Tag.ToString(); //所选资产分类名称
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
            
        }
        /// <summary>
        /// 删除此区域
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            try
            {
                if (this.Form.ToString() == "SMOSEC.UI.MasterData.frmLocationRows")
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
                }
                else if (this.Form.ToString() == "SMOSEC.UI.MasterData.frmAssetsTypeRows")
                {
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
                                            ((frmAssetsTypeRows)Parent).Bind();
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
                    }
                    else        //启用该分类
                    {
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
                                        ((frmAssetsTypeRows)Parent).Bind();
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
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}