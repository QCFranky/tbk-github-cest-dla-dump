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
            this.OfdMain = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblOutpout = new System.Windows.Forms.Label();
            this.LblClassName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblConstructors = new System.Windows.Forms.Label();
            this.BtnCreateObject = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblMethods = new System.Windows.Forms.Label();
            this.BtnCallMethod = new System.Windows.Forms.Button();
            this.TbxOutpoutConsole = new System.Windows.Forms.TextBox();
            this.TbxClassName = new System.Windows.Forms.Label();
            this.CbxClass = new System.Windows.Forms.ComboBox();
            this.LbxConstructors = new System.Windows.Forms.ListBox();
            this.LbxMethods = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OfdMain
            // 
            this.OfdMain.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.LblOutpout, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblClassName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TbxOutpoutConsole, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TbxClassName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CbxClass, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LbxConstructors, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LbxMethods, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(908, 546);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LblOutpout
            // 
            this.LblOutpout.AutoSize = true;
            this.LblOutpout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblOutpout.Location = new System.Drawing.Point(618, 6);
            this.LblOutpout.Margin = new System.Windows.Forms.Padding(10, 6, 3, 0);
            this.LblOutpout.Name = "LblOutpout";
            this.LblOutpout.Size = new System.Drawing.Size(287, 18);
            this.LblOutpout.TabIndex = 9;
            this.LblOutpout.Text = "Outpout:";
            // 
            // LblClassName
            // 
            this.LblClassName.AutoSize = true;
            this.LblClassName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblClassName.Location = new System.Drawing.Point(3, 30);
            this.LblClassName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.LblClassName.Name = "LblClassName";
            this.LblClassName.Size = new System.Drawing.Size(75, 18);
            this.LblClassName.TabIndex = 0;
            this.LblClassName.Text = "Class Name:";
            this.LblClassName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.LblConstructors);
            this.flowLayoutPanel1.Controls.Add(this.BtnCreateObject);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(75, 233);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // LblConstructors
            // 
            this.LblConstructors.AutoSize = true;
            this.LblConstructors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblConstructors.Location = new System.Drawing.Point(3, 6);
            this.LblConstructors.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.LblConstructors.Name = "LblConstructors";
            this.LblConstructors.Size = new System.Drawing.Size(69, 13);
            this.LblConstructors.TabIndex = 4;
            this.LblConstructors.Text = "Constructors:";
            this.LblConstructors.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnCreateObject
            // 
            this.BtnCreateObject.Enabled = false;
            this.BtnCreateObject.Location = new System.Drawing.Point(3, 39);
            this.BtnCreateObject.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.BtnCreateObject.Name = "BtnCreateObject";
            this.BtnCreateObject.Size = new System.Drawing.Size(69, 42);
            this.BtnCreateObject.TabIndex = 0;
            this.BtnCreateObject.Text = "Create Object";
            this.BtnCreateObject.UseVisualStyleBackColor = true;
            this.BtnCreateObject.Click += new System.EventHandler(this.BtnCreateObject_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.LblMethods);
            this.flowLayoutPanel2.Controls.Add(this.BtnCallMethod);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 290);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(75, 233);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // LblMethods
            // 
            this.LblMethods.AutoSize = true;
            this.LblMethods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMethods.Location = new System.Drawing.Point(21, 6);
            this.LblMethods.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.LblMethods.Name = "LblMethods";
            this.LblMethods.Size = new System.Drawing.Size(51, 13);
            this.LblMethods.TabIndex = 5;
            this.LblMethods.Text = "Methods:";
            this.LblMethods.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnCallMethod
            // 
            this.BtnCallMethod.Enabled = false;
            this.BtnCallMethod.Location = new System.Drawing.Point(3, 39);
            this.BtnCallMethod.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.BtnCallMethod.Name = "BtnCallMethod";
            this.BtnCallMethod.Size = new System.Drawing.Size(69, 42);
            this.BtnCallMethod.TabIndex = 0;
            this.BtnCallMethod.Text = "Call Method";
            this.BtnCallMethod.UseVisualStyleBackColor = true;
            this.BtnCallMethod.Click += new System.EventHandler(this.BtnCallMethod_Click);
            // 
            // TbxOutpoutConsole
            // 
            this.TbxOutpoutConsole.BackColor = System.Drawing.Color.White;
            this.TbxOutpoutConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbxOutpoutConsole.Enabled = false;
            this.TbxOutpoutConsole.Location = new System.Drawing.Point(618, 27);
            this.TbxOutpoutConsole.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.TbxOutpoutConsole.Multiline = true;
            this.TbxOutpoutConsole.Name = "TbxOutpoutConsole";
            this.tableLayoutPanel1.SetRowSpan(this.TbxOutpoutConsole, 4);
            this.TbxOutpoutConsole.Size = new System.Drawing.Size(280, 509);
            this.TbxOutpoutConsole.TabIndex = 8;
            this.TbxOutpoutConsole.Text = "---------------------------------------------------------------------------------" +
    "--------";
            // 
            // TbxClassName
            // 
            this.TbxClassName.AutoSize = true;
            this.TbxClassName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbxClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxClassName.Location = new System.Drawing.Point(3, 6);
            this.TbxClassName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.TbxClassName.Name = "TbxClassName";
            this.TbxClassName.Size = new System.Drawing.Size(75, 18);
            this.TbxClassName.TabIndex = 3;
            this.TbxClassName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbxClass
            // 
            this.CbxClass.FormattingEnabled = true;
            this.CbxClass.Location = new System.Drawing.Point(84, 27);
            this.CbxClass.Name = "CbxClass";
            this.CbxClass.Size = new System.Drawing.Size(251, 21);
            this.CbxClass.TabIndex = 1;
            this.CbxClass.SelectedIndexChanged += new System.EventHandler(this.CbxClass_SelectedIndexChanged);
            // 
            // LbxConstructors
            // 
            this.LbxConstructors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbxConstructors.FormattingEnabled = true;
            this.LbxConstructors.Location = new System.Drawing.Point(84, 51);
            this.LbxConstructors.Name = "LbxConstructors";
            this.LbxConstructors.Size = new System.Drawing.Size(521, 233);
            this.LbxConstructors.TabIndex = 3;
            // 
            // LbxMethods
            // 
            this.LbxMethods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbxMethods.FormattingEnabled = true;
            this.LbxMethods.Location = new System.Drawing.Point(84, 290);
            this.LbxMethods.Name = "LbxMethods";
            this.LbxMethods.Size = new System.Drawing.Size(521, 233);
            this.LbxMethods.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 546);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(538, 307);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Explorer";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OfdMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblClassName;
        private System.Windows.Forms.Label TbxClassName;
        private System.Windows.Forms.Label LblMethods;
        private System.Windows.Forms.Label LblConstructors;
        private System.Windows.Forms.Label LblOutpout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnCreateObject;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button BtnCallMethod;
        private System.Windows.Forms.TextBox TbxOutpoutConsole;
        private System.Windows.Forms.ComboBox CbxClass;
        private System.Windows.Forms.ListBox LbxConstructors;
        private System.Windows.Forms.ListBox LbxMethods;
    }
}