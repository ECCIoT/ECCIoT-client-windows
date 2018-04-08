using ECC_client_windows.UserControls;
using ECCIoT_sdk_windows;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECC_client_windows.Form
{
    public partial class FormDashboard : MetroForm
    {
        public FormDashboard()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void MetroButton1_Click_1(object sender, EventArgs e)
        {
            EcciotListItem.ItemInfo info = new EcciotListItem.ItemInfo
            {
                Name = "测试设备 - " + new Random().Next(100, 1000)
            };
            EcciotListItem item = new EcciotListItem(info);
            ecciotListBox.AddItem(item);
        }

    }
}
