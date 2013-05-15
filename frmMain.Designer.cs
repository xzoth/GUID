namespace GUID
{
    partial class frmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnGenGUID = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoHand = new System.Windows.Forms.RadioButton();
            this.rdoRef = new System.Windows.Forms.RadioButton();
            this.rdoNoFormat = new System.Windows.Forms.RadioButton();
            this.cmbCount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxGUID = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenGUID
            // 
            this.btnGenGUID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenGUID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenGUID.Location = new System.Drawing.Point(227, 427);
            this.btnGenGUID.Name = "btnGenGUID";
            this.btnGenGUID.Size = new System.Drawing.Size(75, 23);
            this.btnGenGUID.TabIndex = 0;
            this.btnGenGUID.Text = "生成GUID";
            this.btnGenGUID.UseVisualStyleBackColor = true;
            this.btnGenGUID.Click += new System.EventHandler(this.btnGenGUID_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdoHand);
            this.groupBox1.Controls.Add(this.rdoRef);
            this.groupBox1.Controls.Add(this.rdoNoFormat);
            this.groupBox1.Controls.Add(this.cmbCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // rdoHand
            // 
            this.rdoHand.AutoSize = true;
            this.rdoHand.Location = new System.Drawing.Point(184, 63);
            this.rdoHand.Name = "rdoHand";
            this.rdoHand.Size = new System.Drawing.Size(83, 16);
            this.rdoHand.TabIndex = 5;
            this.rdoHand.Text = "{带花括号}";
            this.rdoHand.UseVisualStyleBackColor = true;
            // 
            // rdoRef
            // 
            this.rdoRef.AutoSize = true;
            this.rdoRef.Location = new System.Drawing.Point(95, 63);
            this.rdoRef.Name = "rdoRef";
            this.rdoRef.Size = new System.Drawing.Size(83, 16);
            this.rdoRef.TabIndex = 4;
            this.rdoRef.Text = "\"带双引号\"";
            this.rdoRef.UseVisualStyleBackColor = true;
            // 
            // rdoNoFormat
            // 
            this.rdoNoFormat.AutoSize = true;
            this.rdoNoFormat.Checked = true;
            this.rdoNoFormat.Location = new System.Drawing.Point(18, 63);
            this.rdoNoFormat.Name = "rdoNoFormat";
            this.rdoNoFormat.Size = new System.Drawing.Size(71, 16);
            this.rdoNoFormat.TabIndex = 3;
            this.rdoNoFormat.TabStop = true;
            this.rdoNoFormat.Text = "不带格式";
            this.rdoNoFormat.UseVisualStyleBackColor = true;
            // 
            // cmbCount
            // 
            this.cmbCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCount.FormattingEnabled = true;
            this.cmbCount.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "40",
            "80"});
            this.cmbCount.Location = new System.Drawing.Point(87, 26);
            this.cmbCount.Name = "cmbCount";
            this.cmbCount.Size = new System.Drawing.Size(181, 20);
            this.cmbCount.TabIndex = 2;
            this.cmbCount.Text = "40";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "生成个数：";
            // 
            // txtBoxGUID
            // 
            this.txtBoxGUID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxGUID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBoxGUID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtBoxGUID.Location = new System.Drawing.Point(13, 112);
            this.txtBoxGUID.Multiline = true;
            this.txtBoxGUID.Name = "txtBoxGUID";
            this.txtBoxGUID.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxGUID.Size = new System.Drawing.Size(289, 309);
            this.txtBoxGUID.TabIndex = 2;
            this.txtBoxGUID.TextChanged += new System.EventHandler(this.txtBoxGUID_TextChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Enabled = false;
            this.btnCopy.Location = new System.Drawing.Point(146, 427);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "复制";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = "E:\\资料\\xzoth工作目录\\IrisSkin\\dotnet 皮肤dll\\SSK皮肤\\RealOne\\RealOne.ssk";
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 462);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtBoxGUID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenGUID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(330, 500);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUID生成器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenGUID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxGUID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCount;
        private System.Windows.Forms.RadioButton rdoHand;
        private System.Windows.Forms.RadioButton rdoRef;
        private System.Windows.Forms.RadioButton rdoNoFormat;
        private System.Windows.Forms.Button btnCopy;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}

