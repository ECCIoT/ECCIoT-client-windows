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
    public partial class EcciotListItem : MetroUserControl
    {
        private EcciotListRefreshManager refreshManager = null;
        public EcciotListRefreshManager RefreshManager
        {
            get { return refreshManager; }
            set { refreshManager = value; }
        }

        private int targetHeight = 0;
        public int TargetHeight
        {
            get { return targetHeight; }
            set { targetHeight = value; if (refreshManager != null) refreshManager.Items.Add(this); }
        }
        private const int maxChangeValue = 100;
        private const int minChangeValue = 5;
        private const float maxChangeProportion = 0.45f;



        public EcciotListItem()
        {
            InitializeComponent();

            int i = sc.Panel2.Height;
            sc.SplitterDistance = this.Height;
            sc.Height = this.Height + i;
            
            ShowBasicItem();
        }

        public void ShowBasicItem()
        {
            TargetHeight = sc.SplitterDistance;
        }

        public void DeleteItem()
        {
            TargetHeight = 0;
        }

        public void ShowAllItem()
        {
            TargetHeight = sc.Height;
        }

        public Boolean RefreshItemSize()
        {
            int speed = 0;

            //设置最大速度
            if (Math.Abs(this.Height - TargetHeight) > maxChangeValue)
            {
                speed = (this.Height > TargetHeight ? 1:-1) * maxChangeValue;
            }
            else
            {
                speed = this.Height - TargetHeight;
            }

            //设置最小速度
            if(Math.Abs(this.Height - TargetHeight)< minChangeValue)
            {
                this.Height = TargetHeight;
                return true;
            }

            this.Height = (int) (this.Height - speed * maxChangeProportion);

            return false;
        }

        private void EcciotListItem_SizeChanged(object sender, EventArgs e)
        {
            pic.Width = pic.Height;
        }

        private void mbtn_Click(object sender, EventArgs e)
        {
            if (TargetHeight == sc.Height)
            {
                ShowBasicItem();
            }
            else
            {
                ShowAllItem();
            }
        }
    }
}
