namespace AcademicYearProject
{
    partial class StartScreen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.HelpProvider helpProvider1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.GreetingTextBox = new System.Windows.Forms.TextBox();
            this.help_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GoButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "Help.chm";
            // 
            // GreetingTextBox
            // 
            this.GreetingTextBox.AcceptsTab = true;
            this.GreetingTextBox.BackColor = System.Drawing.Color.White;
            this.GreetingTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.GreetingTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            helpProvider1.SetHelpKeyword(this.GreetingTextBox, "13");
            helpProvider1.SetHelpNavigator(this.GreetingTextBox, System.Windows.Forms.HelpNavigator.TopicId);
            this.GreetingTextBox.Location = new System.Drawing.Point(56, 189);
            this.GreetingTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GreetingTextBox.Multiline = true;
            this.GreetingTextBox.Name = "GreetingTextBox";
            this.GreetingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            helpProvider1.SetShowHelp(this.GreetingTextBox, true);
            this.GreetingTextBox.Size = new System.Drawing.Size(1030, 121);
            this.GreetingTextBox.TabIndex = 1;
            this.GreetingTextBox.Text = resources.GetString("GreetingTextBox.Text");
            this.GreetingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GreetingTextBox.TextChanged += new System.EventHandler(this.GreetingTextBox_TextChanged);
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
            this.help_button.TabIndex = 0;
            this.help_button.Text = "?";
            this.help_button.UseVisualStyleBackColor = false;
            this.help_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.button2.Location = new System.Drawing.Point(126, 53);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Указатель";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GoButton
            // 
            this.GoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GoButton.BackColor = System.Drawing.Color.White;
            this.GoButton.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.GoButton.Location = new System.Drawing.Point(459, 360);
            this.GoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(272, 63);
            this.GoButton.TabIndex = 4;
            this.GoButton.Text = "Поехали!";
            this.GoButton.UseVisualStyleBackColor = false;
            this.GoButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.button4.Location = new System.Drawing.Point(126, 22);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 26);
            this.button4.TabIndex = 5;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1124, 544);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GreetingTextBox);
            this.Controls.Add(this.help_button);
            helpProvider1.SetHelpKeyword(this, "Аннотация");
            helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Find);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StartScreen";
            helpProvider1.SetShowHelp(this, true);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.TextBox GreetingTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button button4;
    }
}

