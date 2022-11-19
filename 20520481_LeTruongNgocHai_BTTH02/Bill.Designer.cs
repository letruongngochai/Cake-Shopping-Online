
namespace _20520481_LeTruongNgocHai_BTTH02
{
    partial class Bill
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TenKH = new System.Windows.Forms.Label();
            this.SoKH = new System.Windows.Forms.Label();
            this.DiaChiKH = new System.Windows.Forms.Label();
            this.PayMethod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.BackColor = System.Drawing.Color.Linen;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Location = new System.Drawing.Point(0, 186);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(1360, 619);
            this.reportViewer1.TabIndex = 0;
            // 
            // TenKH
            // 
            this.TenKH.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenKH.Location = new System.Drawing.Point(12, 9);
            this.TenKH.Name = "TenKH";
            this.TenKH.Size = new System.Drawing.Size(798, 42);
            this.TenKH.TabIndex = 1;
            this.TenKH.Text = "Name: ";
            this.TenKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SoKH
            // 
            this.SoKH.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoKH.Location = new System.Drawing.Point(841, 9);
            this.SoKH.Name = "SoKH";
            this.SoKH.Size = new System.Drawing.Size(504, 42);
            this.SoKH.TabIndex = 2;
            this.SoKH.Text = "Number: ";
            this.SoKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DiaChiKH
            // 
            this.DiaChiKH.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChiKH.Location = new System.Drawing.Point(12, 64);
            this.DiaChiKH.Name = "DiaChiKH";
            this.DiaChiKH.Size = new System.Drawing.Size(798, 42);
            this.DiaChiKH.TabIndex = 3;
            this.DiaChiKH.Text = "Address: ";
            this.DiaChiKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PayMethod
            // 
            this.PayMethod.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayMethod.Location = new System.Drawing.Point(835, 64);
            this.PayMethod.Name = "PayMethod";
            this.PayMethod.Size = new System.Drawing.Size(510, 42);
            this.PayMethod.TabIndex = 4;
            this.PayMethod.Text = "Payment Method: ";
            this.PayMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PayMethod.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(798, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Promotion code: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Visible = false;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1357, 804);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PayMethod);
            this.Controls.Add(this.DiaChiKH);
            this.Controls.Add(this.SoKH);
            this.Controls.Add(this.TenKH);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label TenKH;
        private System.Windows.Forms.Label SoKH;
        private System.Windows.Forms.Label DiaChiKH;
        private System.Windows.Forms.Label PayMethod;
        private System.Windows.Forms.Label label1;
    }
}