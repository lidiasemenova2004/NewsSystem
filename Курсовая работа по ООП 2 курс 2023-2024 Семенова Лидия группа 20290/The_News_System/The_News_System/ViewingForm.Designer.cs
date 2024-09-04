namespace TheNewsSystem
{
    partial class ViewingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewingForm));
            this.Closebutton = new System.Windows.Forms.Button();
            this.Title_Window = new System.Windows.Forms.Label();
            this.Choice_Date_label = new System.Windows.Forms.Label();
            this.List_News = new System.Windows.Forms.ListBox();
            this.Choice_Date = new System.Windows.Forms.DateTimePicker();
            this.ShowTheListNewsbutton = new System.Windows.Forms.Button();
            this.Choice_Type_Search = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Label();
            this.Type_Search = new System.Windows.Forms.Label();
            this.Input_Info = new System.Windows.Forms.Label();
            this.Search_Informations = new System.Windows.Forms.TextBox();
            this.ShowTheNewsDescrbutton = new System.Windows.Forms.Button();
            this.Description_News = new System.Windows.Forms.TextBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.AddedVoiseForNewsbutton = new System.Windows.Forms.Button();
            this.TopNewsbutton = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Closebutton
            // 
            this.Closebutton.Image = ((System.Drawing.Image)(resources.GetObject("Closebutton.Image")));
            this.Closebutton.Location = new System.Drawing.Point(735, 12);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(53, 49);
            this.Closebutton.TabIndex = 1;
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // Title_Window
            // 
            this.Title_Window.AutoSize = true;
            this.Title_Window.Font = new System.Drawing.Font("Segoe Print", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title_Window.Location = new System.Drawing.Point(12, 9);
            this.Title_Window.Name = "Title_Window";
            this.Title_Window.Size = new System.Drawing.Size(595, 65);
            this.Title_Window.TabIndex = 2;
            this.Title_Window.Text = "Режим просмотра новостей";
            // 
            // Choice_Date_label
            // 
            this.Choice_Date_label.AutoSize = true;
            this.Choice_Date_label.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Choice_Date_label.Location = new System.Drawing.Point(7, 70);
            this.Choice_Date_label.Name = "Choice_Date_label";
            this.Choice_Date_label.Size = new System.Drawing.Size(162, 30);
            this.Choice_Date_label.TabIndex = 4;
            this.Choice_Date_label.Text = "Выберите дату:";
            // 
            // List_News
            // 
            this.List_News.FormattingEnabled = true;
            this.List_News.HorizontalScrollbar = true;
            this.List_News.ItemHeight = 16;
            this.List_News.Location = new System.Drawing.Point(12, 209);
            this.List_News.Name = "List_News";
            this.List_News.Size = new System.Drawing.Size(770, 196);
            this.List_News.TabIndex = 5;
            // 
            // Choice_Date
            // 
            this.Choice_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Choice_Date.Location = new System.Drawing.Point(12, 110);
            this.Choice_Date.Name = "Choice_Date";
            this.Choice_Date.Size = new System.Drawing.Size(200, 22);
            this.Choice_Date.TabIndex = 6;
            // 
            // ShowTheListNewsbutton
            // 
            this.ShowTheListNewsbutton.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowTheListNewsbutton.Location = new System.Drawing.Point(12, 138);
            this.ShowTheListNewsbutton.Name = "ShowTheListNewsbutton";
            this.ShowTheListNewsbutton.Size = new System.Drawing.Size(200, 65);
            this.ShowTheListNewsbutton.TabIndex = 7;
            this.ShowTheListNewsbutton.Text = "Показать новости";
            this.ShowTheListNewsbutton.UseVisualStyleBackColor = true;
            this.ShowTheListNewsbutton.Click += new System.EventHandler(this.ShowTheListNewsbutton_Click);
            // 
            // Choice_Type_Search
            // 
            this.Choice_Type_Search.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Choice_Type_Search.FormattingEnabled = true;
            this.Choice_Type_Search.Location = new System.Drawing.Point(471, 95);
            this.Choice_Type_Search.Name = "Choice_Type_Search";
            this.Choice_Type_Search.Size = new System.Drawing.Size(222, 31);
            this.Choice_Type_Search.TabIndex = 8;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(243, 70);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(70, 30);
            this.Search.TabIndex = 9;
            this.Search.Text = "Поиск:";
            // 
            // Type_Search
            // 
            this.Type_Search.AutoSize = true;
            this.Type_Search.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type_Search.Location = new System.Drawing.Point(243, 96);
            this.Type_Search.Name = "Type_Search";
            this.Type_Search.Size = new System.Drawing.Size(221, 30);
            this.Type_Search.TabIndex = 10;
            this.Type_Search.Text = "Выберите тип поиска:";
            // 
            // Input_Info
            // 
            this.Input_Info.AutoSize = true;
            this.Input_Info.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input_Info.Location = new System.Drawing.Point(243, 126);
            this.Input_Info.Name = "Input_Info";
            this.Input_Info.Size = new System.Drawing.Size(217, 30);
            this.Input_Info.TabIndex = 11;
            this.Input_Info.Text = "Введите информацию:";
            // 
            // Search_Informations
            // 
            this.Search_Informations.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_Informations.Location = new System.Drawing.Point(471, 126);
            this.Search_Informations.Name = "Search_Informations";
            this.Search_Informations.Size = new System.Drawing.Size(311, 30);
            this.Search_Informations.TabIndex = 12;
            // 
            // ShowTheNewsDescrbutton
            // 
            this.ShowTheNewsDescrbutton.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ShowTheNewsDescrbutton.Location = new System.Drawing.Point(12, 411);
            this.ShowTheNewsDescrbutton.Name = "ShowTheNewsDescrbutton";
            this.ShowTheNewsDescrbutton.Size = new System.Drawing.Size(254, 83);
            this.ShowTheNewsDescrbutton.TabIndex = 13;
            this.ShowTheNewsDescrbutton.Text = "Показать содержание статьи";
            this.ShowTheNewsDescrbutton.UseVisualStyleBackColor = true;
            this.ShowTheNewsDescrbutton.Click += new System.EventHandler(this.ShowTheNewsDescrbutton_Click);
            // 
            // Description_News
            // 
            this.Description_News.Location = new System.Drawing.Point(12, 500);
            this.Description_News.Multiline = true;
            this.Description_News.Name = "Description_News";
            this.Description_News.ReadOnly = true;
            this.Description_News.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Description_News.Size = new System.Drawing.Size(770, 288);
            this.Description_News.TabIndex = 0;
            // 
            // Searchbutton
            // 
            this.Searchbutton.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Searchbutton.Location = new System.Drawing.Point(303, 163);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(479, 40);
            this.Searchbutton.TabIndex = 14;
            this.Searchbutton.Text = "Поиск";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // AddedVoiseForNewsbutton
            // 
            this.AddedVoiseForNewsbutton.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddedVoiseForNewsbutton.Location = new System.Drawing.Point(532, 411);
            this.AddedVoiseForNewsbutton.Name = "AddedVoiseForNewsbutton";
            this.AddedVoiseForNewsbutton.Size = new System.Drawing.Size(250, 83);
            this.AddedVoiseForNewsbutton.TabIndex = 15;
            this.AddedVoiseForNewsbutton.Text = "Проголосовать за статью";
            this.AddedVoiseForNewsbutton.UseVisualStyleBackColor = true;
            this.AddedVoiseForNewsbutton.Click += new System.EventHandler(this.AddedVoiseForNewsbutton_Click);
            // 
            // TopNewsbutton
            // 
            this.TopNewsbutton.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TopNewsbutton.Location = new System.Drawing.Point(272, 411);
            this.TopNewsbutton.Name = "TopNewsbutton";
            this.TopNewsbutton.Size = new System.Drawing.Size(254, 83);
            this.TopNewsbutton.TabIndex = 16;
            this.TopNewsbutton.Text = "Показать самые популярные статьи";
            this.TopNewsbutton.UseVisualStyleBackColor = true;
            this.TopNewsbutton.Click += new System.EventHandler(this.TopNewsbutton_Click);
            // 
            // Resetbutton
            // 
            this.Resetbutton.Image = ((System.Drawing.Image)(resources.GetObject("Resetbutton.Image")));
            this.Resetbutton.Location = new System.Drawing.Point(652, 12);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(77, 62);
            this.Resetbutton.TabIndex = 17;
            this.Resetbutton.UseVisualStyleBackColor = true;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // ViewingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.TopNewsbutton);
            this.Controls.Add(this.AddedVoiseForNewsbutton);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.Description_News);
            this.Controls.Add(this.ShowTheNewsDescrbutton);
            this.Controls.Add(this.Search_Informations);
            this.Controls.Add(this.Input_Info);
            this.Controls.Add(this.Type_Search);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Choice_Type_Search);
            this.Controls.Add(this.ShowTheListNewsbutton);
            this.Controls.Add(this.Choice_Date);
            this.Controls.Add(this.List_News);
            this.Controls.Add(this.Choice_Date_label);
            this.Controls.Add(this.Title_Window);
            this.Controls.Add(this.Closebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viewing_Mode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.Label Title_Window;
        private System.Windows.Forms.Label Choice_Date_label;
        private System.Windows.Forms.ListBox List_News;
        private System.Windows.Forms.DateTimePicker Choice_Date;
        private System.Windows.Forms.Button ShowTheListNewsbutton;
        private System.Windows.Forms.ComboBox Choice_Type_Search;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Label Type_Search;
        private System.Windows.Forms.Label Input_Info;
        private System.Windows.Forms.TextBox Search_Informations;
        private System.Windows.Forms.Button ShowTheNewsDescrbutton;
        private System.Windows.Forms.TextBox Description_News;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Button AddedVoiseForNewsbutton;
        private System.Windows.Forms.Button TopNewsbutton;
        private System.Windows.Forms.Button Resetbutton;
    }
}