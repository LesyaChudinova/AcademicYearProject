using System;

namespace AcademicYearProject
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTopInfo = new System.Windows.Forms.Label();
            this.lblBottomInfo = new System.Windows.Forms.Label();
            this.linkPinterest = new System.Windows.Forms.LinkLabel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.help_button = new System.Windows.Forms.Button();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOutfitName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Location = new System.Drawing.Point(42, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 486);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTopInfo
            // 
            this.lblTopInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTopInfo.AutoSize = true;
            this.lblTopInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblTopInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTopInfo.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.lblTopInfo.Location = new System.Drawing.Point(894, 366);
            this.lblTopInfo.Name = "lblTopInfo";
            this.lblTopInfo.Size = new System.Drawing.Size(64, 26);
            this.lblTopInfo.TabIndex = 2;
            this.lblTopInfo.Text = "label1";
            // 
            // lblBottomInfo
            // 
            this.lblBottomInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBottomInfo.AutoSize = true;
            this.lblBottomInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBottomInfo.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.lblBottomInfo.Location = new System.Drawing.Point(578, 366);
            this.lblBottomInfo.Name = "lblBottomInfo";
            this.lblBottomInfo.Size = new System.Drawing.Size(64, 26);
            this.lblBottomInfo.TabIndex = 3;
            this.lblBottomInfo.Text = "label1";
            // 
            // linkPinterest
            // 
            this.linkPinterest.ActiveLinkColor = System.Drawing.Color.Brown;
            this.linkPinterest.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkPinterest.AutoSize = true;
            this.linkPinterest.BackColor = System.Drawing.Color.White;
            this.linkPinterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkPinterest.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkPinterest.Font = new System.Drawing.Font("Bahnschrift Light", 11F);
            this.linkPinterest.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(68)))));
            this.linkPinterest.Location = new System.Drawing.Point(383, 606);
            this.linkPinterest.Name = "linkPinterest";
            this.linkPinterest.Size = new System.Drawing.Size(883, 56);
            this.linkPinterest.TabIndex = 4;
            this.linkPinterest.TabStop = true;
            this.linkPinterest.Text = "Нажмите на эту ссылку, чтобы увидеть, как можно этот образ красиво стилизовать! \r" +
    "\nОна приведет вас к реферансам на пинтересте, которыми вы сможете вдохновиться";
            this.linkPinterest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkPinterest.UseMnemonic = false;
            this.linkPinterest.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkPinterest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPinterest_LinkClicked_1);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(142, 66);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 39);
            this.button6.TabIndex = 16;
            this.button6.Text = "Указатель";
            this.button6.UseVisualStyleBackColor = true;
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
            this.button5.TabIndex = 15;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = true;
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
            this.help_button.TabIndex = 14;
            this.help_button.Text = "?";
            this.help_button.UseVisualStyleBackColor = false;
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPageInfo.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.lblPageInfo.Location = new System.Drawing.Point(665, 734);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(64, 26);
            this.lblPageInfo.TabIndex = 17;
            this.lblPageInfo.Text = "label1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(312, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(954, 95);
            this.label1.TabIndex = 22;
            this.label1.Text = "Мы подобрали вам чудесные результаты!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label2.Location = new System.Drawing.Point(42, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 54);
            this.label2.TabIndex = 23;
            this.label2.Text = "Вариант образа:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label3.Location = new System.Drawing.Point(555, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(711, 54);
            this.label3.TabIndex = 24;
            this.label3.Text = "Он действительно соответствует вашим пожеланиям:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutfitName
            // 
            this.lblOutfitName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOutfitName.BackColor = System.Drawing.Color.White;
            this.lblOutfitName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutfitName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOutfitName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblOutfitName.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.lblOutfitName.Location = new System.Drawing.Point(555, 155);
            this.lblOutfitName.Name = "lblOutfitName";
            this.lblOutfitName.Size = new System.Drawing.Size(711, 54);
            this.lblOutfitName.TabIndex = 25;
            this.lblOutfitName.Text = "текст";
            this.lblOutfitName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOutfitName.Click += new System.EventHandler(this.lblOutfitName_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(858, 734);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(408, 49);
            this.button1.TabIndex = 26;
            this.button1.Text = "Следующий вариант образа -->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(42, 734);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(408, 49);
            this.button2.TabIndex = 27;
            this.button2.Text = "<-- Предыдущий вариант образа";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1353, 826);
            this.Controls.Add(this.lblOutfitName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPageInfo);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.linkPinterest);
            this.Controls.Add(this.lblBottomInfo);
            this.Controls.Add(this.lblTopInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ResultForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTopInfo;
        private System.Windows.Forms.Label lblBottomInfo;
        private System.Windows.Forms.LinkLabel linkPinterest;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOutfitName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}