namespace hotel
{
    partial class RoomsChild
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
            this.lblRooms = new System.Windows.Forms.Label();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblBalconey = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtBalconey = new System.Windows.Forms.TextBox();
            this.lblSuites = new System.Windows.Forms.Label();
            this.txtSuites = new System.Windows.Forms.TextBox();
            this.btnRooms = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNeedRepair = new System.Windows.Forms.TextBox();
            this.txtBeingRepaired = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNextFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Location = new System.Drawing.Point(26, 91);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(143, 20);
            this.lblRooms.TabIndex = 0;
            this.lblRooms.Text = "Rooms Availiable";
            // 
            // txtAvailable
            // 
            this.txtAvailable.Location = new System.Drawing.Point(330, 88);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.Size = new System.Drawing.Size(100, 22);
            this.txtAvailable.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(26, 170);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(106, 20);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total Rooms";
            // 
            // lblBalconey
            // 
            this.lblBalconey.AutoSize = true;
            this.lblBalconey.Location = new System.Drawing.Point(26, 235);
            this.lblBalconey.Name = "lblBalconey";
            this.lblBalconey.Size = new System.Drawing.Size(116, 20);
            this.lblBalconey.TabIndex = 3;
            this.lblBalconey.Text = "With Balconey";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(330, 154);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 4;
            // 
            // txtBalconey
            // 
            this.txtBalconey.Location = new System.Drawing.Point(330, 229);
            this.txtBalconey.Name = "txtBalconey";
            this.txtBalconey.Size = new System.Drawing.Size(100, 22);
            this.txtBalconey.TabIndex = 5;
            // 
            // lblSuites
            // 
            this.lblSuites.AutoSize = true;
            this.lblSuites.Location = new System.Drawing.Point(26, 303);
            this.lblSuites.Name = "lblSuites";
            this.lblSuites.Size = new System.Drawing.Size(44, 16);
            this.lblSuites.TabIndex = 6;
            this.lblSuites.Text = "Suites";
            // 
            // txtSuites
            // 
            this.txtSuites.Location = new System.Drawing.Point(330, 297);
            this.txtSuites.Name = "txtSuites";
            this.txtSuites.Size = new System.Drawing.Size(100, 22);
            this.txtSuites.TabIndex = 7;
            // 
            // btnRooms
            // 
            this.btnRooms.Location = new System.Drawing.Point(612, 88);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(154, 41);
            this.btnRooms.TabIndex = 8;
            this.btnRooms.Text = "Update Availiability";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Need Repair";
            // 
            // txtNeedRepair
            // 
            this.txtNeedRepair.Location = new System.Drawing.Point(330, 384);
            this.txtNeedRepair.Name = "txtNeedRepair";
            this.txtNeedRepair.Size = new System.Drawing.Size(100, 22);
            this.txtNeedRepair.TabIndex = 10;
            // 
            // txtBeingRepaired
            // 
            this.txtBeingRepaired.Location = new System.Drawing.Point(330, 474);
            this.txtBeingRepaired.Name = "txtBeingRepaired";
            this.txtBeingRepaired.Size = new System.Drawing.Size(100, 22);
            this.txtBeingRepaired.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Being Repaired";
            // 
            // btnNextFile
            // 
            this.btnNextFile.Location = new System.Drawing.Point(621, 291);
            this.btnNextFile.Name = "btnNextFile";
            this.btnNextFile.Size = new System.Drawing.Size(154, 35);
            this.btnNextFile.TabIndex = 14;
            this.btnNextFile.Text = "Read Next File";
            this.btnNextFile.UseVisualStyleBackColor = true;
            this.btnNextFile.Click += new System.EventHandler(this.btnNextFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(621, 183);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(154, 35);
            this.btnOpenFile.TabIndex = 15;
            this.btnOpenFile.Text = "Open FIle";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // RoomsChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1078, 635);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnNextFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBeingRepaired);
            this.Controls.Add(this.txtNeedRepair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.txtSuites);
            this.Controls.Add(this.lblSuites);
            this.Controls.Add(this.txtBalconey);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblBalconey);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtAvailable);
            this.Controls.Add(this.lblRooms);
            this.Name = "RoomsChild";
            this.Text = "RoomsChild";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblBalconey;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtBalconey;
        private System.Windows.Forms.Label lblSuites;
        private System.Windows.Forms.TextBox txtSuites;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNeedRepair;
        private System.Windows.Forms.TextBox txtBeingRepaired;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNextFile;
        private System.Windows.Forms.Button btnOpenFile;
    }
}