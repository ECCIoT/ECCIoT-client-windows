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
    public partial class FormDashboard : MetroForm, IEccReceiptListener, IEccDataReceiveListener,IEccExceptionListener
    {
        public FormDashboard()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;
        }

        void IEccExceptionListener.Ecc_BreakOff(Exception e)
        {
            metroTextBox1.AppendText(e.Message + "\n");
        }

        void IEccReceiptListener.Ecc_Closed(IEccReceiptListener listener)
        {
            metroTextBox1.AppendText("关闭与服务器的连接\n");
        }

        void IEccReceiptListener.Ecc_Connection(IEccReceiptListener listener, bool isSucceed)
        {
            metroTextBox1.AppendText("与服务器连接成功\n");
        }

        void IEccDataReceiveListener.Ecc_Received(string msg, int len)
        {
            Console.WriteLine(string.Format("收到信息：{0}，共{1}个字符。\n", msg, len));
            metroTextBox1.AppendText(string.Format("收到信息：{0}，共{1}个字符。\n", msg,len));
        }

        void IEccReceiptListener.Ecc_Sent(IEccReceiptListener listener, string msg, bool isSucceed)
        {
            metroTextBox1.AppendText(string.Format("发送{0}。信息：{1}\n", isSucceed?"成功":"失败",msg));
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ECCIoT.EccDataReceiveListener = this;
            ECCIoT.EccDataReceiveListener = this;
            ECCIoT.Encoding = Encoding.UTF8;
            ECCIoT.Connect(this);
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ECCIoT.Send(this,metroTextBox2.Text);
            metroTextBox2.Text = "";
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            ECCIoT.Close(this);
        }
    }
}
