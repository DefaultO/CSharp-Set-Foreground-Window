namespace CSharp_Set_Foreground_Window
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_putWindowToForeground = new System.Windows.Forms.Button();
            this.txtbx_windowTitle = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_putWindowToForeground
            // 
            this.btn_putWindowToForeground.Location = new System.Drawing.Point(12, 38);
            this.btn_putWindowToForeground.Name = "btn_putWindowToForeground";
            this.btn_putWindowToForeground.Size = new System.Drawing.Size(264, 36);
            this.btn_putWindowToForeground.TabIndex = 5;
            this.btn_putWindowToForeground.Text = "Set Window with this Title to foreground";
            this.btn_putWindowToForeground.UseVisualStyleBackColor = true;
            this.btn_putWindowToForeground.Click += new System.EventHandler(this.btn_putWindowToForeground_Click);
            // 
            // txtbx_windowTitle
            // 
            this.txtbx_windowTitle.Location = new System.Drawing.Point(12, 12);
            this.txtbx_windowTitle.Name = "txtbx_windowTitle";
            this.txtbx_windowTitle.Size = new System.Drawing.Size(264, 20);
            this.txtbx_windowTitle.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 80);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(264, 185);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 276);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtbx_windowTitle);
            this.Controls.Add(this.btn_putWindowToForeground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Unknowncheats.me";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_putWindowToForeground;
        private System.Windows.Forms.TextBox txtbx_windowTitle;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

