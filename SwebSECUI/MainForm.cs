using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.Domain;
using SMOSEC.DTOs;
using SwebSECUI.MasterData;
using SMOSEC.DTOs.OutputDTO;
using SwebSECUI.AssetsManager;
using SwebSECUI.Department;
using SwebSECUI.ConsumablesManager;
using SwebSECUI.UserInfo;

namespace SwebSECUI
{
    partial class MainForm : Swebui.Controls.SwebForm
    {
        public MainForm() : base()
        {
            //This call is required by the SwebForm.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        
      
        private void exitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("是否退出当前系统？", MessageBoxButtons.YesNo, (object o, MessageBoxHandlerArgs args) =>
            {
                try
                {
                    if (args.Result == ShowResult.Yes)
                    {
                        this.Client.ReStart();
                    }
                }
                catch (Exception ex)
                {
                    Toast(ex.Message, ToastLength.SHORT);
                }
            });
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

            //获取登录账号信息
            //UserDetails userDetails = new UserDetails();
            //UserDepDto user = userDetails.getUser(Client.Session["USER_ID"].ToString());
            //useBtn.Text = user.USER_NAME;
            ////获取menu
            //GetMenu();

            //默认显示主页
            MenuValueChanged(menuView1.Items[0]);
            menuView1.DefaultSelectedItem = menuView1.Items[0];
        }

        private void menuView1_MenuItemClick(object sender, MenuViewItemClickEventArgs e)
        {
            MenuValueChanged(e.Item);
        }
        public void MenuValueChanged(MenuItem menuItem)
        {
            switch (menuItem.Id)
            {
                case "Home":
                    frmAssets frmassets = new frmAssets();
                    AddTabPage(menuItem, frmassets);
                    break;
                case "FrmAssets":
                    frmAssets frmassets1 = new frmAssets();
                    AddTabPage(menuItem, frmassets1);
                    break;
                case "FrmBorrowOrder":
                     frmBorrowOrder frmborroworder = new frmBorrowOrder();
                    AddTabPage(menuItem, frmborroworder);
                    break;
                case "FrmReturnOrder":
                    frmReturnOrder frmreturnOrder = new frmReturnOrder();
                    AddTabPage(menuItem, frmreturnOrder);
                    break;
                case "FrmCollarOrder":
                    frmCollarOrder frmcollarOrder = new frmCollarOrder();
                    AddTabPage(menuItem, frmcollarOrder);
                    break;
                case "FrmRestoreOrder":
                    frmRestoreOrder frmrestoreOrder = new frmRestoreOrder();
                    AddTabPage(menuItem, frmrestoreOrder);
                    break;
                case "FrmRepairRowsSN":
                    frmRepairRowsSN frmrepairRowsSN = new frmRepairRowsSN();
                    AddTabPage(menuItem, frmrepairRowsSN);
                    break;
                case "FrmScrapRowsSN":
                    frmScrapRowsSN frmscrapRowsSN = new frmScrapRowsSN();
                    AddTabPage(menuItem, frmscrapRowsSN);
                    break;
                case "FrmAssInventory":
                    frmAssInventory frmAssinventory = new frmAssInventory();
                    AddTabPage(menuItem, frmAssinventory);
                    break;
                case "FrmAssetsTypeRows":
                    frmAssetsTypeRows frmAssetstypeRows = new frmAssetsTypeRows();
                    AddTabPage(menuItem, frmAssetstypeRows);
                    break;
                case "FrmLocationRows":
                    frmLocationRows frmlocationRows = new frmLocationRows();
                    AddTabPage(menuItem, frmlocationRows);
                    break;
                case "FrmDepartment":
                    frmDepartment frmdepartment = new frmDepartment();
                    AddTabPage(menuItem, frmdepartment);
                    break;
                case "FrmConsumables":
                    frmConsumables frmconsumables = new frmConsumables();
                    AddTabPage(menuItem, frmconsumables);
                    break;
                case "FrmWarehouseReceipt":
                    frmWarehouseReceipt frmwarehouseReceipt = new frmWarehouseReceipt();
                    AddTabPage(menuItem, frmwarehouseReceipt);
                    break;
                case "FrmOutboundOrder":
                    frmOutboundOrder frmoutboundOrder = new frmOutboundOrder();
                    AddTabPage(menuItem, frmoutboundOrder);
                    break;
                case "FrmTransferRows":
                    frmTransferRows frmtransferRows = new frmTransferRows();
                    AddTabPage(menuItem, frmtransferRows);
                    break;
                case "FrmConInventory":
                    frmConInventory frmconInventory = new frmConInventory();
                    AddTabPage(menuItem, frmconInventory);
                    break;
                case "FrmMessage":
                    frmMessage frmmessage = new frmMessage();
                    AddTabPage(menuItem, frmmessage);
                    break;
            }
        }
        private void AddTabPage(MenuItem menuItem, SwebControl menuControl)
        {
            TabPageControl existTagControl = (TabPageControl)this.tabPageView1.Controls.Find(menuItem.Id);
            //判断是否存在tab,存在就跳转，不存在就添加
            if (existTagControl != null)
            {
                if (existTagControl.Controls[0].GetType() != menuControl.GetType())
                {
                    menuControl.Flex = 1;
                    ((TabPageControl)this.tabPageView1.Controls.Find(menuItem.Id)).Controls.Add(menuControl);
                    ((TabPageControl)this.tabPageView1.Controls.Find(menuItem.Id)).Controls.RemoveAt(0);
                }
                this.tabPageView1.PageIndex = this.tabPageView1.Controls.IndexOf(existTagControl);
            }
            else
            {
                TabPageControl tagControl = new TabPageControl();
                tagControl.Name = menuItem.Id;
                menuControl.Flex = 1;
                tagControl.Controls.Add(menuControl);
                this.tabPageView1.Controls.Add(tagControl);
                this.tabPageView1.PageIndex = this.tabPageView1.Controls.Count - 1;
            }

        }

    }
}