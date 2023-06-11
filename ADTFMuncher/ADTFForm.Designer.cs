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
            this.txtOuputPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPostgresConn = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStartCapture = new System.Windows.Forms.Button();
            this.txtComPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTestCommPort = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPostgresConn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtOuputPath);
            this.groupBox1.Location = new System.Drawing.Point(20, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtOuputPath
            // 
            this.txtOuputPath.Location = new System.Drawing.Point(27, 68);
            this.txtOuputPath.Name = "txtOuputPath";
            this.txtOuputPath.Size = new System.Drawing.Size(758, 26);
            this.txtOuputPath.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output file path";
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
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(30, 223);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(86, 31);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Convert Subsecond";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnStartCapture
            // 
            this.btnStartCapture.Location = new System.Drawing.Point(383, 304);
            this.btnStartCapture.Name = "btnStartCapture";
            this.btnStartCapture.Size = new System.Drawing.Size(128, 31);
            this.btnStartCapture.TabIndex = 2;
            this.btnStartCapture.Text = "Start Capture";
            this.btnStartCapture.UseVisualStyleBackColor = true;
            // 
            // txtComPort
            // 
            this.txtComPort.Location = new System.Drawing.Point(115, 306);
            this.txtComPort.Name = "txtComPort";
            this.txtComPort.Size = new System.Drawing.Size(82, 26);
            this.txtComPort.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Comm port";
            // 
            // btnTestCommPort
            // 
            this.btnTestCommPort.Location = new System.Drawing.Point(203, 304);
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
            // ADTFForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 354);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTestCommPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtComPort);
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
        private System.Windows.Forms.TextBox txtOuputPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPostgresConn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnStartCapture;
        private System.Windows.Forms.TextBox txtComPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTestCommPort;
        private System.Windows.Forms.Button btnExit;
    }
}

