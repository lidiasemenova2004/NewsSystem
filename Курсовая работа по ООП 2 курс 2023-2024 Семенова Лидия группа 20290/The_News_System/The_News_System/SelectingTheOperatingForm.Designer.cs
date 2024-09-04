namespace TheNewsSystem
{
    partial class SelectingTheOperatingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectingTheOperatingForm));
            this.Close_button = new System.Windows.Forms.Button();
            this.Viewing_Mode_button = new System.Windows.Forms.Button();
            this.News_Adding_Mode_button = new System.Windows.Forms.Button();
            this.Helped_Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Close_button
            // 
            this.Close_button.AutoSize = true;
            this.Close_button.Image = ((System.Drawing.Image)(resources.GetObject("Close_button.Image")));
            this.Close_button.Location = new System.Drawing.Point(731, 12);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(57, 56);
            this.Close_button.TabIndex = 0;
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Viewing_Mode_button
            // 
            this.Viewing_Mode_button.Font = new System.Drawing.Font("Segoe Print", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Viewing_Mode_button.Location = new System.Drawing.Point(12, 228);
            this.Viewing_Mode_button.Name = "Viewing_Mode_button";
            this.Viewing_Mode_button.Size = new System.Drawing.Size(776, 219);
            this.Viewing_Mode_button.TabIndex = 1;
            this.Viewing_Mode_button.Text = "Режим просмотра новостей";
            this.Viewing_Mode_button.UseVisualStyleBackColor = true;
            this.Viewing_Mode_button.Click += new System.EventHandler(this.Viewing_Mode_button_Click);
            // 
            // News_Adding_Mode_button
            // 
            this.News_Adding_Mode_button.Font = new System.Drawing.Font("Segoe Print", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.News_Adding_Mode_button.Location = new System.Drawing.Point(12, 509);
            this.News_Adding_Mode_button.Name = "News_Adding_Mode_button";
            this.News_Adding_Mode_button.Size = new System.Drawing.Size(776, 219);
            this.News_Adding_Mode_button.TabIndex = 2;
            this.News_Adding_Mode_button.Text = "Режим добавления новостей";
            this.News_Adding_Mode_button.UseVisualStyleBackColor = true;
            this.News_Adding_Mode_button.Click += new System.EventHandler(this.News_Adding_Mode_button_Click);
            // 
            // Helped_Text
            // 
            this.Helped_Text.AutoSize = true;
            this.Helped_Text.Font = new System.Drawing.Font("Segoe Print", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Helped_Text.Location = new System.Drawing.Point(9, 12);
            this.Helped_Text.Name = "Helped_Text";
            this.Helped_Text.Size = new System.Drawing.Size(562, 130);
            this.Helped_Text.TabIndex = 3;
            this.Helped_Text.Text = "Пожалуйста, выберите \nрежим работы программы";
            // 
            // SelectingTheOperatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.Helped_Text);
            this.Controls.Add(this.News_Adding_Mode_button);
            this.Controls.Add(this.Viewing_Mode_button);
            this.Controls.Add(this.Close_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectingTheOperatingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectingTheOperatingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button Viewing_Mode_button;
        private System.Windows.Forms.Button News_Adding_Mode_button;
        private System.Windows.Forms.Label Helped_Text;
    }
}