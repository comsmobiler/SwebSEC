using SMOSEC.CommLib;
using SMOSEC.DTOs.InputDTO;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebSECUI.ConsumablesManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmConsumablesDetailEdit : Swebui.Controls.SwebUserControl
    {
        public frmConsumablesDetailEdit() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public string CID;  //耗材编号
        public string UserId;   //用户编号
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConsumablesDetailEdit_Load(object sender, EventArgs e)
        {
            try
            {
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        private void Bind()
        {
            try
            {
                var consumables = _autofacConfig.ConsumablesService.GetConsumablesByID(CID);
                txtAssID.Text = consumables.CID;
                txtCeiling.Text = consumables.SAFECEILING.ToString();
                txtFloor.Text = consumables.SAFEFLOOR.ToString();
                txtName.Text = consumables.NAME;
                txtNote.Text = consumables.NOTE;
                txtSPQ.Text = consumables.SPQ.ToString();
                txtSpe.Text = consumables.SPECIFICATION;
                txtUnit.Text = consumables.UNIT;
                ImgPicture.ResourceID = consumables.IMAGE;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 返回按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmConsumables() { Flex=1}) ;
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 保存按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //判断有效性
                int? Ceiling = null;
                if (!string.IsNullOrEmpty(txtCeiling.Text))
                {
                    int result;
                    if (int.TryParse(txtCeiling.Text, out result))
                    {
                        Ceiling = result;
                    }
                    else
                    {
                        throw new Exception("请输入正确的安全库存上限.");
                    }
                }
                int? Floor = null;
                if (!string.IsNullOrEmpty(txtFloor.Text))
                {
                    int result;
                    if (int.TryParse(txtFloor.Text, out result))
                    {
                        Floor = result;
                    }
                    else
                    {
                        throw new Exception("请输入正确的安全库存下限.");
                    }
                }
                int? SPQ = null;
                if (!string.IsNullOrEmpty(txtSPQ.Text))
                {
                    int result;
                    if (int.TryParse(txtSPQ.Text, out result))
                    {
                        SPQ = result;
                    }
                    else
                    {
                        throw new Exception("请输入正确的标准包装数量.");
                    }
                }
                ConsumablesInputDto consumablesInputDto = new ConsumablesInputDto()
                {
                    CID = CID,
                    CREATEUSER = UserId,
                    IMAGE = ImgPicture.ResourceID,
                    MODIFYUSER = UserId,
                    NAME = txtName.Text,
                    NOTE = txtNote.Text,
                    SAFECEILING = Ceiling,
                    SAFEFLOOR = Floor,
                    SPECIFICATION = txtSpe.Text,
                    SPQ = SPQ,
                    UNIT = txtUnit.Text
                };
                ReturnInfo returnInfo = _autofacConfig.ConsumablesService.UpdateConsumables(consumablesInputDto);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("修改成功.");
                    BackBtn_Click(null, null);
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
        /// 删除按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ReturnInfo returnInfo = _autofacConfig.ConsumablesService.DeleteConsumables(CID);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("删除成功.");
                    BackBtn_Click(null, null);
                }
                else
                {
                    throw new Exception(returnInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 图片上传按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Client.FileUpload((obj, args) => {
                try
                {
                    if (string.IsNullOrEmpty(ImgPicture.ResourceID) == false)
                    {
                        string[] suffixs = args.ResourceID.Split('.');
                        string[] names = ImgPicture.ResourceID.Split('.');
                        string name = names[0] + "." + suffixs[1];
                        args.SaveFile(name, Swebui.SwebResourceManager.DefaultImagePath);
                        ImgPicture.ResourceID = name;
                        Toast("上传成功！");
                    }
                    else
                    {
                        string[] suffixs = args.ResourceID.Split('.');
                        string name = Client.Session["UserId"].ToString() + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + suffixs[1];
                        args.SaveFile(name, Swebui.SwebResourceManager.DefaultImagePath);
                        ImgPicture.ResourceID = name;
                        Toast("上传成功！");
                    }
                }
                catch (Exception ex)
                {
                    Toast(ex.Message);
                }
            });
        }

    }
}