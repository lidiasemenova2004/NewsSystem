namespace TheNewsSystem
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.Close_button = new System.Windows.Forms.Button();
            this.Help_Header = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.TextBox();
            this.Continue_button = new System.Windows.Forms.Button();
            this.Reset_button = new System.Windows.Forms.Button();
            this.Helper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Close_button
            // 
            this.Close_button.Image = ((System.Drawing.Image)(resources.GetObject("Close_button.Image")));
            this.Close_button.Location = new System.Drawing.Point(735, 12);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(53, 49);
            this.Close_button.TabIndex = 2;
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Help_Header
            // 
            this.Help_Header.AutoSize = true;
            this.Help_Header.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Help_Header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Help_Header.Location = new System.Drawing.Point(34, 127);
            this.Help_Header.Name = "Help_Header";
            this.Help_Header.Size = new System.Drawing.Size(695, 142);
            this.Help_Header.TabIndex = 3;
            this.Help_Header.Text = "Для продолжения работы, \nпожалуйста, введите своё имя.";
            // 
            // Autor
            // 
            this.Autor.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Autor.Location = new System.Drawing.Point(56, 350);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(658, 73);
            this.Autor.TabIndex = 4;
            // 
            // Continue_button
            // 
            this.Continue_button.Font = new System.Drawing.Font("Segoe Print", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Continue_button.Location = new System.Drawing.Point(56, 452);
            this.Continue_button.Name = "Continue_button";
            this.Continue_button.Size = new System.Drawing.Size(658, 117);
            this.Continue_button.TabIndex = 5;
            this.Continue_button.Text = "Продолжить";
            this.Continue_button.UseVisualStyleBackColor = true;
            this.Continue_button.Click += new System.EventHandler(this.Continue_button_Click);
            // 
            // Reset_button
            // 
            this.Reset_button.Image = ((System.Drawing.Image)(resources.GetObject("Reset_button.Image")));
            this.Reset_button.Location = new System.Drawing.Point(655, 12);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(74, 59);
            this.Reset_button.TabIndex = 6;
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // Helper
            // 
            this.Helper.AutoSize = true;
            this.Helper.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Helper.Location = new System.Drawing.Point(93, 286);
            this.Helper.Name = "Helper";
            this.Helper.Size = new System.Drawing.Size(508, 31);
            this.Helper.TabIndex = 7;
            this.Helper.Text = "(Запрещено использовать нижнее подчёркивание \'_\')";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.Helper);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.Continue_button);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.Help_Header);
            this.Controls.Add(this.Close_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Label Help_Header;
        private System.Windows.Forms.TextBox Autor;
        private System.Windows.Forms.Button Continue_button;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Label Helper;
    }
}