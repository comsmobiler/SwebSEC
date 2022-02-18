using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.CommLib;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.DTOs.OutputDTO;
using SwebSECUI.Layout;
using SMOSEC.Domain.Entity;
using Swebui;

namespace SwebSECUI.MasterData
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssetsDetailEdit : Swebui.Controls.SwebUserControl
    {
        public frmAssetsDetailEdit() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        public string UserId;  //用户编号
        public string TypeId; //类型编号
        public string LocationId;  //区域编号
        public string ManagerId;  //管理员编号
        public string CurrentUserId;  //当前用户编号
        AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public string DepId; //部门编号
        public string AssId;  //资产编号
        AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        #endregion

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmAssets() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 修改资产
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(LocationId))
                {
                    throw new Exception("请选择区域.");
                }
                decimal price;
                if (!decimal.TryParse(txtPrice.Text, out price))
                {
                    throw new Exception("请输入正确的单价.");
                }
                AssetsInputDto assetsInputDto = new AssetsInputDto
                {
                    AssId = txtAssId.Text,
                    BuyDate = DatePickerBuy.Value,
                    CreateUser = UserId,
                    CurrentUser = CurrentUserId,
                    DepartmentId = DepId,
                    Image = ImgPicture.ResourceID,
                    LocationId = LocationId,
                    Manager = ManagerId,
                    ModifyUser = UserId,
                    Name = txtName.Text,
                    Note = txtNote.Text,
                    Place = txtPlace.Text,
                    Price = price,
                    Specification = txtSpe.Text,
                    TypeId = treeAssetsType.Tag.ToString(),
                    Unit = txtUnit.Text,
                    Vendor = txtVendor.Text,
                    ExpiryDate = DatePickerExpiry.Value,
                    SN = txtSN.Text
                };
                if (String.IsNullOrEmpty(txtPrice.Text) == false)
                assetsInputDto.Price = decimal.Parse(txtPrice.Text);
                ReturnInfo returnInfo = _autofacConfig.SettingService.UpdateAssets(assetsInputDto);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("修改成功.");
                    BackBtn_Click(null,null);
                }
                else
                {
                    Toast(returnInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 图片上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Client.FileUpload((obj, args) =>
                {

                    if (string.IsNullOrEmpty(args.error))
                    {
                        string imgName = "";
                        if (string.IsNullOrEmpty(ImgPicture.ResourceID))
                        {
                            string[] name = args.ResourceID.Split('.');
                            imgName = UserId + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + name[1];
                        }
                        else
                        {
                            string[] name = args.ResourceID.Split('.');
                            string[] firstName = ImgPicture.ResourceID.Split(',');
                            imgName = firstName[0] + "." + name[1];
                        }
                        args.SaveFile(imgName, SwebResourceManager.DefaultImagePath);
                        ImgPicture.ResourceID = imgName;
                        ImgPicture.Refresh();
                    }
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 选择区域后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeAssetsType_Press(object sender, TreeSelectPressEventArgs args)
        {
            treeAssetsType.Tag = args.TreeID;
        }

        private void treeSelect1_Press(object sender, TreeSelectPressEventArgs args)
        {
            LocationId = args.TreeID;
            try
            {
                AssLocation location = _autofacConfig.assLocationService.GetByID(LocationId);
                coreUser manager = _autofacConfig.coreUserService.GetUserByID(location.MANAGER);
                ManagerId = location.MANAGER;
                txtManager.Text = manager.USER_NAME;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void treeSelect2_Press(object sender, TreeSelectPressEventArgs args)
        {
            DepId = args.TreeID;
        }
        /// <summary>
        /// 价格改变时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal price;
                if (decimal.TryParse(txtPrice.Text, out price) == false)
                {
                    throw new Exception("请输入正确的金额。");
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void frmAssetsDetailEdit_Load(object sender, EventArgs e)
        {
            try
            {
                List<AssetsType> Data = autofacConfig.assTypeService.GetAll();
                foreach (var data in Data)
                {
                    if (data.TLEVEL == 1)
                    {
                        TreeSelectNode firstNode = new TreeSelectNode(data.TYPEID, data.NAME);
                        foreach (var data1 in Data)
                        {
                            if (data1.TLEVEL == 2 && data1.PARENTTYPEID == data.TYPEID)
                            {
                                TreeSelectNode secNode = new TreeSelectNode(data1.TYPEID, data1.NAME);
                                foreach (var data3 in Data)
                                {
                                    if (data3.TLEVEL == 3 && data3.PARENTTYPEID == data1.TYPEID)
                                    {
                                        secNode.Nodes.Add(new TreeSelectNode(data3.TYPEID, data3.NAME));
                                    }

                                }
                                firstNode.Nodes.Add(secNode);
                            }
                        }
                        treeAssetsType.Nodes.Add(firstNode);
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
            /// 添加区域
            List<AssLocation> locations = _autofacConfig.assLocationService.GetEnableAll();

            foreach (var location in locations)
            {
                treeSelect1.Nodes.Add(new TreeSelectNode(location.LOCATIONID, location.NAME));
            }
            /// 添加部门
            var deplist = _autofacConfig.DepartmentService.GetAllDepartment();
            foreach (var dep in deplist)
            {
                treeSelect2.Nodes.Add(new TreeSelectNode(dep.DEPARTMENTID, dep.NAME));
            }
            try
            {
                Bind();
                UserId = Client.Session["UserID"].ToString();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 绑定数据
        /// </summary>
        private void Bind()
        {
            try
            {
                AssetsOutputDto outputDto = _autofacConfig.SettingService.GetAssetsByID(AssId);
                if (outputDto != null)
                {
                    txtAssId.Text = outputDto.AssId;
                    ImgPicture.ResourceID = outputDto.Image;
                    txtNote.Text = outputDto.Note;
                    DatePickerExpiry.Value = outputDto.ExpiryDate;
                    txtName.Text = outputDto.Name;
                    txtPrice.Text = outputDto.Price.ToString();
                    txtSpe.Text = outputDto.Specification;
                    txtNote.Text = outputDto.Note;
                    txtPlace.Text = outputDto.Place;
                    txtSN.Text = outputDto.SN;
                    txtUnit.Text = outputDto.Unit;
                    txtVendor.Text = outputDto.Vendor;
                    treeSelect2.Placeholder = outputDto.DepartmentName;
                    treeSelect2.Tag = outputDto.DepartmentId;
                    DepId = outputDto.DepartmentId;
                    treeAssetsType.Placeholder = outputDto.TypeName;
                    treeAssetsType.Tag = outputDto.TypeId;
                    treeSelect1.Placeholder = outputDto.LocationName;
                    LocationId = outputDto.LocationId;
                    txtManager.Text = outputDto.ManagerName;
                    ManagerId = outputDto.Manager;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}