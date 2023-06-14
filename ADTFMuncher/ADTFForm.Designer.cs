namespace ADTFMuncher
{
    partial class ADTFForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoadADTF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPostgresConn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtOuputDir = new System.Windows.Forms.TextBox();
            this.btnStartCapture = new System.Windows.Forms.Button();
            this.txtSerialPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRunID = new System.Windows.Forms.TextBox();
            this.btnIncrementRunID = new System.Windows.Forms.Button();
            this.btnStopCapture = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.meta_id_39 = new System.Windows.Forms.TextBox();
            this.meta_id_40 = new System.Windows.Forms.TextBox();
            this.meta_id_41 = new System.Windows.Forms.TextBox();
            this.meta_id_42 = new System.Windows.Forms.TextBox();
            this.meta_id_43 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbMetaControls = new System.Windows.Forms.GroupBox();
            this.btnSync = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.meta_id_13 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbMetaControls.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnLoadADTF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPostgresConn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtOuputDir);
            this.groupBox1.Location = new System.Drawing.Point(20, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Convert Subsecond";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoadADTF
            // 
            this.btnLoadADTF.Location = new System.Drawing.Point(27, 223);
            this.btnLoadADTF.Name = "btnLoadADTF";
            this.btnLoadADTF.Size = new System.Drawing.Size(165, 35);
            this.btnLoadADTF.TabIndex = 5;
            this.btnLoadADTF.Text = "Load ADTF";
            this.btnLoadADTF.UseVisualStyleBackColor = true;
            this.btnLoadADTF.Click += new System.EventHandler(this.btnLoadADTF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Postgres connection";
            // 
            // txtPostgresConn
            // 
            this.txtPostgresConn.Location = new System.Drawing.Point(27, 191);
            this.txtPostgresConn.Name = "txtPostgresConn";
            this.txtPostgresConn.Size = new System.Drawing.Size(761, 26);
            this.txtPostgresConn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output directory";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(699, 31);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(86, 31);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtOuputDir
            // 
            this.txtOuputDir.Location = new System.Drawing.Point(27, 68);
            this.txtOuputDir.Name = "txtOuputDir";
            this.txtOuputDir.Size = new System.Drawing.Size(758, 26);
            this.txtOuputDir.TabIndex = 0;
            // 
            // btnStartCapture
            // 
            this.btnStartCapture.Location = new System.Drawing.Point(73, 97);
            this.btnStartCapture.Name = "btnStartCapture";
            this.btnStartCapture.Size = new System.Drawing.Size(73, 47);
            this.btnStartCapture.TabIndex = 2;
            this.btnStartCapture.Text = "Start";
            this.btnStartCapture.UseVisualStyleBackColor = true;
            this.btnStartCapture.Click += new System.EventHandler(this.btnStartCapture_Click);
            // 
            // txtSerialPort
            // 
            this.txtSerialPort.Location = new System.Drawing.Point(119, 42);
            this.txtSerialPort.Name = "txtSerialPort";
            this.txtSerialPort.Size = new System.Drawing.Size(76, 26);
            this.txtSerialPort.TabIndex = 4;
            this.txtSerialPort.Text = "COM9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Serial port";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(59, 92);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(90, 35);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(742, 513);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Run ID";
            // 
            // txtRunID
            // 
            this.txtRunID.Location = new System.Drawing.Point(121, 56);
            this.txtRunID.Name = "txtRunID";
            this.txtRunID.Size = new System.Drawing.Size(60, 26);
            this.txtRunID.TabIndex = 8;
            this.txtRunID.Text = "1";
            this.txtRunID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIncrementRunID
            // 
            this.btnIncrementRunID.Location = new System.Drawing.Point(187, 54);
            this.btnIncrementRunID.Name = "btnIncrementRunID";
            this.btnIncrementRunID.Size = new System.Drawing.Size(38, 31);
            this.btnIncrementRunID.TabIndex = 10;
            this.btnIncrementRunID.Text = "+";
            this.btnIncrementRunID.UseVisualStyleBackColor = true;
            this.btnIncrementRunID.Click += new System.EventHandler(this.btnIncrementRunID_Click);
            // 
            // btnStopCapture
            // 
            this.btnStopCapture.Location = new System.Drawing.Point(152, 97);
            this.btnStopCapture.Name = "btnStopCapture";
            this.btnStopCapture.Size = new System.Drawing.Size(73, 47);
            this.btnStopCapture.TabIndex = 11;
            this.btnStopCapture.Text = "Stop";
            this.btnStopCapture.UseVisualStyleBackColor = true;
            this.btnStopCapture.Click += new System.EventHandler(this.btnStopCapture_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Range";
            // 
            // meta_id_39
            // 
            this.meta_id_39.BackColor = System.Drawing.Color.GreenYellow;
            this.meta_id_39.Location = new System.Drawing.Point(116, 73);
            this.meta_id_39.Name = "meta_id_39";
            this.meta_id_39.ReadOnly = true;
            this.meta_id_39.Size = new System.Drawing.Size(102, 26);
            this.meta_id_39.TabIndex = 12;
            this.meta_id_39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // meta_id_40
            // 
            this.meta_id_40.BackColor = System.Drawing.Color.Aquamarine;
            this.meta_id_40.Location = new System.Drawing.Point(116, 104);
            this.meta_id_40.Name = "meta_id_40";
            this.meta_id_40.ReadOnly = true;
            this.meta_id_40.Size = new System.Drawing.Size(102, 26);
            this.meta_id_40.TabIndex = 14;
            this.meta_id_40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // meta_id_41
            // 
            this.meta_id_41.BackColor = System.Drawing.Color.Violet;
            this.meta_id_41.Location = new System.Drawing.Point(116, 135);
            this.meta_id_41.Name = "meta_id_41";
            this.meta_id_41.ReadOnly = true;
            this.meta_id_41.Size = new System.Drawing.Size(102, 26);
            this.meta_id_41.TabIndex = 15;
            this.meta_id_41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // meta_id_42
            // 
            this.meta_id_42.BackColor = System.Drawing.Color.Khaki;
            this.meta_id_42.Location = new System.Drawing.Point(116, 166);
            this.meta_id_42.Name = "meta_id_42";
            this.meta_id_42.ReadOnly = true;
            this.meta_id_42.Size = new System.Drawing.Size(102, 26);
            this.meta_id_42.TabIndex = 16;
            this.meta_id_42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // meta_id_43
            // 
            this.meta_id_43.BackColor = System.Drawing.Color.MistyRose;
            this.meta_id_43.Location = new System.Drawing.Point(116, 197);
            this.meta_id_43.Name = "meta_id_43";
            this.meta_id_43.ReadOnly = true;
            this.meta_id_43.Size = new System.Drawing.Size(102, 26);
            this.meta_id_43.TabIndex = 17;
            this.meta_id_43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Pot value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Angle";
            // 
            // gbMetaControls
            // 
            this.gbMetaControls.Controls.Add(this.meta_id_13);
            this.gbMetaControls.Controls.Add(this.label10);
            this.gbMetaControls.Controls.Add(this.meta_id_43);
            this.gbMetaControls.Controls.Add(this.label9);
            this.gbMetaControls.Controls.Add(this.meta_id_39);
            this.gbMetaControls.Controls.Add(this.label8);
            this.gbMetaControls.Controls.Add(this.label5);
            this.gbMetaControls.Controls.Add(this.label7);
            this.gbMetaControls.Controls.Add(this.meta_id_40);
            this.gbMetaControls.Controls.Add(this.label6);
            this.gbMetaControls.Controls.Add(this.meta_id_41);
            this.gbMetaControls.Controls.Add(this.meta_id_42);
            this.gbMetaControls.Location = new System.Drawing.Point(266, 305);
            this.gbMetaControls.Name = "gbMetaControls";
            this.gbMetaControls.Size = new System.Drawing.Size(263, 243);
            this.gbMetaControls.TabIndex = 22;
            this.gbMetaControls.TabStop = false;
            this.gbMetaControls.Text = "ADTF Data";
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(59, 136);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(90, 35);
            this.btnSync.TabIndex = 23;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSync);
            this.groupBox2.Controls.Add(this.txtSerialPort);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Location = new System.Drawing.Point(20, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 243);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Port";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.btnStopCapture);
            this.groupBox3.Controls.Add(this.btnStartCapture);
            this.groupBox3.Controls.Add(this.txtRunID);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnIncrementRunID);
            this.groupBox3.Location = new System.Drawing.Point(547, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 202);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Run Info";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 165);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(237, 13);
            this.progressBar1.TabIndex = 12;
            // 
            // meta_id_13
            // 
            this.meta_id_13.BackColor = System.Drawing.Color.LemonChiffon;
            this.meta_id_13.Location = new System.Drawing.Point(67, 38);
            this.meta_id_13.Name = "meta_id_13";
            this.meta_id_13.ReadOnly = true;
            this.meta_id_13.Size = new System.Drawing.Size(171, 26);
            this.meta_id_13.TabIndex = 22;
            this.meta_id_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Time";
            // 
            // ADTFForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 563);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbMetaControls);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ADTFForm";
            this.Text = "ADTF Muncher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ADTFForm_FormClosing);
            this.Load += new System.EventHandler(this.ADTFForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMetaControls.ResumeLayout(false);
            this.gbMetaControls.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtOuputDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPostgresConn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLoadADTF;
        private System.Windows.Forms.Button btnStartCapture;
        private System.Windows.Forms.TextBox txtSerialPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRunID;
        private System.Windows.Forms.Button btnIncrementRunID;
        private System.Windows.Forms.Button btnStopCapture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox meta_id_39;
        private System.Windows.Forms.TextBox meta_id_40;
        private System.Windows.Forms.TextBox meta_id_41;
        private System.Windows.Forms.TextBox meta_id_42;
        private System.Windows.Forms.TextBox meta_id_43;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbMetaControls;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox meta_id_13;
        private System.Windows.Forms.Label label10;
    }
}

