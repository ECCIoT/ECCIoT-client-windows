using ECC_client_windows.UserControls;
using MetroFramework.Forms;
using System;
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
