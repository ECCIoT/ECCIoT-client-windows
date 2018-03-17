namespace ECC_client_windows
{
    partial class FormAPIKey
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            MetroFramework.Controls.MetroLabel metroLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAPIKey));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.mtxtAPIkey = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            metroLabel1.AutoSize = true;
            metroLabel1.Location = new System.Drawing.Point(0, 197);
            metroLabel1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new System.Drawing.Size(181, 20);
            metroLabel1.TabIndex = 2;
            metroLabel1.Text = "Please input your API key：";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.metroProgressSpinner1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mtxtAPIkey, 0, 4);
            this.tableLayoutPanel1.Controls.Add(metroLabel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroButton1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.metroLink1, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 470);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroProgressSpinner1.Location = new System.Drawing.Point(142, 67);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(75, 75);
            this.metroProgressSpinner1.TabIndex = 3;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Value = 100;
            // 
            // mtxtAPIkey
            // 
            this.mtxtAPIkey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtAPIkey.CustomButton.Image = null;
            this.mtxtAPIkey.CustomButton.Location = new System.Drawing.Point(336, 1);
            this.mtxtAPIkey.CustomButton.Name = "";
            this.mtxtAPIkey.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtAPIkey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtAPIkey.CustomButton.TabIndex = 1;
            this.mtxtAPIkey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtAPIkey.CustomButton.UseSelectable = true;
            this.mtxtAPIkey.Lines = new string[0];
            this.mtxtAPIkey.Location = new System.Drawing.Point(0, 227);
            this.mtxtAPIkey.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.mtxtAPIkey.MaxLength = 32767;
            this.mtxtAPIkey.Name = "mtxtAPIkey";
            this.mtxtAPIkey.PasswordChar = '●';
            this.mtxtAPIkey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtAPIkey.SelectedText = "";
            this.mtxtAPIkey.SelectionLength = 0;
            this.mtxtAPIkey.SelectionStart = 0;
            this.mtxtAPIkey.ShortcutsEnabled = true;
            this.mtxtAPIkey.ShowButton = true;
            this.mtxtAPIkey.ShowClearButton = true;
            this.mtxtAPIkey.Size = new System.Drawing.Size(360, 25);
            this.mtxtAPIkey.TabIndex = 3;
            this.mtxtAPIkey.UseSelectable = true;
            this.mtxtAPIkey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtAPIkey.WaterMarkFont = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(3, 268);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(354, 30);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Connect";
            this.metroButton1.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(3, 419);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(354, 51);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "ECCIoT Client for Windows\r\nCopyright © 2018 Landriesnidis.\r\nAll Rights Reserved.";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLink1
            // 
            this.metroLink1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLink1.Location = new System.Drawing.Point(243, 304);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(114, 23);
            this.metroLink1.TabIndex = 6;
            this.metroLink1.Text = "No API key？";
            this.metroLink1.UseSelectable = true;
            // 
            // FormAPIKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAPIKey";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Check API Key";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroTextBox mtxtAPIkey;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}

