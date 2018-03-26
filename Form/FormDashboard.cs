using ECC_client_windows.UserControls;
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
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            EcciotListItem item = new EcciotListItem();
            item.Device_id = "测试设备 - " + new Random().Next(100, 1000);
            ecciotListBox.AddItem(item);
        }
    }
}
