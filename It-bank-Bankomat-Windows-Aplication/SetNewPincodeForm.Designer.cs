namespace It_bank_Bankomat_Windows_Aplication
{
    partial class SetNewPincodeForm
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
            this.txtNewPincode1 = new System.Windows.Forms.TextBox();
            this.txtOldPincode = new System.Windows.Forms.TextBox();
            this.btnSetNewPin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOldPInStatus = new System.Windows.Forms.Label();
            this.lblCardID = new System.Windows.Forms.Label();
            this.txtNewPincode2 = new System.Windows.Forms.TextBox();
            this.lblNewPinStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewPincode1
            // 
            this.txtNewPincode1.Location = new System.Drawing.Point(198, 124);
            this.txtNewPincode1.Name = "txtNewPincode1";
            this.txtNewPincode1.Size = new System.Drawing.Size(100, 20);
            this.txtNewPincode1.TabIndex = 0;
            // 
            // txtOldPincode
            // 
            this.txtOldPincode.Location = new System.Drawing.Point(198, 98);
            this.txtOldPincode.Name = "txtOldPincode";
            this.txtOldPincode.Size = new System.Drawing.Size(100, 20);
            this.txtOldPincode.TabIndex = 2;
            // 
            // btnSetNewPin
            // 
            this.btnSetNewPin.Location = new System.Drawing.Point(198, 176);
            this.btnSetNewPin.Name = "btnSetNewPin";
            this.btnSetNewPin.Size = new System.Drawing.Size(100, 23);
            this.btnSetNewPin.TabIndex = 3;
            this.btnSetNewPin.Text = "SET NEW PIN";
            this.btnSetNewPin.UseVisualStyleBackColor = true;
            this.btnSetNewPin.Click += new System.EventHandler(this.btnSetNewPin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Old pin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "New pin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Repeat new pin";
            // 
            // txtOldPInStatus
            // 
            this.txtOldPInStatus.AutoSize = true;
            this.txtOldPInStatus.Location = new System.Drawing.Point(110, 234);
            this.txtOldPInStatus.Name = "txtOldPInStatus";
            this.txtOldPInStatus.Size = new System.Drawing.Size(96, 13);
            this.txtOldPInStatus.TabIndex = 7;
            this.txtOldPInStatus.Text = "OLD PIN STATUS";
            // 
            // lblCardID
            // 
            this.lblCardID.AutoSize = true;
            this.lblCardID.Location = new System.Drawing.Point(212, 234);
            this.lblCardID.Name = "lblCardID";
            this.lblCardID.Size = new System.Drawing.Size(51, 13);
            this.lblCardID.TabIndex = 8;
            this.lblCardID.Text = "CARD ID";
            // 
            // txtNewPincode2
            // 
            this.txtNewPincode2.Location = new System.Drawing.Point(198, 150);
            this.txtNewPincode2.Name = "txtNewPincode2";
            this.txtNewPincode2.Size = new System.Drawing.Size(100, 20);
            this.txtNewPincode2.TabIndex = 1;
            // 
            // lblNewPinStatus
            // 
            this.lblNewPinStatus.AutoSize = true;
            this.lblNewPinStatus.Location = new System.Drawing.Point(304, 181);
            this.lblNewPinStatus.Name = "lblNewPinStatus";
            this.lblNewPinStatus.Size = new System.Drawing.Size(100, 13);
            this.lblNewPinStatus.TabIndex = 9;
            this.lblNewPinStatus.Text = "NEW PIN STATUS";
            // 
            // SetNewPincodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 316);
            this.Controls.Add(this.lblNewPinStatus);
            this.Controls.Add(this.lblCardID);
            this.Controls.Add(this.txtOldPInStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetNewPin);
            this.Controls.Add(this.txtOldPincode);
            this.Controls.Add(this.txtNewPincode2);
            this.Controls.Add(this.txtNewPincode1);
            this.Name = "SetNewPincodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetNewPincodeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewPincode1;
        private System.Windows.Forms.TextBox txtOldPincode;
        private System.Windows.Forms.Button btnSetNewPin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtOldPInStatus;
        private System.Windows.Forms.Label lblCardID;
        private System.Windows.Forms.TextBox txtNewPincode2;
        private System.Windows.Forms.Label lblNewPinStatus;
    }
}