﻿namespace AcademicYearProject
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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // help_button
            // 
            this.help_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.help_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.help_button.ForeColor = System.Drawing.Color.Black;
            this.help_button.Location = new System.Drawing.Point(42, 26);
            this.help_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(76, 79);
            this.help_button.TabIndex = 9;
            this.help_button.Text = "?";
            this.help_button.UseVisualStyleBackColor = false;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(142, 26);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 32);
            this.button5.TabIndex = 11;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.helpProvider1.SetHelpKeyword(this.button6, "Аннотация");
            this.helpProvider1.SetHelpNavigator(this.button6, System.Windows.Forms.HelpNavigator.Find);
            this.button6.Location = new System.Drawing.Point(142, 66);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.helpProvider1.SetShowHelp(this.button6, true);
            this.button6.Size = new System.Drawing.Size(117, 39);
            this.button6.TabIndex = 12;
            this.button6.Text = "Указатель";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // TeenagersButton
            // 
            this.TeenagersButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TeenagersButton.BackColor = System.Drawing.Color.White;
            this.TeenagersButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TeenagersButton.BackgroundImage")));
            this.TeenagersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TeenagersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TeenagersButton.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.TeenagersButton.Location = new System.Drawing.Point(297, 150);
            this.TeenagersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeenagersButton.Name = "TeenagersButton";
            this.TeenagersButton.Size = new System.Drawing.Size(448, 189);
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
            this.YoungstersButton.Location = new System.Drawing.Point(803, 150);
            this.YoungstersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YoungstersButton.Name = "YoungstersButton";
            this.YoungstersButton.Size = new System.Drawing.Size(448, 189);
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
            this.AdultsButton.Location = new System.Drawing.Point(297, 412);
            this.AdultsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdultsButton.Name = "AdultsButton";
            this.AdultsButton.Size = new System.Drawing.Size(448, 189);
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
            this.OlderButton.Location = new System.Drawing.Point(803, 412);
            this.OlderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OlderButton.Name = "OlderButton";
            this.OlderButton.Size = new System.Drawing.Size(448, 189);
            this.OlderButton.TabIndex = 16;
            this.OlderButton.Text = "50+ лет";
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
            this.BackButton.Location = new System.Drawing.Point(297, 669);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(254, 102);
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
            this.ForwardButton.Location = new System.Drawing.Point(997, 669);
            this.ForwardButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(254, 102);
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
            this.AgainButton.Location = new System.Drawing.Point(649, 669);
            this.AgainButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AgainButton.Name = "AgainButton";
            this.AgainButton.Size = new System.Drawing.Size(254, 102);
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
            this.label1.Location = new System.Drawing.Point(297, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(954, 78);
            this.label1.TabIndex = 20;
            this.label1.Text = "Укажите, пожалуйста:\r\n2) Ваш возраст";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Help.chm";
            // 
            // AppForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1330, 785);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}