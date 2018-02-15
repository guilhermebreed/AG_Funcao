namespace AlgoritmoGenetico
{
    partial class FormTesteCrossover
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
            this.textPai = new System.Windows.Forms.TextBox();
            this.textMae = new System.Windows.Forms.TextBox();
            this.textFilho1 = new System.Windows.Forms.TextBox();
            this.textFilho2 = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.textPop = new System.Windows.Forms.RichTextBox();
            this.btnInteirar = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textPai
            // 
            this.textPai.Location = new System.Drawing.Point(12, 12);
            this.textPai.Name = "textPai";
            this.textPai.Size = new System.Drawing.Size(684, 20);
            this.textPai.TabIndex = 0;
            // 
            // textMae
            // 
            this.textMae.Location = new System.Drawing.Point(12, 38);
            this.textMae.Name = "textMae";
            this.textMae.Size = new System.Drawing.Size(684, 20);
            this.textMae.TabIndex = 1;
            // 
            // textFilho1
            // 
            this.textFilho1.Location = new System.Drawing.Point(12, 82);
            this.textFilho1.Name = "textFilho1";
            this.textFilho1.Size = new System.Drawing.Size(684, 20);
            this.textFilho1.TabIndex = 2;
            // 
            // textFilho2
            // 
            this.textFilho2.Location = new System.Drawing.Point(12, 108);
            this.textFilho2.Name = "textFilho2";
            this.textFilho2.Size = new System.Drawing.Size(684, 20);
            this.textFilho2.TabIndex = 3;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(245, 405);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseMnemonic = false;
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textPop
            // 
            this.textPop.Location = new System.Drawing.Point(12, 134);
            this.textPop.Name = "textPop";
            this.textPop.Size = new System.Drawing.Size(684, 265);
            this.textPop.TabIndex = 5;
            this.textPop.Text = "";
            this.textPop.TextChanged += new System.EventHandler(this.textPop_TextChanged);
            // 
            // btnInteirar
            // 
            this.btnInteirar.Location = new System.Drawing.Point(389, 405);
            this.btnInteirar.Name = "btnInteirar";
            this.btnInteirar.Size = new System.Drawing.Size(75, 23);
            this.btnInteirar.TabIndex = 6;
            this.btnInteirar.Text = "Inteirar";
            this.btnInteirar.UseVisualStyleBackColor = true;
            this.btnInteirar.Click += new System.EventHandler(this.btnInteirar_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(490, 410);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(36, 13);
            this.lblMedia.TabIndex = 7;
            this.lblMedia.Text = "Média";
            // 
            // FormTesteCrossover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 440);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.btnInteirar);
            this.Controls.Add(this.textPop);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.textFilho2);
            this.Controls.Add(this.textFilho1);
            this.Controls.Add(this.textMae);
            this.Controls.Add(this.textPai);
            this.Name = "FormTesteCrossover";
            this.Text = "FormTesteCrossover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPai;
        private System.Windows.Forms.TextBox textMae;
        private System.Windows.Forms.TextBox textFilho1;
        private System.Windows.Forms.TextBox textFilho2;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.RichTextBox textPop;
        private System.Windows.Forms.Button btnInteirar;
        private System.Windows.Forms.Label lblMedia;
    }
}