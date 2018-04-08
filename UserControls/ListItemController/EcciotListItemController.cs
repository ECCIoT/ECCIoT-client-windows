using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace ECC_client_windows.UserControls
{
    public partial class EcciotListItemController : MetroUserControl
    {
        public EcciotListItemController()
        {
            InitializeComponent();
        }

        public EcciotListItemController(string name, Control control)
        {
            InitializeComponent();
            labName.Text = name;
            AddControl(control);
        }

        public void AddControl(Control control)
        {
            metroPanel.Controls.Clear();
            metroPanel.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }
    }
}
