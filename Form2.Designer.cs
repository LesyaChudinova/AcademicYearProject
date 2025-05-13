namespace AcademicYearProject
{
    partial class Form2
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
            this.help_button = new System.Windows.Forms.Button();
            this.GreetingTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
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
            this.help_button.TabIndex = 1;
            this.help_button.Text = "?";
            this.help_button.UseVisualStyleBackColor = false;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // GreetingTextBox
            // 
            this.GreetingTextBox.AcceptsTab = true;
            this.GreetingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GreetingTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.GreetingTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.GreetingTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GreetingTextBox.Location = new System.Drawing.Point(148, 26);
            this.GreetingTextBox.Multiline = true;
            this.GreetingTextBox.Name = "GreetingTextBox";
            this.GreetingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.GreetingTextBox.Size = new System.Drawing.Size(1078, 79);
            this.GreetingTextBox.TabIndex = 2;
            this.GreetingTextBox.Text = "Ответьте, пожалуйста, на вопросы: \r\n1) Какая сегодня погода?";
            this.GreetingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GreetingTextBox.TextChanged += new System.EventHandler(this.GreetingTextBox_TextChanged);
            // 
            // button1
            // 
            this.helpProvider1.SetHelpKeyword(this.button1, "21");
            this.helpProvider1.SetHelpNavigator(this.button1, System.Windows.Forms.HelpNavigator.TopicId);
            this.button1.Location = new System.Drawing.Point(148, 182);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(521, 189);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(705, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(521, 189);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(521, 189);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(705, 451);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(521, 189);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Help.chm";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 805);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GreetingTextBox);
            this.Controls.Add(this.help_button);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.TextBox GreetingTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}