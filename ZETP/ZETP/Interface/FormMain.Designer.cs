namespace ZETP.Interface
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.TsMain = new System.Windows.Forms.ToolStrip();
            this.TsMainBtnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.TsMainBtnCloseFile = new System.Windows.Forms.ToolStripButton();
            this.OfdMain = new System.Windows.Forms.OpenFileDialog();
            this.LblSelectedFile = new System.Windows.Forms.Label();
            this.TbxSelectedFile = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblOutpout = new System.Windows.Forms.Label();
            this.DgvMethods = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblClassName = new System.Windows.Forms.Label();
            this.TbxClassName = new System.Windows.Forms.Label();
            this.DgvConstructors = new System.Windows.Forms.DataGridView();
            this.TbxOutpoutConsole = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnCreateObject = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnCallMethod = new System.Windows.Forms.Button();
            this.TsMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMethods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConstructors)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TsMain
            // 
            this.TsMain.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.TsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsMainBtnOpenFile,
            this.TsMainBtnCloseFile});
            this.TsMain.Location = new System.Drawing.Point(0, 0);
            this.TsMain.Name = "TsMain";
            this.TsMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TsMain.Size = new System.Drawing.Size(1084, 63);
            this.TsMain.TabIndex = 0;
            this.TsMain.Text = "toolStrip1";
            // 
            // TsMainBtnOpenFile
            // 
            this.TsMainBtnOpenFile.AutoSize = false;
            this.TsMainBtnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsMainBtnOpenFile.Image = global::ZETP.Properties.Resources._1431670061_Open;
            this.TsMainBtnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsMainBtnOpenFile.Name = "TsMainBtnOpenFile";
            this.TsMainBtnOpenFile.Size = new System.Drawing.Size(50, 50);
            this.TsMainBtnOpenFile.ToolTipText = "Open File";
            this.TsMainBtnOpenFile.Click += new System.EventHandler(this.TsMainBtnOpenFile_Click);
            // 
            // TsMainBtnCloseFile
            // 
            this.TsMainBtnCloseFile.AutoSize = false;
            this.TsMainBtnCloseFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsMainBtnCloseFile.Enabled = false;
            this.TsMainBtnCloseFile.Image = global::ZETP.Properties.Resources._1431671305_Close;
            this.TsMainBtnCloseFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsMainBtnCloseFile.Name = "TsMainBtnCloseFile";
            this.TsMainBtnCloseFile.Size = new System.Drawing.Size(50, 50);
            this.TsMainBtnCloseFile.ToolTipText = "Close File";
            this.TsMainBtnCloseFile.Click += new System.EventHandler(this.TsMainBtnCloseFile_Click);
            // 
            // OfdMain
            // 
            this.OfdMain.FileName = "openFileDialog1";
            // 
            // LblSelectedFile
            // 
            this.LblSelectedFile.AutoSize = true;
            this.LblSelectedFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSelectedFile.Location = new System.Drawing.Point(3, 30);
            this.LblSelectedFile.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.LblSelectedFile.Name = "LblSelectedFile";
            this.LblSelectedFile.Size = new System.Drawing.Size(75, 18);
            this.LblSelectedFile.TabIndex = 0;
            this.LblSelectedFile.Text = "Selected File:";
            this.LblSelectedFile.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TbxSelectedFile
            // 
            this.TbxSelectedFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbxSelectedFile.Enabled = false;
            this.TbxSelectedFile.Location = new System.Drawing.Point(84, 27);
            this.TbxSelectedFile.Name = "TbxSelectedFile";
            this.TbxSelectedFile.Size = new System.Drawing.Size(697, 20);
            this.TbxSelectedFile.TabIndex = 1;
            this.TbxSelectedFile.Text = "No selected file";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.LblOutpout, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.DgvMethods, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblClassName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblSelectedFile, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TbxSelectedFile, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TbxClassName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.DgvConstructors, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TbxOutpoutConsole, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1084, 481);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LblOutpout
            // 
            this.LblOutpout.AutoSize = true;
            this.LblOutpout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblOutpout.Location = new System.Drawing.Point(794, 6);
            this.LblOutpout.Margin = new System.Windows.Forms.Padding(10, 6, 3, 0);
            this.LblOutpout.Name = "LblOutpout";
            this.LblOutpout.Size = new System.Drawing.Size(287, 18);
            this.LblOutpout.TabIndex = 9;
            this.LblOutpout.Text = "Outpout:";
            // 
            // DgvMethods
            // 
            this.DgvMethods.AllowUserToAddRows = false;
            this.DgvMethods.AllowUserToDeleteRows = false;
            this.DgvMethods.BackgroundColor = System.Drawing.Color.LightGray;
            this.DgvMethods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvMethods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMethods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMethods.Location = new System.Drawing.Point(84, 297);
            this.DgvMethods.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.DgvMethods.Name = "DgvMethods";
            this.DgvMethods.ReadOnly = true;
            this.DgvMethods.Size = new System.Drawing.Size(697, 174);
            this.DgvMethods.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(21, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Methods:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Constructors:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblClassName
            // 
            this.LblClassName.AutoSize = true;
            this.LblClassName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblClassName.Location = new System.Drawing.Point(3, 54);
            this.LblClassName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.LblClassName.Name = "LblClassName";
            this.LblClassName.Size = new System.Drawing.Size(75, 54);
            this.LblClassName.TabIndex = 2;
            this.LblClassName.Text = "Class Name:";
            this.LblClassName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbxClassName
            // 
            this.TbxClassName.AutoSize = true;
            this.TbxClassName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbxClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxClassName.Location = new System.Drawing.Point(84, 54);
            this.TbxClassName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.TbxClassName.Name = "TbxClassName";
            this.TbxClassName.Size = new System.Drawing.Size(697, 54);
            this.TbxClassName.TabIndex = 3;
            this.TbxClassName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DgvConstructors
            // 
            this.DgvConstructors.AllowUserToAddRows = false;
            this.DgvConstructors.AllowUserToDeleteRows = false;
            this.DgvConstructors.BackgroundColor = System.Drawing.Color.LightGray;
            this.DgvConstructors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvConstructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConstructors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvConstructors.Location = new System.Drawing.Point(84, 111);
            this.DgvConstructors.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.DgvConstructors.Name = "DgvConstructors";
            this.DgvConstructors.ReadOnly = true;
            this.DgvConstructors.Size = new System.Drawing.Size(697, 173);
            this.DgvConstructors.TabIndex = 6;
            // 
            // TbxOutpoutConsole
            // 
            this.TbxOutpoutConsole.BackColor = System.Drawing.Color.White;
            this.TbxOutpoutConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbxOutpoutConsole.Enabled = false;
            this.TbxOutpoutConsole.Location = new System.Drawing.Point(794, 27);
            this.TbxOutpoutConsole.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.TbxOutpoutConsole.Multiline = true;
            this.TbxOutpoutConsole.Name = "TbxOutpoutConsole";
            this.tableLayoutPanel1.SetRowSpan(this.TbxOutpoutConsole, 4);
            this.TbxOutpoutConsole.Size = new System.Drawing.Size(280, 444);
            this.TbxOutpoutConsole.TabIndex = 8;
            this.TbxOutpoutConsole.Text = "---------------------------------------------------------------------------------" +
    "--------";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.BtnCreateObject);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 111);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(75, 180);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // BtnCreateObject
            // 
            this.BtnCreateObject.Enabled = false;
            this.BtnCreateObject.Location = new System.Drawing.Point(3, 39);
            this.BtnCreateObject.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.BtnCreateObject.Name = "BtnCreateObject";
            this.BtnCreateObject.Size = new System.Drawing.Size(69, 42);
            this.BtnCreateObject.TabIndex = 5;
            this.BtnCreateObject.Text = "Create Object";
            this.BtnCreateObject.UseVisualStyleBackColor = true;
            this.BtnCreateObject.Click += new System.EventHandler(this.BtnCreateObject_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.BtnCallMethod);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 297);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(75, 181);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // BtnCallMethod
            // 
            this.BtnCallMethod.Enabled = false;
            this.BtnCallMethod.Location = new System.Drawing.Point(3, 39);
            this.BtnCallMethod.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.BtnCallMethod.Name = "BtnCallMethod";
            this.BtnCallMethod.Size = new System.Drawing.Size(69, 42);
            this.BtnCallMethod.TabIndex = 6;
            this.BtnCallMethod.Text = "Call Method";
            this.BtnCallMethod.UseVisualStyleBackColor = true;
            this.BtnCallMethod.Click += new System.EventHandler(this.BtnCallMethod_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 544);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(538, 307);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Explorer";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.TsMain.ResumeLayout(false);
            this.TsMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMethods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConstructors)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TsMain;
        private System.Windows.Forms.ToolStripButton TsMainBtnOpenFile;
        private System.Windows.Forms.ToolStripButton TsMainBtnCloseFile;
        private System.Windows.Forms.OpenFileDialog OfdMain;
        private System.Windows.Forms.Label LblSelectedFile;
        private System.Windows.Forms.TextBox TbxSelectedFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblClassName;
        private System.Windows.Forms.Label TbxClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvMethods;
        private System.Windows.Forms.DataGridView DgvConstructors;
        private System.Windows.Forms.TextBox TbxOutpoutConsole;
        private System.Windows.Forms.Label LblOutpout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnCreateObject;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button BtnCallMethod;
    }
}