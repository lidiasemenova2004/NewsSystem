namespace TheNewsSystem
{
    partial class  NewsAddingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewsAddingForm));
            this.Closebutton = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.Description_Text = new System.Windows.Forms.TextBox();
            this.Title_Text = new System.Windows.Forms.TextBox();
            this.Title_News = new System.Windows.Forms.Label();
            this.Description_News = new System.Windows.Forms.Label();
            this.Help_To_Redact = new System.Windows.Forms.Label();
            this.Savebutton = new System.Windows.Forms.Button();
            this.ShowListNewsToAutorbutton = new System.Windows.Forms.Button();
            this.ShowTheNewsbutton = new System.Windows.Forms.Button();
            this.List_News_To_Autor = new System.Windows.Forms.ListBox();
            this.Title_Window = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Closebutton
            // 
            this.Closebutton.Image = ((System.Drawing.Image)(resources.GetObject("Closebutton.Image")));
            this.Closebutton.Location = new System.Drawing.Point(735, 12);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(53, 49);
            this.Closebutton.TabIndex = 2;
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // Resetbutton
            // 
            this.Resetbutton.Image = ((System.Drawing.Image)(resources.GetObject("Resetbutton.Image")));
            this.Resetbutton.Location = new System.Drawing.Point(654, 12);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(75, 65);
            this.Resetbutton.TabIndex = 7;
            this.Resetbutton.UseVisualStyleBackColor = true;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // Description_Text
            // 
            this.Description_Text.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description_Text.Location = new System.Drawing.Point(12, 350);
            this.Description_Text.Multiline = true;
            this.Description_Text.Name = "Description_Text";
            this.Description_Text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Description_Text.Size = new System.Drawing.Size(776, 349);
            this.Description_Text.TabIndex = 8;
            // 
            // Title_Text
            // 
            this.Title_Text.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title_Text.Location = new System.Drawing.Point(12, 259);
            this.Title_Text.Name = "Title_Text";
            this.Title_Text.Size = new System.Drawing.Size(591, 48);
            this.Title_Text.TabIndex = 9;
            // 
            // Title_News
            // 
            this.Title_News.AutoSize = true;
            this.Title_News.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title_News.Location = new System.Drawing.Point(10, 226);
            this.Title_News.Name = "Title_News";
            this.Title_News.Size = new System.Drawing.Size(183, 30);
            this.Title_News.TabIndex = 10;
            this.Title_News.Text = "Заголовок новости";
            // 
            // Description_News
            // 
            this.Description_News.AutoSize = true;
            this.Description_News.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description_News.Location = new System.Drawing.Point(12, 317);
            this.Description_News.Name = "Description_News";
            this.Description_News.Size = new System.Drawing.Size(602, 30);
            this.Description_News.TabIndex = 11;
            this.Description_News.Text = "Содержание новости (новость не должна превышать один абзац)";
            // 
            // Help_To_Redact
            // 
            this.Help_To_Redact.AutoSize = true;
            this.Help_To_Redact.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Help_To_Redact.Location = new System.Drawing.Point(12, 86);
            this.Help_To_Redact.Name = "Help_To_Redact";
            this.Help_To_Redact.Size = new System.Drawing.Size(235, 90);
            this.Help_To_Redact.TabIndex = 13;
            this.Help_To_Redact.Text = "У вас есть сохранённые \nновости. Хотите их \nотредактировать?";
            this.Help_To_Redact.Visible = false;
            // 
            // Savebutton
            // 
            this.Savebutton.Font = new System.Drawing.Font("Segoe Print", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Savebutton.Location = new System.Drawing.Point(12, 705);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(776, 58);
            this.Savebutton.TabIndex = 14;
            this.Savebutton.Text = "Сохранить новость";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // ShowListNewsToAutorbutton
            // 
            this.ShowListNewsToAutorbutton.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowListNewsToAutorbutton.Location = new System.Drawing.Point(12, 179);
            this.ShowListNewsToAutorbutton.Name = "ShowListNewsToAutorbutton";
            this.ShowListNewsToAutorbutton.Size = new System.Drawing.Size(247, 44);
            this.ShowListNewsToAutorbutton.TabIndex = 15;
            this.ShowListNewsToAutorbutton.Text = "Показать список";
            this.ShowListNewsToAutorbutton.UseVisualStyleBackColor = true;
            this.ShowListNewsToAutorbutton.Visible = false;
            this.ShowListNewsToAutorbutton.Click += new System.EventHandler(this.ShowListNewsToAutorbutton_Click);
            // 
            // ShowTheNewsbutton
            // 
            this.ShowTheNewsbutton.Font = new System.Drawing.Font("Segoe Print", 12.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ShowTheNewsbutton.Location = new System.Drawing.Point(281, 192);
            this.ShowTheNewsbutton.Name = "ShowTheNewsbutton";
            this.ShowTheNewsbutton.Size = new System.Drawing.Size(507, 46);
            this.ShowTheNewsbutton.TabIndex = 16;
            this.ShowTheNewsbutton.Text = "Показать новость";
            this.ShowTheNewsbutton.UseVisualStyleBackColor = true;
            this.ShowTheNewsbutton.Visible = false;
            this.ShowTheNewsbutton.Click += new System.EventHandler(this.ShowTheNewsbutton_Click);
            // 
            // List_News_To_Autor
            // 
            this.List_News_To_Autor.FormattingEnabled = true;
            this.List_News_To_Autor.ItemHeight = 16;
            this.List_News_To_Autor.Location = new System.Drawing.Point(281, 86);
            this.List_News_To_Autor.Name = "List_News_To_Autor";
            this.List_News_To_Autor.Size = new System.Drawing.Size(507, 100);
            this.List_News_To_Autor.TabIndex = 17;
            this.List_News_To_Autor.Visible = false;
            // 
            // Title_Window
            // 
            this.Title_Window.AutoSize = true;
            this.Title_Window.Font = new System.Drawing.Font("Segoe Print", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title_Window.Location = new System.Drawing.Point(12, 12);
            this.Title_Window.Name = "Title_Window";
            this.Title_Window.Size = new System.Drawing.Size(577, 65);
            this.Title_Window.TabIndex = 18;
            this.Title_Window.Text = "Режим добавления новостей";
            // 
            // NewsAddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.Title_Window);
            this.Controls.Add(this.List_News_To_Autor);
            this.Controls.Add(this.ShowTheNewsbutton);
            this.Controls.Add(this.ShowListNewsToAutorbutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.Help_To_Redact);
            this.Controls.Add(this.Description_News);
            this.Controls.Add(this.Title_News);
            this.Controls.Add(this.Title_Text);
            this.Controls.Add(this.Description_Text);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.Closebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewsAddingForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.TextBox Description_Text;
        private System.Windows.Forms.TextBox Title_Text;
        private System.Windows.Forms.Label Title_News;
        private System.Windows.Forms.Label Description_News;
        private System.Windows.Forms.Label Help_To_Redact;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button ShowListNewsToAutorbutton;
        private System.Windows.Forms.Button ShowTheNewsbutton;
        private System.Windows.Forms.ListBox List_News_To_Autor;
        private System.Windows.Forms.Label Title_Window;
    }
}