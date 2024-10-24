namespace PLoops
{
    partial class frmExercicio2
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
            this.txtNumeroN = new System.Windows.Forms.TextBox();
            this.lblNumeroN = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumeroN
            // 
            this.txtNumeroN.Location = new System.Drawing.Point(227, 117);
            this.txtNumeroN.Name = "txtNumeroN";
            this.txtNumeroN.Size = new System.Drawing.Size(213, 26);
            this.txtNumeroN.TabIndex = 0;
            // 
            // lblNumeroN
            // 
            this.lblNumeroN.AutoSize = true;
            this.lblNumeroN.Location = new System.Drawing.Point(109, 123);
            this.lblNumeroN.Name = "lblNumeroN";
            this.lblNumeroN.Size = new System.Drawing.Size(80, 20);
            this.lblNumeroN.TabIndex = 1;
            this.lblNumeroN.Text = "Número N";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(215, 317);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(181, 61);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "Gerar Número H";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblNumeroN);
            this.Controls.Add(this.txtNumeroN);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroN;
        private System.Windows.Forms.Label lblNumeroN;
        private System.Windows.Forms.Button btnGerar;
    }
}