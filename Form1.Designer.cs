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
            this.help_button = new System.Windows.Forms.Button();
            this.GreetingTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // help_button
            // 
            this.help_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            this.GreetingTextBox.Location = new System.Drawing.Point(71, 233);
            this.GreetingTextBox.Multiline = true;
            this.GreetingTextBox.Name = "GreetingTextBox";
            this.GreetingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            helpProvider1.SetShowHelp(this.GreetingTextBox, true);
            this.GreetingTextBox.Size = new System.Drawing.Size(1078, 150);
            this.GreetingTextBox.TabIndex = 1;
            this.GreetingTextBox.Text = resources.GetString("GreetingTextBox.Text");
            this.GreetingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GreetingTextBox.TextChanged += new System.EventHandler(this.GreetingTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.button1.Location = new System.Drawing.Point(450, 850);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1078, 90);
            this.button1.TabIndex = 2;
            this.button1.Text = "Поехали!";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 730);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GreetingTextBox);
            this.Controls.Add(this.help_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.TextBox GreetingTextBox;
        private System.Windows.Forms.Button button1;
    }
}

