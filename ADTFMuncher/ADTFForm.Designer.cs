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
            this.txtOuputDir = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPostgresConn = new System.Windows.Forms.TextBox();
            this.btnLoadADTF = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStartCapture = new System.Windows.Forms.Button();
            this.txtSerialPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTestCommPort = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRunID = new System.Windows.Forms.TextBox();
            this.btnIncrementRunID = new System.Windows.Forms.Button();
            this.btnStopCapture = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            // txtOuputDir
            // 
            this.txtOuputDir.Location = new System.Drawing.Point(27, 68);
            this.txtOuputDir.Name = "txtOuputDir";
            this.txtOuputDir.Size = new System.Drawing.Size(758, 26);
            this.txtOuputDir.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(699, 31);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(86, 31);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Postgres connection";
            // 
            // txtPostgresConn
            // 
            this.txtPostgresConn.Location = new System.Drawing.Point(30, 191);
            this.txtPostgresConn.Name = "txtPostgresConn";
            this.txtPostgresConn.Size = new System.Drawing.Size(758, 26);
            this.txtPostgresConn.TabIndex = 3;
            // 
            // btnLoadADTF
            // 
            this.btnLoadADTF.Location = new System.Drawing.Point(30, 223);
            this.btnLoadADTF.Name = "btnLoadADTF";
            this.btnLoadADTF.Size = new System.Drawing.Size(183, 37);
            this.btnLoadADTF.TabIndex = 5;
            this.btnLoadADTF.Text = "Load ADTF";
            this.btnLoadADTF.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Convert Subsecond";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnStartCapture
            // 
            this.btnStartCapture.Location = new System.Drawing.Point(475, 304);
            this.btnStartCapture.Name = "btnStartCapture";
            this.btnStartCapture.Size = new System.Drawing.Size(73, 31);
            this.btnStartCapture.TabIndex = 2;
            this.btnStartCapture.Text = "Start";
            this.btnStartCapture.UseVisualStyleBackColor = true;
            // 
            // txtSerialPort
            // 
            this.txtSerialPort.Location = new System.Drawing.Point(122, 304);
            this.txtSerialPort.Name = "txtSerialPort";
            this.txtSerialPort.Size = new System.Drawing.Size(82, 26);
            this.txtSerialPort.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Serial port";
            // 
            // btnTestCommPort
            // 
            this.btnTestCommPort.Location = new System.Drawing.Point(210, 303);
            this.btnTestCommPort.Name = "btnTestCommPort";
            this.btnTestCommPort.Size = new System.Drawing.Size(59, 31);
            this.btnTestCommPort.TabIndex = 6;
            this.btnTestCommPort.Text = "Test";
            this.btnTestCommPort.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(719, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 31);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Run ID";
            // 
            // txtRunID
            // 
            this.txtRunID.Location = new System.Drawing.Point(356, 306);
            this.txtRunID.Name = "txtRunID";
            this.txtRunID.Size = new System.Drawing.Size(60, 26);
            this.txtRunID.TabIndex = 8;
            // 
            // btnIncrementRunID
            // 
            this.btnIncrementRunID.Location = new System.Drawing.Point(422, 304);
            this.btnIncrementRunID.Name = "btnIncrementRunID";
            this.btnIncrementRunID.Size = new System.Drawing.Size(38, 31);
            this.btnIncrementRunID.TabIndex = 10;
            this.btnIncrementRunID.Text = "+";
            this.btnIncrementRunID.UseVisualStyleBackColor = true;
            // 
            // btnStopCapture
            // 
            this.btnStopCapture.Location = new System.Drawing.Point(554, 304);
            this.btnStopCapture.Name = "btnStopCapture";
            this.btnStopCapture.Size = new System.Drawing.Size(73, 31);
            this.btnStopCapture.TabIndex = 11;
            this.btnStopCapture.Text = "Stop";
            this.btnStopCapture.UseVisualStyleBackColor = true;
            // 
            // ADTFForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 354);
            this.Controls.Add(this.btnStopCapture);
            this.Controls.Add(this.btnIncrementRunID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRunID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTestCommPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSerialPort);
            this.Controls.Add(this.btnStartCapture);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ADTFForm";
            this.Text = "ADTF Muncher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnTestCommPort;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRunID;
        private System.Windows.Forms.Button btnIncrementRunID;
        private System.Windows.Forms.Button btnStopCapture;
    }
}

