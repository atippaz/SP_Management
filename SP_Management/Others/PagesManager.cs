﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SP_Management.Pages.HumanResourcePage;
using SP_Management.Pages.OrderList;
using SP_Management.Pages.PackingPage;
using SP_Management.Pages.ProductList;
using SP_Management.Pages.Purchases;

namespace SP_Management.Others
{
    public class PagesManager
    {
        static UserControl page = null;
        static UserControl Dialog = null;
        static string PageCurrent = "";
        public static void OpenPage(string pageSelct,Panel panel,bool close)
        {
            if (close)
            {
            CloseAnotherPage(panel);
            }
            if(pageSelct !="")
            {
                if (pageSelct == "Userlist" && PageCurrent != "Userlist")
                {
                    page = new UserlistPage();
                    PageCurrent = "Userlist";
                }
                else if (pageSelct == "OrderPk")
                {
                    page = new OrderListsPacking();
                    PageCurrent = "OrderPk";
                }
                else if(pageSelct == "Shipping")
                {
                    page = new OrderListShiping();
                    PageCurrent = "Shipping";
                }else if (pageSelct == "ProductListMk")
                {
                    page = new ProductListMk();
                    PageCurrent = "ProductListMk";
                }
                else if (pageSelct == "PurchaseMk")
                {
                    page = new PurchaseMk();
                    PageCurrent = "PurchaseMk";
                }else if(pageSelct == "PurchasePc")
                {
                    page = new PurchasePc();
                    PageCurrent = "PurchaseMk";
                }
                page.Dock = DockStyle.Fill;
                panel.Controls.Add(page);
            }
        }

        public static void OpenDialog(string pageSelct,string id, Panel panel, bool close)
        {
            if (close)
            {
                CloseAnotherPage(panel);
            }
            if (pageSelct != "")
            {
                if (pageSelct == "EditUser" && PageCurrent != "EditUser")
                {
                    Dialog = new DialogUser(id);
                    PageCurrent = "EditUser";
                }
                else if (pageSelct == "AddUser" && PageCurrent != "AddUser" )
                {
                    Dialog = new DialogUser();
                    PageCurrent = "AddUser";
                }
                Dialog.Dock = DockStyle.Fill;
                panel.Controls.Add(Dialog);
            }
        }
        public static void OpenDialog(string pageSelct, Panel panel, bool close)
        {
            if (close)
            {
                CloseAnotherPage(panel);
            }
            if (pageSelct != "")
            {
                if (pageSelct == "AddUser" && PageCurrent != "AddUser")
                {
                    Dialog = new DialogUser();
                    PageCurrent = "AddUser";
                }
                Dialog.Dock = DockStyle.Fill;
                panel.Controls.Add(Dialog);
            }
        }
        public void refrashUserlist() {
          
        }
        public static void CloseDialog(Panel panel)
        {
            if (page != null)
            {
                panel.Controls.Remove(Dialog);
                panel.SendToBack();
                Dialog.Dispose();
                PageCurrent = "";
                Dialog = null;
                GC.Collect();
            }
        }
        public static void CloseAnotherPage(Panel panel)
        {
            if(page != null)
            {
            panel.Controls.Remove(page);
                page.Dispose();
                PageCurrent = "";
                GC.Collect();
            }
        }
    }
}
