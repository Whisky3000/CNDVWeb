namespace HostForm
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
            this.button4 = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEndPoint = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txbBaseAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(197, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Save Config";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(215, 48);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(37, 13);
            this.lbl.TabIndex = 22;
            this.lbl.Text = "Status";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(74, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Location";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(152, 43);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(41, 23);
            this.btnStop.TabIndex = 19;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(195, 71);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(0, 13);
            this.lbl_Status.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "EndPoint";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Show Mex";
            // 
            // cbEndPoint
            // 
            this.cbEndPoint.AllowDrop = true;
            this.cbEndPoint.FormattingEnabled = true;
            this.cbEndPoint.Items.AddRange(new object[] {
            "BasicHttpBinding",
            "NetTcpBinding",
            "WsHttpBinding"});
            this.cbEndPoint.Location = new System.Drawing.Point(74, 92);
            this.cbEndPoint.Name = "cbEndPoint";
            this.cbEndPoint.Size = new System.Drawing.Size(121, 21);
            this.cbEndPoint.TabIndex = 15;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(105, 43);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(41, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txbBaseAddress
            // 
            this.txbBaseAddress.Location = new System.Drawing.Point(87, 15);
            this.txbBaseAddress.Name = "txbBaseAddress";
            this.txbBaseAddress.Size = new System.Drawing.Size(139, 20);
            this.txbBaseAddress.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "BaseAddress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEndPoint);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txbBaseAddress);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEndPoint;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txbBaseAddress;
        private System.Windows.Forms.Label label1;
    }
}

