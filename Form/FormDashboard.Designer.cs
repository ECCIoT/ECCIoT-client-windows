namespace ECC_client_windows.Form
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtab = new MetroFramework.Controls.MetroTabControl();
            this.mtpDashbard = new MetroFramework.Controls.MetroTabPage();
            this.tlpDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.mpanelListBox = new MetroFramework.Controls.MetroPanel();
            this.ecciotListBox = new ECC_client_windows.UserControls.EcciotListBox();
            this.mtpDataView = new MetroFramework.Controls.MetroTabPage();
            this.mtpSettings = new MetroFramework.Controls.MetroTabPage();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.mtab.SuspendLayout();
            this.mtpDashbard.SuspendLayout();
            this.tlpDashboard.SuspendLayout();
            this.mpanelListBox.SuspendLayout();
            this.mtpDataView.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtab
            // 
            this.mtab.Controls.Add(this.mtpDashbard);
            this.mtab.Controls.Add(this.mtpDataView);
            this.mtab.Controls.Add(this.mtpSettings);
            this.mtab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtab.Location = new System.Drawing.Point(20, 60);
            this.mtab.Name = "mtab";
            this.mtab.SelectedIndex = 1;
            this.mtab.Size = new System.Drawing.Size(1050, 773);
            this.mtab.TabIndex = 0;
            this.mtab.UseSelectable = true;
            // 
            // mtpDashbard
            // 
            this.mtpDashbard.Controls.Add(this.tlpDashboard);
            this.mtpDashbard.HorizontalScrollbarBarColor = true;
            this.mtpDashbard.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpDashbard.HorizontalScrollbarSize = 10;
            this.mtpDashbard.Location = new System.Drawing.Point(4, 38);
            this.mtpDashbard.Name = "mtpDashbard";
            this.mtpDashbard.Size = new System.Drawing.Size(1042, 731);
            this.mtpDashbard.TabIndex = 0;
            this.mtpDashbard.Text = "Dashboard";
            this.mtpDashbard.VerticalScrollbarBarColor = true;
            this.mtpDashbard.VerticalScrollbarHighlightOnWheel = false;
            this.mtpDashbard.VerticalScrollbarSize = 10;
            // 
            // tlpDashboard
            // 
            this.tlpDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDashboard.ColumnCount = 2;
            this.tlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDashboard.Controls.Add(this.metroButton1, 0, 0);
            this.tlpDashboard.Controls.Add(this.mpanelListBox, 0, 0);
            this.tlpDashboard.Location = new System.Drawing.Point(3, 3);
            this.tlpDashboard.Name = "tlpDashboard";
            this.tlpDashboard.RowCount = 1;
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDashboard.Size = new System.Drawing.Size(1039, 725);
            this.tlpDashboard.TabIndex = 2;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(522, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(142, 56);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "添加一个测试项";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click_1);
            // 
            // mpanelListBox
            // 
            this.mpanelListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpanelListBox.AutoScroll = true;
            this.mpanelListBox.Controls.Add(this.ecciotListBox);
            this.mpanelListBox.HorizontalScrollbar = true;
            this.mpanelListBox.HorizontalScrollbarBarColor = true;
            this.mpanelListBox.HorizontalScrollbarHighlightOnWheel = false;
            this.mpanelListBox.HorizontalScrollbarSize = 10;
            this.mpanelListBox.Location = new System.Drawing.Point(3, 3);
            this.mpanelListBox.Name = "mpanelListBox";
            this.mpanelListBox.Size = new System.Drawing.Size(513, 719);
            this.mpanelListBox.TabIndex = 8;
            this.mpanelListBox.VerticalScrollbar = true;
            this.mpanelListBox.VerticalScrollbarBarColor = true;
            this.mpanelListBox.VerticalScrollbarHighlightOnWheel = false;
            this.mpanelListBox.VerticalScrollbarSize = 10;
            // 
            // ecciotListBox
            // 
            this.ecciotListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ecciotListBox.AutoSize = true;
            this.ecciotListBox.Location = new System.Drawing.Point(3, 3);
            this.ecciotListBox.Name = "ecciotListBox";
            this.ecciotListBox.Size = new System.Drawing.Size(495, 333);
            this.ecciotListBox.TabIndex = 2;
            this.ecciotListBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ecciotListBox.UseSelectable = true;
            // 
            // mtpDataView
            // 
            this.mtpDataView.Controls.Add(this.metroButton4);
            this.mtpDataView.Controls.Add(this.metroTextBox2);
            this.mtpDataView.Controls.Add(this.metroTextBox1);
            this.mtpDataView.Controls.Add(this.metroButton3);
            this.mtpDataView.Controls.Add(this.metroButton2);
            this.mtpDataView.HorizontalScrollbarBarColor = true;
            this.mtpDataView.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpDataView.HorizontalScrollbarSize = 10;
            this.mtpDataView.Location = new System.Drawing.Point(4, 38);
            this.mtpDataView.Name = "mtpDataView";
            this.mtpDataView.Size = new System.Drawing.Size(1042, 731);
            this.mtpDataView.TabIndex = 1;
            this.mtpDataView.Text = "Data Charts";
            this.mtpDataView.VerticalScrollbarBarColor = true;
            this.mtpDataView.VerticalScrollbarHighlightOnWheel = false;
            this.mtpDataView.VerticalScrollbarSize = 10;
            // 
            // mtpSettings
            // 
            this.mtpSettings.HorizontalScrollbarBarColor = true;
            this.mtpSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpSettings.HorizontalScrollbarSize = 10;
            this.mtpSettings.Location = new System.Drawing.Point(4, 38);
            this.mtpSettings.Name = "mtpSettings";
            this.mtpSettings.Size = new System.Drawing.Size(1042, 731);
            this.mtpSettings.TabIndex = 2;
            this.mtpSettings.Text = "Settings";
            this.mtpSettings.VerticalScrollbarBarColor = true;
            this.mtpSettings.VerticalScrollbarHighlightOnWheel = false;
            this.mtpSettings.VerticalScrollbarSize = 10;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(3, 3);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "连接";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(3, 32);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 3;
            this.metroButton3.Text = "发送";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(355, 355);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox1.Location = new System.Drawing.Point(554, 0);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(492, 360);
            this.metroTextBox1.TabIndex = 4;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[] {
        "metroTextBox2"};
            this.metroTextBox2.Location = new System.Drawing.Point(84, 32);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(321, 23);
            this.metroTextBox2.TabIndex = 5;
            this.metroTextBox2.Text = "metroTextBox2";
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(84, 3);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(75, 23);
            this.metroButton4.TabIndex = 6;
            this.metroButton4.Text = "metroButton4";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 853);
            this.Controls.Add(this.mtab);
            this.Name = "FormDashboard";
            this.Text = "ECCIoT Client for Windows";
            this.mtab.ResumeLayout(false);
            this.mtpDashbard.ResumeLayout(false);
            this.tlpDashboard.ResumeLayout(false);
            this.mpanelListBox.ResumeLayout(false);
            this.mpanelListBox.PerformLayout();
            this.mtpDataView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtab;
        private MetroFramework.Controls.MetroTabPage mtpDataView;
        private MetroFramework.Controls.MetroTabPage mtpSettings;
        private System.Windows.Forms.TableLayoutPanel tlpDashboard;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroPanel mpanelListBox;
        private UserControls.EcciotListBox ecciotListBox;
        private MetroFramework.Controls.MetroTabPage mtpDashbard;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroButton metroButton4;
    }
}