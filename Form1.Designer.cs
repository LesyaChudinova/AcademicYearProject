namespace AcademicYearProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GreetingTextBox = new System.Windows.Forms.TextBox();
            this.help_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.GreetingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GreetingTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.GreetingTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.GreetingTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            helpProvider1.SetHelpKeyword(this.GreetingTextBox, "13");
            helpProvider1.SetHelpNavigator(this.GreetingTextBox, System.Windows.Forms.HelpNavigator.TopicId);
            this.GreetingTextBox.Location = new System.Drawing.Point(71, 243);
            this.GreetingTextBox.Multiline = true;
            this.GreetingTextBox.Name = "GreetingTextBox";
            this.GreetingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            helpProvider1.SetShowHelp(this.GreetingTextBox, true);
            this.GreetingTextBox.Size = new System.Drawing.Size(1110, 150);
            this.GreetingTextBox.TabIndex = 1;
            this.GreetingTextBox.Text = resources.GetString("GreetingTextBox.Text");
            this.GreetingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GreetingTextBox.TextChanged += new System.EventHandler(this.GreetingTextBox_TextChanged);
            // 
            // help_button
            // 
            this.help_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.help_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.help_button.ForeColor = System.Drawing.SystemColors.GrayText;
            this.help_button.Location = new System.Drawing.Point(42, 26);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(77, 79);
            this.help_button.TabIndex = 0;
            this.help_button.Text = "?";
            this.help_button.UseVisualStyleBackColor = false;
            this.help_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.button2.Location = new System.Drawing.Point(142, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Указатель";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.button3.Location = new System.Drawing.Point(466, 498);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(332, 71);
            this.button3.TabIndex = 4;
            this.button3.Text = "Поехали!";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.button4.Location = new System.Drawing.Point(142, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 32);
            this.button4.TabIndex = 5;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1233, 751);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GreetingTextBox);
            this.Controls.Add(this.help_button);
            helpProvider1.SetHelpKeyword(this, "Аннотация");
            helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Find);
            this.Name = "Form1";
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

