namespace FaturaHesapOOP
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxFaturaTip = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.txtİlkİndex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSonIndex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHesap = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOdenecekTutar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fatura Tip Seçiniz:";
            // 
            // cmbxFaturaTip
            // 
            this.cmbxFaturaTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbxFaturaTip.FormattingEnabled = true;
            this.cmbxFaturaTip.Location = new System.Drawing.Point(474, 38);
            this.cmbxFaturaTip.Name = "cmbxFaturaTip";
            this.cmbxFaturaTip.Size = new System.Drawing.Size(316, 50);
            this.cmbxFaturaTip.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Birim Fiyat:";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirimFiyat.Location = new System.Drawing.Point(361, 149);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(429, 49);
            this.txtBirimFiyat.TabIndex = 3;
            // 
            // txtİlkİndex
            // 
            this.txtİlkİndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtİlkİndex.Location = new System.Drawing.Point(361, 243);
            this.txtİlkİndex.Name = "txtİlkİndex";
            this.txtİlkİndex.Size = new System.Drawing.Size(429, 49);
            this.txtİlkİndex.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "İlk İndex:";
            // 
            // txtSonIndex
            // 
            this.txtSonIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonIndex.Location = new System.Drawing.Point(361, 331);
            this.txtSonIndex.Name = "txtSonIndex";
            this.txtSonIndex.Size = new System.Drawing.Size(429, 49);
            this.txtSonIndex.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "Son İndex:";
            // 
            // btnHesap
            // 
            this.btnHesap.Location = new System.Drawing.Point(582, 436);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(208, 58);
            this.btnHesap.TabIndex = 8;
            this.btnHesap.Text = "Hesap";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(242, 622);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 42);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ödenecek Tutar:";
            // 
            // lblOdenecekTutar
            // 
            this.lblOdenecekTutar.AutoSize = true;
            this.lblOdenecekTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenecekTutar.Location = new System.Drawing.Point(575, 622);
            this.lblOdenecekTutar.Name = "lblOdenecekTutar";
            this.lblOdenecekTutar.Size = new System.Drawing.Size(39, 42);
            this.lblOdenecekTutar.TabIndex = 10;
            this.lblOdenecekTutar.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 798);
            this.Controls.Add(this.lblOdenecekTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.txtSonIndex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtİlkİndex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbxFaturaTip);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxFaturaTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.TextBox txtİlkİndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSonIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOdenecekTutar;
    }
}

