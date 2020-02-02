namespace PistolWhipModSelector
{
    partial class MainForm
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
            this.OriginalSongNamesListBox = new System.Windows.Forms.ListBox();
            this.OriginalSongShowIDCheckBox = new System.Windows.Forms.CheckBox();
            this.OriginalSongShowNameCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // OriginalSongNamesListBox
            // 
            this.OriginalSongNamesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginalSongNamesListBox.FormattingEnabled = true;
            this.OriginalSongNamesListBox.ItemHeight = 20;
            this.OriginalSongNamesListBox.Location = new System.Drawing.Point(12, 44);
            this.OriginalSongNamesListBox.Name = "OriginalSongNamesListBox";
            this.OriginalSongNamesListBox.Size = new System.Drawing.Size(298, 384);
            this.OriginalSongNamesListBox.TabIndex = 0;
            // 
            // OriginalSongShowIDCheckBox
            // 
            this.OriginalSongShowIDCheckBox.AutoSize = true;
            this.OriginalSongShowIDCheckBox.Location = new System.Drawing.Point(12, 21);
            this.OriginalSongShowIDCheckBox.Name = "OriginalSongShowIDCheckBox";
            this.OriginalSongShowIDCheckBox.Size = new System.Drawing.Size(67, 17);
            this.OriginalSongShowIDCheckBox.TabIndex = 1;
            this.OriginalSongShowIDCheckBox.Text = "Show ID";
            this.OriginalSongShowIDCheckBox.UseVisualStyleBackColor = true;
            this.OriginalSongShowIDCheckBox.CheckedChanged += new System.EventHandler(this.OriginalSongCheckBox_CheckedChanged);
            // 
            // OriginalSongShowNameCheckBox
            // 
            this.OriginalSongShowNameCheckBox.AutoSize = true;
            this.OriginalSongShowNameCheckBox.Location = new System.Drawing.Point(85, 21);
            this.OriginalSongShowNameCheckBox.Name = "OriginalSongShowNameCheckBox";
            this.OriginalSongShowNameCheckBox.Size = new System.Drawing.Size(84, 17);
            this.OriginalSongShowNameCheckBox.TabIndex = 2;
            this.OriginalSongShowNameCheckBox.Text = "Show Name";
            this.OriginalSongShowNameCheckBox.UseVisualStyleBackColor = true;
            this.OriginalSongShowNameCheckBox.CheckedChanged += new System.EventHandler(this.OriginalSongCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OriginalSongShowNameCheckBox);
            this.Controls.Add(this.OriginalSongShowIDCheckBox);
            this.Controls.Add(this.OriginalSongNamesListBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OriginalSongNamesListBox;
        private System.Windows.Forms.CheckBox OriginalSongShowIDCheckBox;
        private System.Windows.Forms.CheckBox OriginalSongShowNameCheckBox;
    }
}

