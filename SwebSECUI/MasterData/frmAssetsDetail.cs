using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.OutputDTO;
using Smobiler.Device;
using SMOSEC.DTOs.Enum;
using SwebSECUI.Layout;

namespace SwebSECUI.MasterData
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssetsDetail : Swebui.Controls.SwebUserControl
    {
        public frmAssetsDetail() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        public string AssId; //资产编号
        private string LocationId; //区域编号
        private string TypeId; //类型编号
        private string ManagerId; //管理员编号
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private string LastUser; //资产最近的拥有者
        private string DepId; //部门编号
        #endregion
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmAssets() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
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
                    DepId = outputDto.DepartmentId;
                    txtEDate.Text = outputDto.ExpiryDate.ToString("yyyy-MM-dd");
                    txtAssId1.Text = outputDto.AssId;
                    txtBuyDate.Text = outputDto.BuyDate.ToString("yyyy-MM-dd");
                    txtDep.Text = outputDto.DepartmentName;
                    txtLocation1.Text = outputDto.LocationName;
                    txtManager.Text = outputDto.ManagerName;
                    txtName1.Text = outputDto.Name;
                    txtPlace1.Text = outputDto.Place;
                    txtPrice1.Text = outputDto.Price.ToString();
                    txtSN1.Text = outputDto.SN;
                    txtSPE1.Text = outputDto.Specification;
                    txtType.Text = outputDto.TypeName;
                    txtUnit1.Text = outputDto.Unit;
                    txtVendor1.Text = outputDto.Vendor;
                    ImgPicture.ResourceID = outputDto.Image;
                    txtNote1.Text = outputDto.Note;
                    LocationId = outputDto.LocationId;
                    TypeId = outputDto.TypeId;
                    //if (string.IsNullOrEmpty(outputDto.CurrentUser))
                    //{
                    //    btnChange.Visible = false;
                    //    btnChange.Enabled = false;
                    //}
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void frmAssetsDetail_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 跳转到资产编辑界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditBtn_Click(object sender, EventArgs e)
        {
            frmAssetsDetailEdit assetsDetailEdit = new frmAssetsDetailEdit { AssId = AssId, DepId = DepId,Flex = 1 };
            this.Parent.Controls.Add(assetsDetailEdit);
            this.Parent.Controls.RemoveAt(0);
        }

        private void UserChangeBtn_Click(object sender, EventArgs e)
        {
            frmUserChangeLayout frm = new frmUserChangeLayout();
            this.ShowDialog(frm);
            this.ShowDialog(frm, (obj, args) => {
                if (frm.ShowResult == ShowResult.Yes)
                {
                    Bind();
                }
            });
        }
    }

}