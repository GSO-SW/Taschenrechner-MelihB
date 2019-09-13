namespace Taschenrechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxZahl1 = new System.Windows.Forms.TextBox();
            this.tbxZahl2 = new System.Windows.Forms.TextBox();
            this.lblZahl1 = new System.Windows.Forms.Label();
            this.lblZahl2 = new System.Windows.Forms.Label();
            this.lblErgebnis = new System.Windows.Forms.Label();
            this.tbxErgebnis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxZahl1
            // 
            this.tbxZahl1.Location = new System.Drawing.Point(82, 63);
            this.tbxZahl1.Name = "tbxZahl1";
            this.tbxZahl1.Size = new System.Drawing.Size(100, 22);
            this.tbxZahl1.TabIndex = 0;
            this.tbxZahl1.TextChanged += new System.EventHandler(this.TbxZahl1_TextChanged);
            // 
            // tbxZahl2
            // 
            this.tbxZahl2.Location = new System.Drawing.Point(249, 62);
            this.tbxZahl2.Name = "tbxZahl2";
            this.tbxZahl2.Size = new System.Drawing.Size(100, 22);
            this.tbxZahl2.TabIndex = 1;
            this.tbxZahl2.TextChanged += new System.EventHandler(this.TbxZahl2_TextChanged);
            // 
            // lblZahl1
            // 
            this.lblZahl1.AutoSize = true;
            this.lblZahl1.Location = new System.Drawing.Point(82, 40);
            this.lblZahl1.Name = "lblZahl1";
            this.lblZahl1.Size = new System.Drawing.Size(48, 17);
            this.lblZahl1.TabIndex = 2;
            this.lblZahl1.Text = "1.Zahl";
            // 
            // lblZahl2
            // 
            this.lblZahl2.AutoSize = true;
            this.lblZahl2.Location = new System.Drawing.Point(249, 40);
            this.lblZahl2.Name = "lblZahl2";
            this.lblZahl2.Size = new System.Drawing.Size(48, 17);
            this.lblZahl2.TabIndex = 3;
            this.lblZahl2.Text = "2.Zahl";
            // 
            // lblErgebnis
            // 
            this.lblErgebnis.AutoSize = true;
            this.lblErgebnis.Location = new System.Drawing.Point(413, 40);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(64, 17);
            this.lblErgebnis.TabIndex = 4;
            this.lblErgebnis.Text = "Ergebnis";
            // 
            // tbxErgebnis
            // 
            this.tbxErgebnis.Location = new System.Drawing.Point(416, 61);
            this.tbxErgebnis.Name = "tbxErgebnis";
            this.tbxErgebnis.Size = new System.Drawing.Size(100, 22);
            this.tbxErgebnis.TabIndex = 5;
            this.tbxErgebnis.TextChanged += new System.EventHandler(this.TbxErgebnis_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxErgebnis);
            this.Controls.Add(this.lblErgebnis);
            this.Controls.Add(this.lblZahl2);
            this.Controls.Add(this.lblZahl1);
            this.Controls.Add(this.tbxZahl2);
            this.Controls.Add(this.tbxZahl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxZahl1;
        private System.Windows.Forms.TextBox tbxZahl2;
        private System.Windows.Forms.Label lblZahl1;
        private System.Windows.Forms.Label lblZahl2;
        private System.Windows.Forms.Label lblErgebnis;
        private System.Windows.Forms.TextBox tbxErgebnis;
    }
}

