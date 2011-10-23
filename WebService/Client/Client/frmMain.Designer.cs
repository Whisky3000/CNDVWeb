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
            this.btn_BasicHttp = new System.Windows.Forms.Button();
            this.lbl_showauthor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbWsHttp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_WsHttp = new System.Windows.Forms.Button();
            this.txb_Tcp = new System.Windows.Forms.TextBox();
            this.txbBasicHttp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NetTcp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_BasicHttp
            // 
            this.btn_BasicHttp.Location = new System.Drawing.Point(3, 36);
            this.btn_BasicHttp.Name = "btn_BasicHttp";
            this.btn_BasicHttp.Size = new System.Drawing.Size(75, 23);
            this.btn_BasicHttp.TabIndex = 0;
            this.btn_BasicHttp.Text = "GetAuthors";
            this.btn_BasicHttp.UseVisualStyleBackColor = true;
            this.btn_BasicHttp.Click += new System.EventHandler(this.btn_BasicHttp_Click);
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
            this.groupBox1.Controls.Add(this.txbWsHttp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_WsHttp);
            this.groupBox1.Controls.Add(this.txb_Tcp);
            this.groupBox1.Controls.Add(this.txbBasicHttp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_NetTcp);
            this.groupBox1.Controls.Add(this.btn_BasicHttp);
            this.groupBox1.Location = new System.Drawing.Point(15, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 200);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Http";
            // 
            // txbWsHttp
            // 
            this.txbWsHttp.Location = new System.Drawing.Point(94, 156);
            this.txbWsHttp.Name = "txbWsHttp";
            this.txbWsHttp.Size = new System.Drawing.Size(320, 20);
            this.txbWsHttp.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "WsHttpBinding";
            // 
            // btn_WsHttp
            // 
            this.btn_WsHttp.Location = new System.Drawing.Point(0, 154);
            this.btn_WsHttp.Name = "btn_WsHttp";
            this.btn_WsHttp.Size = new System.Drawing.Size(75, 23);
            this.btn_WsHttp.TabIndex = 8;
            this.btn_WsHttp.Text = "GetAuthors";
            this.btn_WsHttp.UseVisualStyleBackColor = true;
            this.btn_WsHttp.Click += new System.EventHandler(this.btn_WsHttp_Click);
            // 
            // txb_Tcp
            // 
            this.txb_Tcp.Location = new System.Drawing.Point(94, 102);
            this.txb_Tcp.Name = "txb_Tcp";
            this.txb_Tcp.Size = new System.Drawing.Size(320, 20);
            this.txb_Tcp.TabIndex = 7;
            // 
            // txbBasicHttp
            // 
            this.txbBasicHttp.Location = new System.Drawing.Point(94, 38);
            this.txbBasicHttp.Name = "txbBasicHttp";
            this.txbBasicHttp.Size = new System.Drawing.Size(320, 20);
            this.txbBasicHttp.TabIndex = 6;
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
            // btn_NetTcp
            // 
            this.btn_NetTcp.Location = new System.Drawing.Point(0, 100);
            this.btn_NetTcp.Name = "btn_NetTcp";
            this.btn_NetTcp.Size = new System.Drawing.Size(75, 23);
            this.btn_NetTcp.TabIndex = 3;
            this.btn_NetTcp.Text = "GetAuthors";
            this.btn_NetTcp.UseVisualStyleBackColor = true;
            this.btn_NetTcp.Click += new System.EventHandler(this.btn_NetTcp_Click);
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

        private System.Windows.Forms.Button btn_BasicHttp;
        private System.Windows.Forms.Label lbl_showauthor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_NetTcp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Tcp;
        private System.Windows.Forms.TextBox txbBasicHttp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbWsHttp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_WsHttp;
    }
}