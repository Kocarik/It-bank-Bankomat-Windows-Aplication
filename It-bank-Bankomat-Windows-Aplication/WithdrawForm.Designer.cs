namespace It_bank_Bankomat_Windows_Aplication
{
    partial class WithdrawForm
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
            this.txtAmout = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pict10 = new System.Windows.Forms.PictureBox();
            this.pict5 = new System.Windows.Forms.PictureBox();
            this.pict20 = new System.Windows.Forms.PictureBox();
            this.pict50 = new System.Windows.Forms.PictureBox();
            this.pict100 = new System.Windows.Forms.PictureBox();
            this.pict200 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pict10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict200)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmout
            // 
            this.txtAmout.Location = new System.Drawing.Point(183, 168);
            this.txtAmout.Name = "txtAmout";
            this.txtAmout.Size = new System.Drawing.Size(111, 20);
            this.txtAmout.TabIndex = 0;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(300, 166);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(135, 23);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw Money";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account ID";
            // 
            // pict10
            // 
            this.pict10.Image = global::It_bank_Bankomat_Windows_Aplication.Properties.Resources._10_euro;
            this.pict10.Location = new System.Drawing.Point(12, 139);
            this.pict10.Name = "pict10";
            this.pict10.Size = new System.Drawing.Size(165, 82);
            this.pict10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict10.TabIndex = 4;
            this.pict10.TabStop = false;
            // 
            // pict5
            // 
            this.pict5.Image = global::It_bank_Bankomat_Windows_Aplication.Properties.Resources._5_euro;
            this.pict5.Location = new System.Drawing.Point(12, 12);
            this.pict5.Name = "pict5";
            this.pict5.Size = new System.Drawing.Size(165, 82);
            this.pict5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict5.TabIndex = 3;
            this.pict5.TabStop = false;
            this.pict5.Click += new System.EventHandler(this.pict5_Click);
            // 
            // pict20
            // 
            this.pict20.Image = global::It_bank_Bankomat_Windows_Aplication.Properties.Resources._20_euro;
            this.pict20.Location = new System.Drawing.Point(12, 267);
            this.pict20.Name = "pict20";
            this.pict20.Size = new System.Drawing.Size(165, 82);
            this.pict20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict20.TabIndex = 5;
            this.pict20.TabStop = false;
            // 
            // pict50
            // 
            this.pict50.Image = global::It_bank_Bankomat_Windows_Aplication.Properties.Resources._50_eur;
            this.pict50.Location = new System.Drawing.Point(483, 12);
            this.pict50.Name = "pict50";
            this.pict50.Size = new System.Drawing.Size(165, 82);
            this.pict50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict50.TabIndex = 6;
            this.pict50.TabStop = false;
            // 
            // pict100
            // 
            this.pict100.Image = global::It_bank_Bankomat_Windows_Aplication.Properties.Resources._100_euro;
            this.pict100.Location = new System.Drawing.Point(483, 139);
            this.pict100.Name = "pict100";
            this.pict100.Size = new System.Drawing.Size(165, 82);
            this.pict100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict100.TabIndex = 7;
            this.pict100.TabStop = false;
            // 
            // pict200
            // 
            this.pict200.Image = global::It_bank_Bankomat_Windows_Aplication.Properties.Resources._200_eur;
            this.pict200.Location = new System.Drawing.Point(483, 267);
            this.pict200.Name = "pict200";
            this.pict200.Size = new System.Drawing.Size(165, 82);
            this.pict200.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict200.TabIndex = 8;
            this.pict200.TabStop = false;
            // 
            // WithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 361);
            this.Controls.Add(this.pict200);
            this.Controls.Add(this.pict100);
            this.Controls.Add(this.pict50);
            this.Controls.Add(this.pict20);
            this.Controls.Add(this.pict10);
            this.Controls.Add(this.pict5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txtAmout);
            this.Name = "WithdrawForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WithdrawForm";
            ((System.ComponentModel.ISupportInitialize)(this.pict10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict200)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmout;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pict5;
        private System.Windows.Forms.PictureBox pict10;
        private System.Windows.Forms.PictureBox pict20;
        private System.Windows.Forms.PictureBox pict50;
        private System.Windows.Forms.PictureBox pict100;
        private System.Windows.Forms.PictureBox pict200;
    }
}