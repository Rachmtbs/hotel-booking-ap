namespace hotel
{
    partial class OccupanciesChild
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
            this.btnAddOccupancies = new System.Windows.Forms.Button();
            this.lblReservation = new System.Windows.Forms.Label();
            this.lblCleintId = new System.Windows.Forms.Label();
            this.lblCheckedIn = new System.Windows.Forms.Label();
            this.lblCancled = new System.Windows.Forms.Label();
            this.txtReservation = new System.Windows.Forms.TextBox();
            this.txtCleintId = new System.Windows.Forms.TextBox();
            this.txtCheckIn = new System.Windows.Forms.TextBox();
            this.txtCancled = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnNextRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddOccupancies
            // 
            this.btnAddOccupancies.Location = new System.Drawing.Point(49, 345);
            this.btnAddOccupancies.Name = "btnAddOccupancies";
            this.btnAddOccupancies.Size = new System.Drawing.Size(148, 32);
            this.btnAddOccupancies.TabIndex = 0;
            this.btnAddOccupancies.Text = "Add Occupancies";
            this.btnAddOccupancies.UseVisualStyleBackColor = true;
            this.btnAddOccupancies.Click += new System.EventHandler(this.btnAddOccupancies_Click);
            // 
            // lblReservation
            // 
            this.lblReservation.AutoSize = true;
            this.lblReservation.Location = new System.Drawing.Point(33, 88);
            this.lblReservation.Name = "lblReservation";
            this.lblReservation.Size = new System.Drawing.Size(164, 20);
            this.lblReservation.TabIndex = 1;
            this.lblReservation.Text = "Reservation Number";
            // 
            // lblCleintId
            // 
            this.lblCleintId.AutoSize = true;
            this.lblCleintId.Location = new System.Drawing.Point(33, 159);
            this.lblCleintId.Name = "lblCleintId";
            this.lblCleintId.Size = new System.Drawing.Size(68, 20);
            this.lblCleintId.TabIndex = 2;
            this.lblCleintId.Text = "Cleint Id";
            // 
            // lblCheckedIn
            // 
            this.lblCheckedIn.AutoSize = true;
            this.lblCheckedIn.Location = new System.Drawing.Point(33, 214);
            this.lblCheckedIn.Name = "lblCheckedIn";
            this.lblCheckedIn.Size = new System.Drawing.Size(93, 20);
            this.lblCheckedIn.TabIndex = 3;
            this.lblCheckedIn.Text = "Checked In";
            // 
            // lblCancled
            // 
            this.lblCancled.AutoSize = true;
            this.lblCancled.Location = new System.Drawing.Point(33, 288);
            this.lblCancled.Name = "lblCancled";
            this.lblCancled.Size = new System.Drawing.Size(71, 20);
            this.lblCancled.TabIndex = 4;
            this.lblCancled.Text = "Cancled";
            // 
            // txtReservation
            // 
            this.txtReservation.Location = new System.Drawing.Point(269, 88);
            this.txtReservation.Name = "txtReservation";
            this.txtReservation.Size = new System.Drawing.Size(100, 22);
            this.txtReservation.TabIndex = 5;
            // 
            // txtCleintId
            // 
            this.txtCleintId.Location = new System.Drawing.Point(269, 159);
            this.txtCleintId.Name = "txtCleintId";
            this.txtCleintId.Size = new System.Drawing.Size(100, 22);
            this.txtCleintId.TabIndex = 6;
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.Location = new System.Drawing.Point(269, 231);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.Size = new System.Drawing.Size(100, 22);
            this.txtCheckIn.TabIndex = 7;
            // 
            // txtCancled
            // 
            this.txtCancled.Location = new System.Drawing.Point(269, 299);
            this.txtCancled.Name = "txtCancled";
            this.txtCancled.Size = new System.Drawing.Size(100, 22);
            this.txtCancled.TabIndex = 8;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(251, 345);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(138, 32);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnNextRecord
            // 
            this.btnNextRecord.Enabled = false;
            this.btnNextRecord.Location = new System.Drawing.Point(449, 345);
            this.btnNextRecord.Name = "btnNextRecord";
            this.btnNextRecord.Size = new System.Drawing.Size(186, 32);
            this.btnNextRecord.TabIndex = 10;
            this.btnNextRecord.Text = "Next Record";
            this.btnNextRecord.UseVisualStyleBackColor = true;
            this.btnNextRecord.Click += new System.EventHandler(this.btnNextRecord_Click);
            // 
            // OccupanciesChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNextRecord);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtCancled);
            this.Controls.Add(this.txtCheckIn);
            this.Controls.Add(this.txtCleintId);
            this.Controls.Add(this.txtReservation);
            this.Controls.Add(this.lblCancled);
            this.Controls.Add(this.lblCheckedIn);
            this.Controls.Add(this.lblCleintId);
            this.Controls.Add(this.lblReservation);
            this.Controls.Add(this.btnAddOccupancies);
            this.Name = "OccupanciesChild";
            this.Text = "OccupanciesChild";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddOccupancies;
        private System.Windows.Forms.Label lblReservation;
        private System.Windows.Forms.Label lblCleintId;
        private System.Windows.Forms.Label lblCheckedIn;
        private System.Windows.Forms.Label lblCancled;
        private System.Windows.Forms.TextBox txtReservation;
        private System.Windows.Forms.TextBox txtCleintId;
        private System.Windows.Forms.TextBox txtCheckIn;
        private System.Windows.Forms.TextBox txtCancled;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnNextRecord;
    }
}