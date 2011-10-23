namespace Host
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaseLocation = new System.Windows.Forms.TextBox();
            this.ckbShowMES = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CB1 = new System.Windows.Forms.ComboBox();
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_mess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Show MES:";
            // 
            // txtBaseLocation
            // 
            this.txtBaseLocation.Location = new System.Drawing.Point(100, 38);
            this.txtBaseLocation.Name = "txtBaseLocation";
            this.txtBaseLocation.Size = new System.Drawing.Size(122, 22);
            this.txtBaseLocation.TabIndex = 1;
            // 
            // ckbShowMES
            // 
            this.ckbShowMES.AutoSize = true;
            this.ckbShowMES.Location = new System.Drawing.Point(100, 71);
            this.ckbShowMES.Name = "ckbShowMES";
            this.ckbShowMES.Size = new System.Drawing.Size(15, 14);
            this.ckbShowMES.TabIndex = 2;
            this.ckbShowMES.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(121, 66);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 22);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(231, 66);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(104, 22);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "End Point:";
            // 
            // CB1
            // 
            this.CB1.FormattingEnabled = true;
            this.CB1.Items.AddRange(new object[] {
            "BasicHttpBinding",
            "NetTCPBinding",
            "WsHttpBinding"});
            this.CB1.Location = new System.Drawing.Point(100, 98);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(125, 21);
            this.CB1.TabIndex = 4;
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(231, 97);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(104, 22);
            this.btnLocation.TabIndex = 3;
            this.btnLocation.Text = "Location";
            this.btnLocation.UseVisualStyleBackColor = true;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(233, 191);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(104, 22);
            this.btnSaveConfig.TabIndex = 3;
            this.btnSaveConfig.Text = "Save Config";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "State";
            // 
            // lbl_mess
            // 
            this.lbl_mess.AutoSize = true;
            this.lbl_mess.Location = new System.Drawing.Point(236, 42);
            this.lbl_mess.Name = "lbl_mess";
            this.lbl_mess.Size = new System.Drawing.Size(0, 13);
            this.lbl_mess.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 262);
            this.Controls.Add(this.lbl_mess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB1);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.ckbShowMES);
            this.Controls.Add(this.txtBaseLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "Service Main Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBaseLocation;
        private System.Windows.Forms.CheckBox ckbShowMES;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB1;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_mess;
    }
}

