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
            this.mtpDataView = new MetroFramework.Controls.MetroTabPage();
            this.mtpSettings = new MetroFramework.Controls.MetroTabPage();
            this.tlpDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.mpanelListBox = new MetroFramework.Controls.MetroPanel();
            this.ecciotListBox = new ECC_client_windows.UserControls.EcciotListBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.mtab.SuspendLayout();
            this.mtpDashbard.SuspendLayout();
            this.tlpDashboard.SuspendLayout();
            this.mpanelListBox.SuspendLayout();
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
            this.mtab.SelectedIndex = 0;
            this.mtab.Size = new System.Drawing.Size(1150, 567);
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
            this.mtpDashbard.Size = new System.Drawing.Size(1142, 525);
            this.mtpDashbard.TabIndex = 0;
            this.mtpDashbard.Text = "Dashboard";
            this.mtpDashbard.VerticalScrollbarBarColor = true;
            this.mtpDashbard.VerticalScrollbarHighlightOnWheel = false;
            this.mtpDashbard.VerticalScrollbarSize = 10;
            // 
            // mtpDataView
            // 
            this.mtpDataView.HorizontalScrollbarBarColor = true;
            this.mtpDataView.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpDataView.HorizontalScrollbarSize = 10;
            this.mtpDataView.Location = new System.Drawing.Point(4, 38);
            this.mtpDataView.Name = "mtpDataView";
            this.mtpDataView.Size = new System.Drawing.Size(1142, 525);
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
            this.mtpSettings.Size = new System.Drawing.Size(1142, 525);
            this.mtpSettings.TabIndex = 2;
            this.mtpSettings.Text = "Settings";
            this.mtpSettings.VerticalScrollbarBarColor = true;
            this.mtpSettings.VerticalScrollbarHighlightOnWheel = false;
            this.mtpSettings.VerticalScrollbarSize = 10;
            // 
            // tlpDashboard
            // 
            this.tlpDashboard.ColumnCount = 2;
            this.tlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDashboard.Controls.Add(this.metroButton1, 0, 0);
            this.tlpDashboard.Controls.Add(this.mpanelListBox, 0, 0);
            this.tlpDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDashboard.Location = new System.Drawing.Point(0, 0);
            this.tlpDashboard.Name = "tlpDashboard";
            this.tlpDashboard.RowCount = 1;
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDashboard.Size = new System.Drawing.Size(1142, 525);
            this.tlpDashboard.TabIndex = 2;
            // 
            // mpanelListBox
            // 
            this.mpanelListBox.AutoScroll = true;
            this.mpanelListBox.Controls.Add(this.ecciotListBox);
            this.mpanelListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpanelListBox.HorizontalScrollbar = true;
            this.mpanelListBox.HorizontalScrollbarBarColor = true;
            this.mpanelListBox.HorizontalScrollbarHighlightOnWheel = false;
            this.mpanelListBox.HorizontalScrollbarSize = 10;
            this.mpanelListBox.Location = new System.Drawing.Point(3, 3);
            this.mpanelListBox.Name = "mpanelListBox";
            this.mpanelListBox.Size = new System.Drawing.Size(565, 519);
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
            this.ecciotListBox.Size = new System.Drawing.Size(540, 333);
            this.ecciotListBox.TabIndex = 2;
            this.ecciotListBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ecciotListBox.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(574, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(142, 56);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "添加一个测试项";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 647);
            this.Controls.Add(this.mtab);
            this.Name = "FormDashboard";
            this.Text = "ECCIoT Client for Windows";
            this.mtab.ResumeLayout(false);
            this.mtpDashbard.ResumeLayout(false);
            this.tlpDashboard.ResumeLayout(false);
            this.mpanelListBox.ResumeLayout(false);
            this.mpanelListBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtab;
        private MetroFramework.Controls.MetroTabPage mtpDashbard;
        private MetroFramework.Controls.MetroTabPage mtpDataView;
        private MetroFramework.Controls.MetroTabPage mtpSettings;
        private System.Windows.Forms.TableLayoutPanel tlpDashboard;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroPanel mpanelListBox;
        private UserControls.EcciotListBox ecciotListBox;
    }
}