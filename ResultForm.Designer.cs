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
            this.lblOutfitName = new System.Windows.Forms.Label();
            this.lblTopInfo = new System.Windows.Forms.Label();
            this.lblBottomInfo = new System.Windows.Forms.Label();
            this.linkPinterest = new System.Windows.Forms.LinkLabel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.help_button = new System.Windows.Forms.Button();
            this.lblPageInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(511, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblOutfitName
            // 
            this.lblOutfitName.AutoSize = true;
            this.lblOutfitName.Location = new System.Drawing.Point(485, 52);
            this.lblOutfitName.Name = "lblOutfitName";
            this.lblOutfitName.Size = new System.Drawing.Size(0, 20);
            this.lblOutfitName.TabIndex = 1;
            // 
            // lblTopInfo
            // 
            this.lblTopInfo.AutoSize = true;
            this.lblTopInfo.Location = new System.Drawing.Point(507, 137);
            this.lblTopInfo.Name = "lblTopInfo";
            this.lblTopInfo.Size = new System.Drawing.Size(51, 20);
            this.lblTopInfo.TabIndex = 2;
            this.lblTopInfo.Text = "label1";
            // 
            // lblBottomInfo
            // 
            this.lblBottomInfo.AutoSize = true;
            this.lblBottomInfo.Location = new System.Drawing.Point(511, 192);
            this.lblBottomInfo.Name = "lblBottomInfo";
            this.lblBottomInfo.Size = new System.Drawing.Size(51, 20);
            this.lblBottomInfo.TabIndex = 3;
            this.lblBottomInfo.Text = "label1";
            // 
            // linkPinterest
            // 
            this.linkPinterest.AutoSize = true;
            this.linkPinterest.Location = new System.Drawing.Point(146, 178);
            this.linkPinterest.Name = "linkPinterest";
            this.linkPinterest.Size = new System.Drawing.Size(80, 20);
            this.linkPinterest.TabIndex = 4;
            this.linkPinterest.TabStop = true;
            this.linkPinterest.Text = "linkLabel1";
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
            this.help_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
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
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Location = new System.Drawing.Point(356, 393);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(51, 20);
            this.lblPageInfo.TabIndex = 17;
            this.lblPageInfo.Text = "label1";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPageInfo);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.linkPinterest);
            this.Controls.Add(this.lblBottomInfo);
            this.Controls.Add(this.lblTopInfo);
            this.Controls.Add(this.lblOutfitName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ResultForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOutfitName;
        private System.Windows.Forms.Label lblTopInfo;
        private System.Windows.Forms.Label lblBottomInfo;
        private System.Windows.Forms.LinkLabel linkPinterest;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.Label lblPageInfo;
    }
}