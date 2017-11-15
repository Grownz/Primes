namespace Primes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartBox = new System.Windows.Forms.TextBox();
            this.EndBox = new System.Windows.Forms.TextBox();
            this.ButtonGo = new System.Windows.Forms.Button();
            this.PrimListe = new System.Windows.Forms.ListBox();
            this.MethodenBox = new System.Windows.Forms.GroupBox();
            this.ButtonM1 = new System.Windows.Forms.RadioButton();
            this.ButtonM2 = new System.Windows.Forms.RadioButton();
            this.MethodenBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ende:";
            // 
            // StartBox
            // 
            this.StartBox.Location = new System.Drawing.Point(106, 24);
            this.StartBox.Name = "StartBox";
            this.StartBox.Size = new System.Drawing.Size(228, 31);
            this.StartBox.TabIndex = 1;
            // 
            // EndBox
            // 
            this.EndBox.Location = new System.Drawing.Point(106, 115);
            this.EndBox.Name = "EndBox";
            this.EndBox.Size = new System.Drawing.Size(228, 31);
            this.EndBox.TabIndex = 2;
            // 
            // ButtonGo
            // 
            this.ButtonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGo.Location = new System.Drawing.Point(174, 180);
            this.ButtonGo.Name = "ButtonGo";
            this.ButtonGo.Size = new System.Drawing.Size(230, 50);
            this.ButtonGo.TabIndex = 3;
            this.ButtonGo.Text = "GO!";
            this.ButtonGo.UseVisualStyleBackColor = true;
            this.ButtonGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // PrimListe
            // 
            this.PrimListe.FormattingEnabled = true;
            this.PrimListe.ItemHeight = 25;
            this.PrimListe.Location = new System.Drawing.Point(71, 260);
            this.PrimListe.Name = "PrimListe";
            this.PrimListe.Size = new System.Drawing.Size(377, 204);
            this.PrimListe.TabIndex = 4;
            // 
            // MethodenBox
            // 
            this.MethodenBox.Controls.Add(this.ButtonM2);
            this.MethodenBox.Controls.Add(this.ButtonM1);
            this.MethodenBox.Location = new System.Drawing.Point(349, 24);
            this.MethodenBox.Name = "MethodenBox";
            this.MethodenBox.Size = new System.Drawing.Size(183, 122);
            this.MethodenBox.TabIndex = 5;
            this.MethodenBox.TabStop = false;
            this.MethodenBox.Text = "Methoden";
            // 
            // ButtonM1
            // 
            this.ButtonM1.AutoSize = true;
            this.ButtonM1.Location = new System.Drawing.Point(19, 38);
            this.ButtonM1.Name = "ButtonM1";
            this.ButtonM1.Size = new System.Drawing.Size(115, 29);
            this.ButtonM1.TabIndex = 0;
            this.ButtonM1.Text = "Parallel";
            this.ButtonM1.UseVisualStyleBackColor = true;
            // 
            // ButtonM2
            // 
            this.ButtonM2.AutoSize = true;
            this.ButtonM2.Location = new System.Drawing.Point(19, 74);
            this.ButtonM2.Name = "ButtonM2";
            this.ButtonM2.Size = new System.Drawing.Size(103, 29);
            this.ButtonM2.TabIndex = 1;
            this.ButtonM2.Text = "Seriell";
            this.ButtonM2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(544, 499);
            this.Controls.Add(this.MethodenBox);
            this.Controls.Add(this.PrimListe);
            this.Controls.Add(this.ButtonGo);
            this.Controls.Add(this.EndBox);
            this.Controls.Add(this.StartBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Primes";
            this.MethodenBox.ResumeLayout(false);
            this.MethodenBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StartBox;
        private System.Windows.Forms.TextBox EndBox;
        private System.Windows.Forms.Button ButtonGo;
        private System.Windows.Forms.ListBox PrimListe;
        private System.Windows.Forms.GroupBox MethodenBox;
        private System.Windows.Forms.RadioButton ButtonM2;
        private System.Windows.Forms.RadioButton ButtonM1;
    }
}

