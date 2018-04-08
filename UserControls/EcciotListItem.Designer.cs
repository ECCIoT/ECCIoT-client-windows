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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            this.pic = new System.Windows.Forms.PictureBox();
            this.scText = new System.Windows.Forms.SplitContainer();
            this.mlabName = new MetroFramework.Controls.MetroLabel();
            this.mbtn = new MetroFramework.Controls.MetroButton();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scText)).BeginInit();
            this.scText.Panel1.SuspendLayout();
            this.scText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.SuspendLayout();
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
            tableLayoutPanel1.Size = new System.Drawing.Size(259, 100);
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
            this.scText.Size = new System.Drawing.Size(104, 94);
            this.scText.SplitterDistance = 49;
            this.scText.TabIndex = 2;
            // 
            // mlabName
            // 
            this.mlabName.BackColor = System.Drawing.Color.Transparent;
            this.mlabName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlabName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlabName.Location = new System.Drawing.Point(0, 0);
            this.mlabName.Name = "mlabName";
            this.mlabName.Size = new System.Drawing.Size(104, 49);
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
            this.mbtn.Location = new System.Drawing.Point(219, 3);
            this.mbtn.Name = "mbtn";
            this.mbtn.Size = new System.Drawing.Size(37, 94);
            this.mbtn.TabIndex = 3;
            this.mbtn.UseSelectable = true;
            this.mbtn.Click += new System.EventHandler(this.Mbtn_Click);
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
            this.sc.Size = new System.Drawing.Size(259, 282);
            this.sc.SplitterDistance = 100;
            this.sc.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(239, 125);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // EcciotListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.sc);
            this.Name = "EcciotListItem";
            this.Size = new System.Drawing.Size(259, 101);
            this.Load += new System.EventHandler(this.EcciotListItem_Load);
            this.SizeChanged += new System.EventHandler(this.EcciotListItem_SizeChanged);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.scText.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scText)).EndInit();
            this.scText.ResumeLayout(false);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.SplitContainer scText;
        private MetroFramework.Controls.MetroButton mbtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroLabel mlabName;
    }
}
