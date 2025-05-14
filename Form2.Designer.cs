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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.GreetingTextBox = new System.Windows.Forms.TextBox();
            this.Снежно = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Ветренно = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.help_button = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GreetingTextBox
            // 
            this.GreetingTextBox.AcceptsTab = true;
            this.GreetingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GreetingTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GreetingTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.GreetingTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.helpProvider1.SetHelpKeyword(this.GreetingTextBox, "Содержание");
            this.helpProvider1.SetHelpNavigator(this.GreetingTextBox, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.GreetingTextBox.Location = new System.Drawing.Point(287, 26);
            this.GreetingTextBox.Multiline = true;
            this.GreetingTextBox.Name = "GreetingTextBox";
            this.GreetingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.helpProvider1.SetShowHelp(this.GreetingTextBox, true);
            this.GreetingTextBox.Size = new System.Drawing.Size(939, 79);
            this.GreetingTextBox.TabIndex = 2;
            this.GreetingTextBox.Text = "Ответьте, пожалуйста, на вопросы: \r\n1) Какая сегодня погода?";
            this.GreetingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GreetingTextBox.TextChanged += new System.EventHandler(this.GreetingTextBox_TextChanged);
            // 
            // Снежно
            // 
            this.Снежно.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Снежно.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.helpProvider1.SetHelpKeyword(this.Снежно, "вопросы");
            this.Снежно.Location = new System.Drawing.Point(287, 182);
            this.Снежно.Name = "Снежно";
            this.helpProvider1.SetShowHelp(this.Снежно, true);
            this.Снежно.Size = new System.Drawing.Size(448, 189);
            this.Снежно.TabIndex = 3;
            this.Снежно.Text = "Снежно";
            this.Снежно.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.helpProvider1.SetHelpKeyword(this.button2, "вопросы");
            this.button2.Location = new System.Drawing.Point(793, 182);
            this.button2.Name = "button2";
            this.helpProvider1.SetShowHelp(this.button2, true);
            this.button2.Size = new System.Drawing.Size(433, 189);
            this.button2.TabIndex = 4;
            this.button2.Text = "Дождливо";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.helpProvider1.SetHelpKeyword(this.button3, "вопросы");
            this.button3.Location = new System.Drawing.Point(287, 451);
            this.button3.Name = "button3";
            this.helpProvider1.SetShowHelp(this.button3, true);
            this.button3.Size = new System.Drawing.Size(448, 189);
            this.button3.TabIndex = 5;
            this.button3.Text = "Солнечно";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Ветренно
            // 
            this.Ветренно.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.helpProvider1.SetHelpKeyword(this.Ветренно, "вопросы");
            this.Ветренно.Location = new System.Drawing.Point(793, 451);
            this.Ветренно.Name = "Ветренно";
            this.helpProvider1.SetShowHelp(this.Ветренно, true);
            this.Ветренно.Size = new System.Drawing.Size(433, 189);
            this.Ветренно.TabIndex = 6;
            this.Ветренно.Text = "Ветренно";
            this.Ветренно.UseVisualStyleBackColor = true;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Help.chm";
            // 
            // help_button
            // 
            this.help_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.help_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.help_button.ForeColor = System.Drawing.SystemColors.GrayText;
            this.help_button.Location = new System.Drawing.Point(42, 26);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(77, 79);
            this.help_button.TabIndex = 7;
            this.help_button.Text = "?";
            this.help_button.UseVisualStyleBackColor = false;
            this.help_button.Click += new System.EventHandler(this.help_button_Click_1);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.button5.Location = new System.Drawing.Point(144, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 32);
            this.button5.TabIndex = 9;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.button6.Location = new System.Drawing.Point(142, 66);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 39);
            this.button6.TabIndex = 8;
            this.button6.Text = "Указатель";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1260, 805);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.Ветренно);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Снежно);
            this.Controls.Add(this.GreetingTextBox);
            this.helpProvider1.SetHelpKeyword(this, "Описание возможностей");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "Form2";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox GreetingTextBox;
        private System.Windows.Forms.Button Снежно;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Ветренно;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}