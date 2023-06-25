namespace hotel
{
    partial class ClientChild
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblReservationId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtReservation = new System.Windows.Forms.TextBox();
            this.btnCheckClient = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "First Name";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(12, 88);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(90, 20);
            this.lblLast.TabIndex = 1;
            this.lblLast.Text = "Last Name";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(12, 136);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(121, 20);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Phone Number";
            // 
            // lblReservationId
            // 
            this.lblReservationId.AutoSize = true;
            this.lblReservationId.Location = new System.Drawing.Point(12, 202);
            this.lblReservationId.Name = "lblReservationId";
            this.lblReservationId.Size = new System.Drawing.Size(118, 20);
            this.lblReservationId.TabIndex = 3;
            this.lblReservationId.Text = "Reservation Id";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(188, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(188, 88);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(100, 22);
            this.txtLast.TabIndex = 5;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(188, 133);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 22);
            this.txtNumber.TabIndex = 6;
            // 
            // txtReservation
            // 
            this.txtReservation.Location = new System.Drawing.Point(188, 200);
            this.txtReservation.Name = "txtReservation";
            this.txtReservation.Size = new System.Drawing.Size(100, 22);
            this.txtReservation.TabIndex = 7;
            // 
            // btnCheckClient
            // 
            this.btnCheckClient.Location = new System.Drawing.Point(530, 26);
            this.btnCheckClient.Name = "btnCheckClient";
            this.btnCheckClient.Size = new System.Drawing.Size(162, 82);
            this.btnCheckClient.TabIndex = 8;
            this.btnCheckClient.Text = "Check Client";
            this.btnCheckClient.UseVisualStyleBackColor = true;
            this.btnCheckClient.Click += new System.EventHandler(this.btnCheckClient_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(530, 133);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(162, 82);
            this.btnOpenFile.TabIndex = 9;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(530, 263);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(162, 82);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next File";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ClientChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnCheckClient);
            this.Controls.Add(this.txtReservation);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblReservationId);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblName);
            this.Name = "ClientChild";
            this.Text = "ClientChild";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblReservationId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtReservation;
        private System.Windows.Forms.Button btnCheckClient;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnNext;
    }
}