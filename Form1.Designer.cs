
namespace ImeQrCode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtChavePix = new System.Windows.Forms.TextBox();
            this.lblChavePix = new System.Windows.Forms.Label();
            this.btnCalculaCRC = new System.Windows.Forms.Button();
            this.pbQrCode = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // txtChavePix
            // 
            this.txtChavePix.Location = new System.Drawing.Point(78, 49);
            this.txtChavePix.Name = "txtChavePix";
            this.txtChavePix.Size = new System.Drawing.Size(323, 23);
            this.txtChavePix.TabIndex = 0;
            // 
            // lblChavePix
            // 
            this.lblChavePix.AutoSize = true;
            this.lblChavePix.Location = new System.Drawing.Point(12, 52);
            this.lblChavePix.Name = "lblChavePix";
            this.lblChavePix.Size = new System.Drawing.Size(60, 15);
            this.lblChavePix.TabIndex = 2;
            this.lblChavePix.Text = "Chave PIX";
            // 
            // btnCalculaCRC
            // 
            this.btnCalculaCRC.Location = new System.Drawing.Point(231, 78);
            this.btnCalculaCRC.Name = "btnCalculaCRC";
            this.btnCalculaCRC.Size = new System.Drawing.Size(170, 23);
            this.btnCalculaCRC.TabIndex = 4;
            this.btnCalculaCRC.Text = "Gerar QrCode";
            this.btnCalculaCRC.UseVisualStyleBackColor = true;
            this.btnCalculaCRC.Click += new System.EventHandler(this.btnCalculaCRC_Click);
            // 
            // pbQrCode
            // 
            this.pbQrCode.Location = new System.Drawing.Point(116, 124);
            this.pbQrCode.Name = "pbQrCode";
            this.pbQrCode.Size = new System.Drawing.Size(180, 180);
            this.pbQrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbQrCode.TabIndex = 5;
            this.pbQrCode.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(343, 23);
            this.txtNome.TabIndex = 6;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 81);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(57, 15);
            this.lblValor.TabIndex = 8;
            this.lblValor.Text = "Valor (R$)";
            // 
            // txtValor
            // 
            this.txtValor.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtValor.Location = new System.Drawing.Point(78, 78);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(147, 23);
            this.txtValor.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 316);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pbQrCode);
            this.Controls.Add(this.btnCalculaCRC);
            this.Controls.Add(this.lblChavePix);
            this.Controls.Add(this.txtChavePix);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de QrCode de pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.pbQrCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChavePix;
        private System.Windows.Forms.Label lblChavePix;
        private System.Windows.Forms.Button btnCalculaCRC;
        private System.Windows.Forms.PictureBox pbQrCode;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
    }
}

