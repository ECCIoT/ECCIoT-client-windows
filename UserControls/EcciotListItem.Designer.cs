namespace ECC_client_windows.UserControls
{
    partial class EcciotListItem
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            MetroFramework.Controls.MetroLabel metroLabel1;
            MetroFramework.Controls.MetroLabel metroLabel2;
            MetroFramework.Controls.MetroLabel metroLabel3;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            this.sc = new System.Windows.Forms.SplitContainer();
            this.pic = new System.Windows.Forms.PictureBox();
            this.scText = new System.Windows.Forms.SplitContainer();
            this.mlabName = new MetroFramework.Controls.MetroLabel();
            this.mbtn = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            metroLabel3 = new MetroFramework.Controls.MetroLabel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scText)).BeginInit();
            this.scText.Panel1.SuspendLayout();
            this.scText.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            metroLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            metroLabel1.Location = new System.Drawing.Point(3, 0);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new System.Drawing.Size(94, 40);
            metroLabel1.TabIndex = 0;
            metroLabel1.Text = "metroLabel1";
            metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            metroLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            metroLabel2.Location = new System.Drawing.Point(3, 40);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new System.Drawing.Size(94, 40);
            metroLabel2.TabIndex = 1;
            metroLabel2.Text = "metroLabel2";
            metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            metroLabel3.AutoSize = true;
            metroLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            metroLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            metroLabel3.Location = new System.Drawing.Point(3, 80);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new System.Drawing.Size(94, 44);
            metroLabel3.TabIndex = 2;
            metroLabel3.Text = "metroLabel3";
            metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sc
            // 
            this.sc.BackColor = System.Drawing.Color.Transparent;
            this.sc.Dock = System.Windows.Forms.DockStyle.Top;
            this.sc.Location = new System.Drawing.Point(0, 0);
            this.sc.Name = "sc";
            this.sc.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.sc.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sc.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.sc.Size = new System.Drawing.Size(250, 293);
            this.sc.SplitterDistance = 100;
            this.sc.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(this.pic, 0, 0);
            tableLayoutPanel1.Controls.Add(this.scText, 1, 0);
            tableLayoutPanel1.Controls.Add(this.mbtn, 2, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(250, 100);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Transparent;
            this.pic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic.Image = global::ECC_client_windows.Properties.Resources.LOGO;
            this.pic.Location = new System.Drawing.Point(3, 3);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(100, 94);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            // 
            // scText
            // 
            this.scText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scText.Location = new System.Drawing.Point(109, 3);
            this.scText.Name = "scText";
            this.scText.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scText.Panel1
            // 
            this.scText.Panel1.Controls.Add(this.mlabName);
            // 
            // scText.Panel2
            // 
            this.scText.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.scText.Size = new System.Drawing.Size(95, 94);
            this.scText.SplitterDistance = 31;
            this.scText.TabIndex = 2;
            // 
            // mlabName
            // 
            this.mlabName.BackColor = System.Drawing.Color.Transparent;
            this.mlabName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlabName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlabName.Location = new System.Drawing.Point(0, 0);
            this.mlabName.Name = "mlabName";
            this.mlabName.Size = new System.Drawing.Size(95, 31);
            this.mlabName.TabIndex = 2;
            this.mlabName.Text = "设备名称";
            this.mlabName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mbtn
            // 
            this.mbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtn.BackColor = System.Drawing.Color.Transparent;
            this.mbtn.BackgroundImage = global::ECC_client_windows.Properties.Resources.img_dowm;
            this.mbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtn.Location = new System.Drawing.Point(210, 3);
            this.mbtn.Name = "mbtn";
            this.mbtn.Size = new System.Drawing.Size(37, 94);
            this.mbtn.TabIndex = 3;
            this.mbtn.UseSelectable = true;
            this.mbtn.Click += new System.EventHandler(this.mbtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(metroLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(metroLabel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(metroLabel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.metroTrackBar1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(230, 124);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTrackBar1.Location = new System.Drawing.Point(103, 3);
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(124, 34);
            this.metroTrackBar1.TabIndex = 3;
            this.metroTrackBar1.Text = "metroTrackBar1";
            // 
            // EcciotListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.sc);
            this.Name = "EcciotListItem";
            this.Size = new System.Drawing.Size(250, 103);
            this.SizeChanged += new System.EventHandler(this.EcciotListItem_SizeChanged);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.scText.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scText)).EndInit();
            this.scText.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.SplitContainer scText;
        private MetroFramework.Controls.MetroLabel mlabName;
        private MetroFramework.Controls.MetroButton mbtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
    }
}
