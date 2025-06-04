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
            this.OutfitsListBox = new System.Windows.Forms.ListBox();
            this.DetailsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OutfitsListBox
            // 
            this.OutfitsListBox.DisplayMember = "=Name";
            this.OutfitsListBox.FormattingEnabled = true;
            this.OutfitsListBox.ItemHeight = 20;
            this.OutfitsListBox.Location = new System.Drawing.Point(516, 239);
            this.OutfitsListBox.Name = "OutfitsListBox";
            this.OutfitsListBox.Size = new System.Drawing.Size(120, 84);
            this.OutfitsListBox.TabIndex = 0;
            this.OutfitsListBox.SelectedIndexChanged += new System.EventHandler(this.OutfitsListBox_SelectedIndexChanged);
            // 
            // DetailsTextBox
            // 
            this.DetailsTextBox.Location = new System.Drawing.Point(452, 132);
            this.DetailsTextBox.Name = "DetailsTextBox";
            this.DetailsTextBox.Size = new System.Drawing.Size(100, 26);
            this.DetailsTextBox.TabIndex = 1;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DetailsTextBox);
            this.Controls.Add(this.OutfitsListBox);
            this.Name = "ResultForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ListBox OutfitsListBox;
        private System.Windows.Forms.TextBox DetailsTextBox;
    }
}