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
    public partial class EcciotListBox : MetroUserControl
    {
        private EcciotListRefreshManager refreshManager = new EcciotListRefreshManager();
        public EcciotListRefreshManager RefreshManager
        {
            get { return refreshManager; }
        }


        public EcciotListBox()
        {
            InitializeComponent();
        }

        public void AddItem(EcciotListItem item)
        {
            //扩大表格容量并加入EcciotListItem对象
            this.tlp.RowCount += 1;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp.Controls.Add(item, 0, this.tlp.RowCount-1);

            //设置EcciotListItem的属性
            item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            item.Dock = System.Windows.Forms.DockStyle.Fill;
            item.UseSelectable = true;

            //添加EcciotListRefreshManager
            if (!RefreshManager.Items.Contains(item))
            {
                item.RefreshManager = this.refreshManager;
            }
        }

        private void tlp_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class EcciotListRefreshManager
    {
        //计时器
        private Timer timer = new Timer();
        //项列表
        private EcciotItemList listItem = new EcciotItemList();
        public EcciotItemList Items
        {
            get { timer.Enabled = true;  return listItem;  }
            set { listItem = value; timer.Enabled = true; }
        }

        public EcciotListRefreshManager()
        {
            timer.Interval = 1;
            timer.Tick += delegate{
                if (Items.Count == 0)
                {
                    timer.Enabled = false;
                    return;
                }

                //执行列表中所有项的刷新方法
                for (int i= 0;i < Items.Count;i++)
                {
                    EcciotListItem item = Items[i];

                    if (item.RefreshItemSize())
                    {
                        Items.RemoveAt(i);
                        i--;

                        if (Items.Count == 0)
                        {
                            timer.Enabled = false;
                            break;
                        }
                    }
                }
            };
            timer.Enabled = true;
        }
    }

    public class EcciotItemList : List<EcciotListItem>
    {
        public new void Add(EcciotListItem item)
        {
            if (this.Contains(item))
            {
                return;
            }
            else
            {
                base.Add(item);
            }
        }
    }
}
