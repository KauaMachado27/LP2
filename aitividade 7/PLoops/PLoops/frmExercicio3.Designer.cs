namespace PLoops
{
    partial class frmExercicio3
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
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.lblFrase = new System.Windows.Forms.Label();
            this.btnPalindromo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(209, 127);
            this.txtFrase.MaxLength = 50;
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(157, 26);
            this.txtFrase.TabIndex = 0;
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Location = new System.Drawing.Point(60, 133);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(50, 20);
            this.lblFrase.TabIndex = 1;
            this.lblFrase.Text = "Frase";
            // 
            // btnPalindromo
            // 
            this.btnPalindromo.Location = new System.Drawing.Point(201, 265);
            this.btnPalindromo.Name = "btnPalindromo";
            this.btnPalindromo.Size = new System.Drawing.Size(165, 60);
            this.btnPalindromo.TabIndex = 2;
            this.btnPalindromo.Text = "É Palíndromo?";
            this.btnPalindromo.UseVisualStyleBackColor = true;
            this.btnPalindromo.Click += new System.EventHandler(this.btnPalindromo_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPalindromo);
            this.Controls.Add(this.lblFrase);
            this.Controls.Add(this.txtFrase);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.Button btnPalindromo;
    }
}