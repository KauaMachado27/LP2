namespace PLoops
{
    partial class frmExercicio1
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnVazios = new System.Windows.Forms.Button();
            this.btnPares = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(96, 54);
            this.rchtxtFrase.MaxLength = 100;
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(566, 96);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnVazios
            // 
            this.btnVazios.Location = new System.Drawing.Point(96, 299);
            this.btnVazios.Name = "btnVazios";
            this.btnVazios.Size = new System.Drawing.Size(97, 47);
            this.btnVazios.TabIndex = 1;
            this.btnVazios.Text = "Quantidade Espaços Vazios";
            this.btnVazios.UseVisualStyleBackColor = true;
            this.btnVazios.Click += new System.EventHandler(this.btnVazios_Click);
            // 
            // btnPares
            // 
            this.btnPares.Location = new System.Drawing.Point(470, 299);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(76, 47);
            this.btnPares.TabIndex = 2;
            this.btnPares.Text = "Quantidade de pares de letras";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(278, 299);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(77, 47);
            this.btnR.TabIndex = 3;
            this.btnR.Text = "Quantidade da letra \"R\"";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.btnVazios);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnVazios;
        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.Button btnR;
    }
}