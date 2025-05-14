namespace AcademicYearProject
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label1 = new System.Windows.Forms.Label();
            this.GreetingTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.help_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpProvider1.SetHelpKeyword(this.pictureBox1, "Результат");
            this.helpProvider1.SetHelpNavigator(this.pictureBox1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(780, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.helpProvider1.SetShowHelp(this.pictureBox1, true);
            this.pictureBox1.Size = new System.Drawing.Size(407, 672);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.label1.Location = new System.Drawing.Point(66, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GreetingTextBox
            // 
            this.GreetingTextBox.AcceptsTab = true;
            this.GreetingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GreetingTextBox.BackColor = System.Drawing.Color.White;
            this.GreetingTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.GreetingTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.helpProvider1.SetHelpKeyword(this.GreetingTextBox, "Возможности");
            this.helpProvider1.SetHelpNavigator(this.GreetingTextBox, System.Windows.Forms.HelpNavigator.Find);
            this.GreetingTextBox.Location = new System.Drawing.Point(42, 146);
            this.GreetingTextBox.Multiline = true;
            this.GreetingTextBox.Name = "GreetingTextBox";
            this.GreetingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.helpProvider1.SetShowHelp(this.GreetingTextBox, true);
            this.GreetingTextBox.Size = new System.Drawing.Size(692, 215);
            this.GreetingTextBox.TabIndex = 3;
            this.GreetingTextBox.Text = resources.GetString("GreetingTextBox.Text");
            this.GreetingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.helpProvider1.SetHelpKeyword(this.textBox1, "21");
            this.helpProvider1.SetHelpNavigator(this.textBox1, System.Windows.Forms.HelpNavigator.TopicId);
            this.textBox1.Location = new System.Drawing.Point(42, 578);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.helpProvider1.SetShowHelp(this.textBox1, true);
            this.textBox1.Size = new System.Drawing.Size(692, 48);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Не знаете, как стилизовать?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLabel1.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.helpProvider1.SetHelpKeyword(this.linkLabel1, "21");
            this.helpProvider1.SetHelpNavigator(this.linkLabel1, System.Windows.Forms.HelpNavigator.TopicId);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(179, 667);
            this.linkLabel1.Name = "linkLabel1";
            this.helpProvider1.SetShowHelp(this.linkLabel1, true);
            this.linkLabel1.Size = new System.Drawing.Size(414, 33);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Посмотреть больше референсов!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBox2
            // 
            this.textBox2.AcceptsTab = true;
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.helpProvider1.SetHelpKeyword(this.textBox2, "Содержание");
            this.helpProvider1.SetHelpNavigator(this.textBox2, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.textBox2.Location = new System.Drawing.Point(313, 28);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.helpProvider1.SetShowHelp(this.textBox2, true);
            this.textBox2.Size = new System.Drawing.Size(421, 48);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Спасибо за ответы!";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.button5.Location = new System.Drawing.Point(142, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 32);
            this.button5.TabIndex = 12;
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
            this.button6.TabIndex = 11;
            this.button6.Text = "Указатель";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // help_button
            // 
            this.help_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.help_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.help_button.ForeColor = System.Drawing.SystemColors.GrayText;
            this.help_button.Location = new System.Drawing.Point(42, 26);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(77, 79);
            this.help_button.TabIndex = 10;
            this.help_button.Text = "?";
            this.help_button.UseVisualStyleBackColor = false;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1251, 746);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GreetingTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.helpProvider1.SetHelpKeyword(this, "Содержание");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Name = "Form3";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GreetingTextBox;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button help_button;
    }
}