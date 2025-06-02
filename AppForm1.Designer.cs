namespace AcademicYearProject
{
    partial class AppForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm1));
            this.help_button = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Women = new System.Windows.Forms.Button();
            this.Men = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
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
            this.help_button.TabIndex = 8;
            this.help_button.Text = "?";
            this.help_button.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.button5.Location = new System.Drawing.Point(126, 22);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 26);
            this.button5.TabIndex = 10;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.button6.Location = new System.Drawing.Point(126, 53);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 31);
            this.button6.TabIndex = 11;
            this.button6.Text = "Указатель";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Women
            // 
            this.Women.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Women.BackColor = System.Drawing.Color.White;
            this.Women.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Women.BackgroundImage")));
            this.Women.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Women.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Women.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Women.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.Women.Location = new System.Drawing.Point(301, 250);
            this.Women.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Women.Name = "Women";
            this.Women.Size = new System.Drawing.Size(398, 151);
            this.Women.TabIndex = 12;
            this.Women.Text = "Женский";
            this.Women.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Women.UseVisualStyleBackColor = false;
            this.Women.Click += new System.EventHandler(this.Women_Click);
            // 
            // Men
            // 
            this.Men.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Men.BackColor = System.Drawing.Color.SeaShell;
            this.Men.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Men.BackgroundImage")));
            this.Men.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Men.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Men.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.Men.Location = new System.Drawing.Point(751, 250);
            this.Men.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Men.Name = "Men";
            this.Men.Size = new System.Drawing.Size(398, 151);
            this.Men.TabIndex = 13;
            this.Men.Text = "Мужской";
            this.Men.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Men.UseVisualStyleBackColor = false;
            this.Men.Click += new System.EventHandler(this.Men_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ForwardButton.BackColor = System.Drawing.Color.White;
            this.ForwardButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ForwardButton.BackgroundImage")));
            this.ForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ForwardButton.Location = new System.Drawing.Point(910, 563);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(226, 82);
            this.ForwardButton.TabIndex = 14;
            this.ForwardButton.UseVisualStyleBackColor = false;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Location = new System.Drawing.Point(301, 563);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(226, 82);
            this.BackButton.TabIndex = 15;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AgainButton
            // 
            this.AgainButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AgainButton.BackColor = System.Drawing.Color.White;
            this.AgainButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AgainButton.BackgroundImage")));
            this.AgainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AgainButton.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.AgainButton.Location = new System.Drawing.Point(610, 563);
            this.AgainButton.Name = "AgainButton";
            this.AgainButton.Size = new System.Drawing.Size(226, 82);
            this.AgainButton.TabIndex = 16;
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
            this.label1.Location = new System.Drawing.Point(301, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(848, 67);
            this.label1.TabIndex = 17;
            this.label1.Text = "Укажите, пожалуйста:\r\n1) Ваш пол";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AppForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1263, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgainButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.Men);
            this.Controls.Add(this.Women);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.help_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AppForm1";
            this.Text = "AppForm2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AppForm1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Women;
        private System.Windows.Forms.Button Men;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AgainButton;
        private System.Windows.Forms.Label label1;
    }
}