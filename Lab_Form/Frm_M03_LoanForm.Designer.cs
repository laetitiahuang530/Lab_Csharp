namespace Lab_Form
{
    partial class Frm_M03_LoanForm
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
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.loanAmount = new System.Windows.Forms.Label();
            this.txtExpYear = new System.Windows.Forms.TextBox();
            this.Interest = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.ExpirationYear = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPMT = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoanAmount.Location = new System.Drawing.Point(244, 41);
            this.txtLoanAmount.Multiline = true;
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(150, 40);
            this.txtLoanAmount.TabIndex = 0;
            this.txtLoanAmount.Text = "100000";
            this.txtLoanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loanAmount
            // 
            this.loanAmount.AutoSize = true;
            this.loanAmount.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loanAmount.Location = new System.Drawing.Point(107, 41);
            this.loanAmount.Name = "loanAmount";
            this.loanAmount.Size = new System.Drawing.Size(120, 27);
            this.loanAmount.TabIndex = 1;
            this.loanAmount.Text = "貸款金額";
            // 
            // txtExpYear
            // 
            this.txtExpYear.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtExpYear.Location = new System.Drawing.Point(244, 113);
            this.txtExpYear.Multiline = true;
            this.txtExpYear.Name = "txtExpYear";
            this.txtExpYear.Size = new System.Drawing.Size(150, 40);
            this.txtExpYear.TabIndex = 2;
            this.txtExpYear.Text = "2";
            this.txtExpYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Interest
            // 
            this.Interest.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Interest.Location = new System.Drawing.Point(244, 187);
            this.Interest.Multiline = true;
            this.Interest.Name = "Interest";
            this.Interest.Size = new System.Drawing.Size(150, 40);
            this.Interest.TabIndex = 3;
            this.Interest.Text = "10";
            this.Interest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDownPayment.Location = new System.Drawing.Point(244, 260);
            this.txtDownPayment.Multiline = true;
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(150, 40);
            this.txtDownPayment.TabIndex = 4;
            this.txtDownPayment.Text = "0";
            this.txtDownPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExpirationYear
            // 
            this.ExpirationYear.AutoSize = true;
            this.ExpirationYear.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ExpirationYear.Location = new System.Drawing.Point(107, 113);
            this.ExpirationYear.Name = "ExpirationYear";
            this.ExpirationYear.Size = new System.Drawing.Size(109, 27);
            this.ExpirationYear.TabIndex = 5;
            this.ExpirationYear.Text = "期限(年)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(107, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "利率(%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(107, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "頭期款";
            // 
            // btnPMT
            // 
            this.btnPMT.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPMT.Location = new System.Drawing.Point(112, 344);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(177, 48);
            this.btnPMT.TabIndex = 8;
            this.btnPMT.Text = "PMT (月付)";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotal.Location = new System.Drawing.Point(318, 344);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(177, 48);
            this.btnTotal.TabIndex = 9;
            this.btnTotal.Text = "總付額";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(523, 344);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(177, 48);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Frm_M03_LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 420);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnPMT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExpirationYear);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.Interest);
            this.Controls.Add(this.txtExpYear);
            this.Controls.Add(this.loanAmount);
            this.Controls.Add(this.txtLoanAmount);
            this.Name = "Frm_M03_LoanForm";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.Label loanAmount;
        private System.Windows.Forms.TextBox txtExpYear;
        private System.Windows.Forms.TextBox Interest;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Label ExpirationYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnReport;
    }
}