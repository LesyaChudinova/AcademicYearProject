namespace AcademicYearProject
{
    partial class AppForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm2));
            this.help_button = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.TeenagersButton = new System.Windows.Forms.Button();
            this.YoungstersButton = new System.Windows.Forms.Button();
            this.AdultsButton = new System.Windows.Forms.Button();
            this.OlderButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.AgainButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.help_button.TabIndex = 9;
            this.help_button.Text = "?";
            this.help_button.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(126, 22);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 26);
            this.button5.TabIndex = 11;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(126, 53);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 31);
            this.button6.TabIndex = 12;
            this.button6.Text = "Указатель";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // TeenagersButton
            // 
            this.TeenagersButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TeenagersButton.BackColor = System.Drawing.Color.White;
            this.TeenagersButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TeenagersButton.BackgroundImage")));
            this.TeenagersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TeenagersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TeenagersButton.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.TeenagersButton.Location = new System.Drawing.Point(255, 146);
            this.TeenagersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeenagersButton.Name = "TeenagersButton";
            this.TeenagersButton.Size = new System.Drawing.Size(398, 151);
            this.TeenagersButton.TabIndex = 13;
            this.TeenagersButton.Text = "до 16 лет";
            this.TeenagersButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TeenagersButton.UseVisualStyleBackColor = false;
            this.TeenagersButton.Click += new System.EventHandler(this.TeenagersButton_Click);
            // 
            // YoungstersButton
            // 
            this.YoungstersButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YoungstersButton.BackColor = System.Drawing.Color.White;
            this.YoungstersButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("YoungstersButton.BackgroundImage")));
            this.YoungstersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.YoungstersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YoungstersButton.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.YoungstersButton.ForeColor = System.Drawing.Color.Black;
            this.YoungstersButton.Location = new System.Drawing.Point(705, 146);
            this.YoungstersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YoungstersButton.Name = "YoungstersButton";
            this.YoungstersButton.Size = new System.Drawing.Size(398, 151);
            this.YoungstersButton.TabIndex = 14;
            this.YoungstersButton.Text = "17 - 25 лет";
            this.YoungstersButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.YoungstersButton.UseVisualStyleBackColor = false;
            this.YoungstersButton.Click += new System.EventHandler(this.YoungstearsButton_Click);
            // 
            // AdultsButton
            // 
            this.AdultsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdultsButton.BackColor = System.Drawing.Color.White;
            this.AdultsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdultsButton.BackgroundImage")));
            this.AdultsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AdultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdultsButton.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.AdultsButton.ForeColor = System.Drawing.Color.Black;
            this.AdultsButton.Location = new System.Drawing.Point(255, 361);
            this.AdultsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdultsButton.Name = "AdultsButton";
            this.AdultsButton.Size = new System.Drawing.Size(398, 151);
            this.AdultsButton.TabIndex = 15;
            this.AdultsButton.Text = "26 - 50 лет";
            this.AdultsButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.AdultsButton.UseVisualStyleBackColor = false;
            this.AdultsButton.Click += new System.EventHandler(this.AdultsButton_Click);
            // 
            // OlderButton
            // 
            this.OlderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OlderButton.BackColor = System.Drawing.Color.White;
            this.OlderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OlderButton.BackgroundImage")));
            this.OlderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OlderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OlderButton.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.OlderButton.ForeColor = System.Drawing.Color.Black;
            this.OlderButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.OlderButton.Location = new System.Drawing.Point(705, 361);
            this.OlderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OlderButton.Name = "OlderButton";
            this.OlderButton.Size = new System.Drawing.Size(398, 151);
            this.OlderButton.TabIndex = 16;
            this.OlderButton.Text = "больше 50 лет";
            this.OlderButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.OlderButton.UseVisualStyleBackColor = false;
            this.OlderButton.Click += new System.EventHandler(this.OlderButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Location = new System.Drawing.Point(255, 563);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(226, 82);
            this.BackButton.TabIndex = 17;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ForwardButton.BackColor = System.Drawing.Color.White;
            this.ForwardButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ForwardButton.BackgroundImage")));
            this.ForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ForwardButton.Location = new System.Drawing.Point(864, 563);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(226, 82);
            this.ForwardButton.TabIndex = 18;
            this.ForwardButton.UseVisualStyleBackColor = false;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // AgainButton
            // 
            this.AgainButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AgainButton.BackColor = System.Drawing.Color.White;
            this.AgainButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AgainButton.BackgroundImage")));
            this.AgainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AgainButton.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.AgainButton.Location = new System.Drawing.Point(564, 563);
            this.AgainButton.Name = "AgainButton";
            this.AgainButton.Size = new System.Drawing.Size(226, 82);
            this.AgainButton.TabIndex = 19;
            this.AgainButton.Text = "Пройти заново";
            this.AgainButton.UseVisualStyleBackColor = false;
            this.AgainButton.Click += new System.EventHandler(this.AgainButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(264, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(848, 67);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ответьте, пожалуйста, на вопрос:\r\n2) Ваш возраст";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1132, 687);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgainButton);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OlderButton);
            this.Controls.Add(this.AdultsButton);
            this.Controls.Add(this.YoungstersButton);
            this.Controls.Add(this.TeenagersButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.help_button);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AppForm2";
            this.Text = "AppForm3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AppForm2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button TeenagersButton;
        private System.Windows.Forms.Button YoungstersButton;
        private System.Windows.Forms.Button AdultsButton;
        private System.Windows.Forms.Button OlderButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button AgainButton;
        private System.Windows.Forms.Label label1;
    }
}