namespace Client
{
    partial class frmMain
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
            this.btn_Author = new System.Windows.Forms.Button();
            this.lbl_showauthor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbTcp = new System.Windows.Forms.TextBox();
            this.txbHttp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_getListNetTcp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Author
            // 
            this.btn_Author.Location = new System.Drawing.Point(3, 36);
            this.btn_Author.Name = "btn_Author";
            this.btn_Author.Size = new System.Drawing.Size(75, 23);
            this.btn_Author.TabIndex = 0;
            this.btn_Author.Text = "GetAuthors";
            this.btn_Author.UseVisualStyleBackColor = true;
            this.btn_Author.Click += new System.EventHandler(this.btn_Author_Click);
            // 
            // lbl_showauthor
            // 
            this.lbl_showauthor.AutoSize = true;
            this.lbl_showauthor.Location = new System.Drawing.Point(12, 98);
            this.lbl_showauthor.Name = "lbl_showauthor";
            this.lbl_showauthor.Size = new System.Drawing.Size(0, 13);
            this.lbl_showauthor.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbTcp);
            this.groupBox1.Controls.Add(this.txbHttp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_getListNetTcp);
            this.groupBox1.Controls.Add(this.btn_Author);
            this.groupBox1.Location = new System.Drawing.Point(15, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 200);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Http";
            // 
            // txbTcp
            // 
            this.txbTcp.Location = new System.Drawing.Point(94, 102);
            this.txbTcp.Name = "txbTcp";
            this.txbTcp.Size = new System.Drawing.Size(320, 20);
            this.txbTcp.TabIndex = 7;
            this.txbTcp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txbHttp
            // 
            this.txbHttp.Location = new System.Drawing.Point(94, 38);
            this.txbHttp.Name = "txbHttp";
            this.txbHttp.Size = new System.Drawing.Size(320, 20);
            this.txbHttp.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "NetTCP binding";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Http binding";
            // 
            // btn_getListNetTcp
            // 
            this.btn_getListNetTcp.Location = new System.Drawing.Point(0, 100);
            this.btn_getListNetTcp.Name = "btn_getListNetTcp";
            this.btn_getListNetTcp.Size = new System.Drawing.Size(75, 23);
            this.btn_getListNetTcp.TabIndex = 3;
            this.btn_getListNetTcp.Text = "GetAuthors";
            this.btn_getListNetTcp.UseVisualStyleBackColor = true;
            this.btn_getListNetTcp.Click += new System.EventHandler(this.btn_getListNetTcp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 436);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_showauthor);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Author;
        private System.Windows.Forms.Label lbl_showauthor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_getListNetTcp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTcp;
        private System.Windows.Forms.TextBox txbHttp;
        private System.Windows.Forms.Label label2;
    }
}