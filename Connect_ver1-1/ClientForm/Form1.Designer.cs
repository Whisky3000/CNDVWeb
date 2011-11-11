namespace ClientForm
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAsyn = new System.Windows.Forms.Button();
            this.txbAll = new System.Windows.Forms.TextBox();
            this.txbAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbWsHttp = new System.Windows.Forms.TextBox();
            this.btnWsHttp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNetTcp = new System.Windows.Forms.TextBox();
            this.btnNetTcp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbBasicHttp = new System.Windows.Forms.TextBox();
            this.btnBasicHttp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btSyn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSyn);
            this.groupBox1.Controls.Add(this.btnAsyn);
            this.groupBox1.Controls.Add(this.txbAll);
            this.groupBox1.Controls.Add(this.txbAdd);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txbWsHttp);
            this.groupBox1.Controls.Add(this.btnWsHttp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbNetTcp);
            this.groupBox1.Controls.Add(this.btnNetTcp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbBasicHttp);
            this.groupBox1.Controls.Add(this.btnBasicHttp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // btnAsyn
            // 
            this.btnAsyn.Location = new System.Drawing.Point(269, 307);
            this.btnAsyn.Name = "btnAsyn";
            this.btnAsyn.Size = new System.Drawing.Size(75, 23);
            this.btnAsyn.TabIndex = 13;
            this.btnAsyn.Text = "Asyn";
            this.btnAsyn.UseVisualStyleBackColor = true;
            this.btnAsyn.Click += new System.EventHandler(this.btnAsyn_Click);
            // 
            // txbAll
            // 
            this.txbAll.Location = new System.Drawing.Point(107, 266);
            this.txbAll.Name = "txbAll";
            this.txbAll.Size = new System.Drawing.Size(283, 20);
            this.txbAll.TabIndex = 11;
            // 
            // txbAdd
            // 
            this.txbAdd.Location = new System.Drawing.Point(107, 211);
            this.txbAdd.Name = "txbAdd";
            this.txbAdd.Size = new System.Drawing.Size(283, 20);
            this.txbAdd.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(204, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbWsHttp
            // 
            this.txbWsHttp.Location = new System.Drawing.Point(107, 168);
            this.txbWsHttp.Name = "txbWsHttp";
            this.txbWsHttp.Size = new System.Drawing.Size(283, 20);
            this.txbWsHttp.TabIndex = 8;
            // 
            // btnWsHttp
            // 
            this.btnWsHttp.Location = new System.Drawing.Point(6, 168);
            this.btnWsHttp.Name = "btnWsHttp";
            this.btnWsHttp.Size = new System.Drawing.Size(75, 23);
            this.btnWsHttp.TabIndex = 7;
            this.btnWsHttp.Text = "Get Author";
            this.btnWsHttp.UseVisualStyleBackColor = true;
            this.btnWsHttp.Click += new System.EventHandler(this.btnWsHttp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "WsHttpBinding";
            // 
            // txbNetTcp
            // 
            this.txbNetTcp.Location = new System.Drawing.Point(107, 112);
            this.txbNetTcp.Name = "txbNetTcp";
            this.txbNetTcp.Size = new System.Drawing.Size(283, 20);
            this.txbNetTcp.TabIndex = 5;
            // 
            // btnNetTcp
            // 
            this.btnNetTcp.Location = new System.Drawing.Point(6, 112);
            this.btnNetTcp.Name = "btnNetTcp";
            this.btnNetTcp.Size = new System.Drawing.Size(75, 23);
            this.btnNetTcp.TabIndex = 4;
            this.btnNetTcp.Text = "Get Author";
            this.btnNetTcp.UseVisualStyleBackColor = true;
            this.btnNetTcp.Click += new System.EventHandler(this.btnNetTcp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NetTcpBinding";
            // 
            // txbBasicHttp
            // 
            this.txbBasicHttp.Location = new System.Drawing.Point(107, 55);
            this.txbBasicHttp.Name = "txbBasicHttp";
            this.txbBasicHttp.Size = new System.Drawing.Size(283, 20);
            this.txbBasicHttp.TabIndex = 2;
            // 
            // btnBasicHttp
            // 
            this.btnBasicHttp.Location = new System.Drawing.Point(6, 55);
            this.btnBasicHttp.Name = "btnBasicHttp";
            this.btnBasicHttp.Size = new System.Drawing.Size(75, 23);
            this.btnBasicHttp.TabIndex = 1;
            this.btnBasicHttp.Text = "Get Author";
            this.btnBasicHttp.UseVisualStyleBackColor = true;
            this.btnBasicHttp.Click += new System.EventHandler(this.btnBasicHttp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BasicHttpBinding";
            // 
            // btSyn
            // 
            this.btSyn.Location = new System.Drawing.Point(146, 307);
            this.btSyn.Name = "btSyn";
            this.btSyn.Size = new System.Drawing.Size(75, 23);
            this.btSyn.TabIndex = 14;
            this.btSyn.Text = "Syn";
            this.btSyn.UseVisualStyleBackColor = true;
            this.btSyn.Click += new System.EventHandler(this.btSyn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 378);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbWsHttp;
        private System.Windows.Forms.Button btnWsHttp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNetTcp;
        private System.Windows.Forms.Button btnNetTcp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbBasicHttp;
        private System.Windows.Forms.Button btnBasicHttp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAsyn;
        private System.Windows.Forms.TextBox txbAll;
        private System.Windows.Forms.TextBox txbAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btSyn;

        public System.EventHandler btnSyn_Click { get; set; }
    }
}

