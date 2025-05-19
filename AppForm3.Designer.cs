namespace AcademicYearProject
{
    partial class AppForm3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm3));
            this.GreetingTextBox = new System.Windows.Forms.TextBox();
            this.SnowButton = new System.Windows.Forms.Button();
            this.RainButton = new System.Windows.Forms.Button();
            this.SunnyButton = new System.Windows.Forms.Button();
            this.WindyButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.help_button = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GreetingTextBox
            // 
            this.GreetingTextBox.AcceptsTab = true;
            this.GreetingTextBox.BackColor = System.Drawing.Color.White;
            this.GreetingTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.GreetingTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.helpProvider1.SetHelpKeyword(this.GreetingTextBox, "45");
            this.helpProvider1.SetHelpNavigator(this.GreetingTextBox, System.Windows.Forms.HelpNavigator.TopicId);
            this.GreetingTextBox.Location = new System.Drawing.Point(255, 22);
            this.GreetingTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GreetingTextBox.Multiline = true;
            this.GreetingTextBox.Name = "GreetingTextBox";
            this.GreetingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.helpProvider1.SetShowHelp(this.GreetingTextBox, true);
            this.GreetingTextBox.Size = new System.Drawing.Size(848, 67);
            this.GreetingTextBox.TabIndex = 2;
            this.GreetingTextBox.Text = "Ответьте, пожалуйста, на вопросы: \r\n3) Какая сегодня погода?";
            this.GreetingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GreetingTextBox.TextChanged += new System.EventHandler(this.GreetingTextBox_TextChanged);
            // 
            // SnowButton
            // 
            this.SnowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SnowButton.BackgroundImage")));
            this.SnowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SnowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SnowButton.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.helpProvider1.SetHelpKeyword(this.SnowButton, "45");
            this.helpProvider1.SetHelpNavigator(this.SnowButton, System.Windows.Forms.HelpNavigator.TopicId);
            this.SnowButton.Location = new System.Drawing.Point(255, 146);
            this.SnowButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SnowButton.Name = "SnowButton";
            this.helpProvider1.SetShowHelp(this.SnowButton, true);
            this.SnowButton.Size = new System.Drawing.Size(398, 151);
            this.SnowButton.TabIndex = 3;
            this.SnowButton.Text = "Снежно";
            this.SnowButton.UseVisualStyleBackColor = true;
            this.SnowButton.Click += new System.EventHandler(this.SnowButton_Click);
            // 
            // RainButton
            // 
            this.RainButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RainButton.BackgroundImage")));
            this.RainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RainButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RainButton.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.RainButton.ForeColor = System.Drawing.Color.White;
            this.helpProvider1.SetHelpKeyword(this.RainButton, "анкеты");
            this.RainButton.Location = new System.Drawing.Point(705, 146);
            this.RainButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RainButton.Name = "RainButton";
            this.helpProvider1.SetShowHelp(this.RainButton, true);
            this.RainButton.Size = new System.Drawing.Size(398, 151);
            this.RainButton.TabIndex = 4;
            this.RainButton.Text = "Дождливо";
            this.RainButton.UseVisualStyleBackColor = true;
            this.RainButton.Click += new System.EventHandler(this.RainButton_Click);
            // 
            // SunnyButton
            // 
            this.SunnyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SunnyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SunnyButton.BackgroundImage")));
            this.SunnyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SunnyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SunnyButton.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.SunnyButton.ForeColor = System.Drawing.Color.Black;
            this.helpProvider1.SetHelpKeyword(this.SunnyButton, "анкеты");
            this.SunnyButton.Location = new System.Drawing.Point(255, 361);
            this.SunnyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SunnyButton.Name = "SunnyButton";
            this.helpProvider1.SetShowHelp(this.SunnyButton, true);
            this.SunnyButton.Size = new System.Drawing.Size(398, 151);
            this.SunnyButton.TabIndex = 5;
            this.SunnyButton.Text = "Солнечно";
            this.SunnyButton.UseVisualStyleBackColor = false;
            this.SunnyButton.Click += new System.EventHandler(this.SunnyButton_Click);
            // 
            // WindyButton
            // 
            this.WindyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WindyButton.BackgroundImage")));
            this.WindyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WindyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WindyButton.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.WindyButton.ForeColor = System.Drawing.Color.White;
            this.helpProvider1.SetHelpKeyword(this.WindyButton, "анкеты");
            this.helpProvider1.SetHelpNavigator(this.WindyButton, System.Windows.Forms.HelpNavigator.TopicId);
            this.WindyButton.Location = new System.Drawing.Point(705, 361);
            this.WindyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WindyButton.Name = "WindyButton";
            this.helpProvider1.SetShowHelp(this.WindyButton, true);
            this.WindyButton.Size = new System.Drawing.Size(398, 151);
            this.WindyButton.TabIndex = 6;
            this.WindyButton.Text = "Ветренно";
            this.WindyButton.UseVisualStyleBackColor = true;
            this.WindyButton.Click += new System.EventHandler(this.WindyButton_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Help.chm";
            // 
            // help_button
            // 
            this.help_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.help_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.help_button.ForeColor = System.Drawing.Color.Black;
            this.help_button.Location = new System.Drawing.Point(37, 21);
            this.help_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(68, 63);
            this.help_button.TabIndex = 7;
            this.help_button.Text = "?";
            this.help_button.UseVisualStyleBackColor = false;
            this.help_button.Click += new System.EventHandler(this.help_button_Click_1);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.button5.Location = new System.Drawing.Point(126, 22);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 26);
            this.button5.TabIndex = 9;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.button6.Location = new System.Drawing.Point(126, 53);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 31);
            this.button6.TabIndex = 8;
            this.button6.Text = "Указатель";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // AppForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1249, 665);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.WindyButton);
            this.Controls.Add(this.SunnyButton);
            this.Controls.Add(this.RainButton);
            this.Controls.Add(this.SnowButton);
            this.Controls.Add(this.GreetingTextBox);
            this.helpProvider1.SetHelpKeyword(this, "45");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AppForm3";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AppForm4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox GreetingTextBox;
        private System.Windows.Forms.Button SnowButton;
        private System.Windows.Forms.Button RainButton;
        private System.Windows.Forms.Button SunnyButton;
        private System.Windows.Forms.Button WindyButton;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}