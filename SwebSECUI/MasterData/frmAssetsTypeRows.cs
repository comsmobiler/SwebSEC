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
        private string SelectID;
        public Int32 MaxLevel = 3;         //最深层级
        public Int32 NowLevel = 1;     //当前层级
        public String ID;
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsTypeRows_Load(object sender, EventArgs e)
        {
            try
            {
                Bind();
                treeView1.DefaultValue = new string[] { treeView1.Nodes[0].TreeID };
                SelectID = treeView1.Nodes[0].TreeID;
                GetContent(treeView1.Nodes[0].TreeID);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 绑定treeview
        /// </summary>
        private void Bind()
        {
            try
            {
                treeView1.Nodes.Clear();       //数据清除
                List<AssetsType> Data = autofacConfig.assTypeService.GetAll();
                if (Data.Count > 0)
                {
                    foreach (AssetsType Row in Data)
                    {
                        if (Row.TLEVEL == 1)
                        {
                            TreeViewNode Node = new TreeViewNode(Row.TYPEID, Row.NAME);
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
                                
                            }
                            treeView1.Nodes.Add(Node);
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
                            
                        }
                        TreeData.Nodes.Add(Node);
                    }
                }
            }
            return TreeData;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_Press(object sender, TreeViewOnPressEventArgs e)
        {
            GetContent(e.TreeID);
            SelectID = e.TreeID;
        }
        private void GetContent(string typeid)
        {
            AssetsType assetsType = autofacConfig.assTypeService.GetByID(typeid);
            if (assetsType.TLEVEL == 1)
            {
                Fpanel.Visible = true;
                SPanel.Visible = false;
                txtID.Text = assetsType.TYPEID;
                txtName.Text = assetsType.NAME;
                txtDate.Text = assetsType.EXPIRYDATE.ToString();
                switchIsEnable.Checked = assetsType.ISENABLE == 1 ? true : false;
                editBtn.Text = "编辑父类";
                addTypeBtn.Visible = true;
            }
            else
            {
                if (assetsType.TLEVEL >= 3)
                    addTypeBtn.Visible = false;
                else
                    addTypeBtn.Visible = true;
                editBtn.Text = "编辑子类";
                Fpanel.Visible = false;
                SPanel.Visible = true;
                txtID1.Text = assetsType.TYPEID;
                txtName1.Text = assetsType.NAME;
                txtDate1.Text = assetsType.EXPIRYDATE.ToString();
                switchIsEnable1.Checked = assetsType.ISENABLE == 1 ? true : false;
                AssetsType fType = autofacConfig.assTypeService.GetByID(assetsType.PARENTTYPEID);
                txtFID.Text = fType.TYPEID;
                txtFName.Text = fType.NAME;
                txtFDate.Text = fType.EXPIRYDATE.ToString();
            }
        }
        /// <summary>
        /// 编辑按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editBtn_Click(object sender, EventArgs e)
        {
            AssetsTypeCreateDialog dialog = new AssetsTypeCreateDialog();
            dialog.isCreateSon = false;
            dialog.isEdit = true;
            if (editBtn.Text == "编辑父类")
                dialog.ID = txtID.Text;
            else
                dialog.ID = txtID1.Text;
            this.ShowDialog(dialog, (obj, args) =>
            {
                if (dialog.ShowResult == ShowResult.Yes)
                {
                    //Bind();
                    GetContent(dialog.ID);
                    treeView1.DefaultValue = new string[] { dialog.ID };
                }
            });
        }
        /// <summary>
        /// 新增父类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            AssetsTypeCreateDialog dialog = new AssetsTypeCreateDialog();
            dialog.isCreateSon = false;
            dialog.isCreate = true;
            this.ShowDialog(dialog, (obj, args) =>
            {
                if (dialog.ShowResult == ShowResult.Yes)
                {
                    Bind();
                    GetContent(treeView1.Nodes[0].TreeID);
                    treeView1.DefaultValue = new string[] { treeView1.Nodes[0].TreeID };
                }
            });
        }
        /// <summary>
        /// 新增子类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addTypeBtn_Click(object sender, EventArgs e)
        {
            AssetsTypeCreateDialog dialog = new AssetsTypeCreateDialog();
            dialog.isCreateSon = true;
            dialog.isCreate = true;
            dialog.ID = SelectID;
            this.ShowDialog(dialog, (obj, args) =>
            {

                if (dialog.ShowResult == ShowResult.Yes)
                {
                    Bind();
                    GetContent(dialog.ID);
                    treeView1.DefaultValue = new string[] { dialog.ID };
                }
            });
        }
        /// <summary>
        /// 启用/禁用父级分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void switchIsEnable_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (switchIsEnable.Checked)
                {
                    ReturnInfo rInfo = autofacConfig.assTypeService.ChangeEnable(txtID.Text, IsEnable.启用);
                    if (rInfo.IsSuccess)
                    {
                        Toast("启用分类成功");
                    }
                    else
                        throw new Exception(rInfo.ErrorInfo);
                }
                else
                {
                    ReturnInfo rInfo = autofacConfig.assTypeService.ChangeEnable(txtID.Text, IsEnable.禁用);
                    if (rInfo.IsSuccess)
                    {
                        Toast("禁用分类成功");
                    }
                    else
                        throw new Exception(rInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 启用/禁用子级分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void switchIsEnable1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (switchIsEnable1.Checked)
                {
                    ReturnInfo rInfo = autofacConfig.assTypeService.ChangeEnable(txtID1.Text, IsEnable.启用);
                    if (rInfo.IsSuccess)
                    {
                        Toast("启用分类成功");
                    }
                    else
                        throw new Exception(rInfo.ErrorInfo);
                }
                else
                {
                    ReturnInfo rInfo = autofacConfig.assTypeService.ChangeEnable(txtID1.Text, IsEnable.禁用);
                    if (rInfo.IsSuccess)
                    {
                        Toast("禁用分类成功");
                    }
                    else
                        throw new Exception(rInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}