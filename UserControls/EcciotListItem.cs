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
using Newtonsoft.Json.Linq;

namespace ECC_client_windows.UserControls
{
    public partial class EcciotListItem : MetroUserControl
    {
        //父容器中控制控件尺寸刷新的管理器
        private EcciotListRefreshManager refreshManager = null;
        public EcciotListRefreshManager RefreshManager
        {
            get { return refreshManager; }
            set { refreshManager = value; }
        }

        //控件高度伸展的目标值
        private int targetHeight = 0;
        public int TargetHeight
        {
            get { return targetHeight; }
            //当目标值发生改变的时候激活父类中的尺寸刷新管理器
            set { targetHeight = value; if (refreshManager != null) refreshManager.Items.Add(this); }
        }

        //高度变化时的最大差值
        private const int maxChangeValue = 100;
        //高度变化时的最小差值
        private const int minChangeValue = 5;
        //单次变化的最大比例
        private const float maxChangeProportion = 0.35f;

        public EcciotListItem()
        {
            InitializeComponent();
        }

        private void EcciotListItem_Load(object sender, EventArgs e)
        {
            int i = sc.Panel2.Height;
            sc.SplitterDistance = this.Height;
            sc.Height = this.Height + i;

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

        /// <summary>
        /// 控件尺寸刷新方法（被来父类的尺寸管理器调用）
        /// </summary>
        /// <returns>当运动结束返回True，未结束则返回False</returns>
        public Boolean RefreshItemSize()
        {
            int speed = minChangeValue;

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
            if(Math.Abs(this.Height - TargetHeight) <= minChangeValue)
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
            //转变运动方向
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

    public class ATCommand
    {
        public string Command { get; private set; }
        public byte ParamCount{ get; private set; }

        ATCommand(string CommandName, byte ParamCount)
        {
            this.Command = CommandName;
            this.ParamCount = ParamCount;
        }

        public string Builder(params string[] p)
        {
            return null;
        }
    }

    /// <summary>
    /// 设备信息类，可直接通过Json.net库进行序列化和反序列化
    /// </summary>
    public class DeviceInfo
    {
        public string ID{ get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
    }
}
