using ECC_sdk_windows.Manager;
using ECC_sdk_windows.Manager.Args;
using ECC_sdk_windows.Manager.Function;
using ECCIoT_sdk_windows;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECC_client_windows
{
    public partial class FormSDK : MetroForm,IEccEvevt
    {
        
        public FormSDK()
        {
            InitializeComponent();
            
        }

        void IEccEvevt.EccEvent_Alarm(AlarmEventArgs args)
        {
            throw new NotImplementedException();
        }

        void IEccEvevt.EccEvent_APIKeyInvalid(APIKeyInvalidEventArgs args)
        {
            throw new NotImplementedException();
        }

        void IEccEvevt.EccEvent_APIKeyVerified(APIKeyVerifiedEventArgs args)
        {
            throw new NotImplementedException();
        }

        void IEccEvevt.EccEvent_CheckAPIKey(CheckAPIKeyEventArgs args)
        {
            ECCIoT.Manager.EccCmd_CheckAPIKey(new SendAPIKeyCmdArgs { APIKey = "abcdefg12345678" },successful=> { },failure=> { });
        }

        void IEccEvevt.EccEvent_UpdateItemsData(UpdateItemsDataEventArgs args)
        {
            throw new NotImplementedException();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ECCIoT.Connect(new EccManager(this), 
                successful => {
                    MessageBox.Show("连接成功！");
                }, 
                failure => {
                    MessageBox.Show("连接失败！");
                });
        }
    }
}
