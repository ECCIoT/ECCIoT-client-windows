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

        //列表项信息
        private ItemInfo Info { get; set; }

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

        public EcciotListItem(ItemInfo info)
        {
            InitializeComponent();
            Info = info;
        }

        private void EcciotListItem_Load(object sender, EventArgs e)
        {
            int i = sc.Panel2.Height;
            sc.SplitterDistance = this.Height;
            sc.Height = this.Height + i;

            //加载信息
            LoadInfo();
        }

        /// <summary>
        /// 显示基本界面
        /// </summary>
        public void ShowMinItem()
        {
            TargetHeight = sc.SplitterDistance;
        }

        /// <summary>
        /// 显示完整界面
        /// </summary>
        public void ShowMaxItem()
        {
            TargetHeight = sc.Height;
        }

        public void DeleteItem()
        {
            TargetHeight = 0;
        }

        /// <summary>
        /// 加载信息
        /// </summary>
        private void LoadInfo()
        {
            mlabName.Text = Info.Name;
        }

        public void AddControl(Control control)
        {
            scText.Panel2.Controls.Clear();
            scText.Panel2.Controls.Add(control);
            control.Dock = DockStyle.Fill;
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

        private void Mbtn_Click(object sender, EventArgs e)
        {
            //转变运动方向
            if (TargetHeight == sc.Height)
            {
                ShowMinItem();
            }
            else
            {
                ShowMaxItem();
            }
        }

        /// <summary>
        /// 设备信息类
        /// 可直接通过Json.net库进行序列化和反序列化
        /// ItemInfo info = JsonConvert.DeserializeObject<ItemInfo>(json);
        /// </summary>
        public class ItemInfo
        {
            public string ItemID { get; set; }
            public string Name { get; set; }
            public string Model { get; set; }
        }
    }

    /// <summary>
    /// AT指令构造工具类
    /// </summary>
    public class ATCommand
    {
        public string Command { get; private set; }
        public byte ParamCount{ get; private set; }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="CommandName">AT指令名称</param>
        /// <param name="ParamCount">指令标准参数个数</param>
        ATCommand(string CommandName, byte ParamCount)
        {
            this.Command = CommandName;
            this.ParamCount = ParamCount;
        }

        /// <summary>
        /// 构造AT指令
        /// </summary>
        /// <param name="p">参数数组</param>
        /// <returns></returns>
        public string Builder(params string[] p)
        {
            StringBuilder sb = new StringBuilder("AT+");
            sb.Append(Command);

            //有参数
            if (p.Length > 0)
            {
                sb.Append("=");
                sb.Append(p[0]);
                for (int i=1;i<p.Length;i++)
                {
                    sb.Append(",");
                    sb.Append(p[i]);
                }
            }

            return sb.ToString();
        }
    }
}
