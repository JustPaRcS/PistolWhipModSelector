namespace PistolWhipModSelector.AddNewSongs
{
    partial class AddNewSongsForm
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
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.CustomSongTitleLabel = new System.Windows.Forms.Label();
            this.CustomSongTitleTextBox = new System.Windows.Forms.TextBox();
            this.CustomSongAuthorTextBox = new System.Windows.Forms.TextBox();
            this.CustomSongAuthorLabel = new System.Windows.Forms.Label();
            this.CustomSongFilePathLabel = new System.Windows.Forms.Label();
            this.CustomSongFileFullPathLabel = new System.Windows.Forms.Label();
            this.SongSaveButton = new System.Windows.Forms.Button();
            this.SongCancelButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.CustomSongMoveCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FilesListBox
            // 
            this.FilesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.ItemHeight = 15;
            this.FilesListBox.Location = new System.Drawing.Point(12, 12);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(250, 364);
            this.FilesListBox.TabIndex = 0;
            this.FilesListBox.SelectedIndexChanged += new System.EventHandler(this.FilesListBox_SelectedIndexChanged);
            // 
            // CustomSongTitleLabel
            // 
            this.CustomSongTitleLabel.AutoSize = true;
            this.CustomSongTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomSongTitleLabel.Location = new System.Drawing.Point(283, 154);
            this.CustomSongTitleLabel.Name = "CustomSongTitleLabel";
            this.CustomSongTitleLabel.Size = new System.Drawing.Size(73, 18);
            this.CustomSongTitleLabel.TabIndex = 1;
            this.CustomSongTitleLabel.Text = "Song title:";
            // 
            // CustomSongTitleTextBox
            // 
            this.CustomSongTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomSongTitleTextBox.Location = new System.Drawing.Point(286, 175);
            this.CustomSongTitleTextBox.Name = "CustomSongTitleTextBox";
            this.CustomSongTitleTextBox.Size = new System.Drawing.Size(331, 24);
            this.CustomSongTitleTextBox.TabIndex = 2;
            // 
            // CustomSongAuthorTextBox
            // 
            this.CustomSongAuthorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomSongAuthorTextBox.Location = new System.Drawing.Point(286, 228);
            this.CustomSongAuthorTextBox.Name = "CustomSongAuthorTextBox";
            this.CustomSongAuthorTextBox.Size = new System.Drawing.Size(331, 24);
            this.CustomSongAuthorTextBox.TabIndex = 4;
            // 
            // CustomSongAuthorLabel
            // 
            this.CustomSongAuthorLabel.AutoSize = true;
            this.CustomSongAuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomSongAuthorLabel.Location = new System.Drawing.Point(283, 207);
            this.CustomSongAuthorLabel.Name = "CustomSongAuthorLabel";
            this.CustomSongAuthorLabel.Size = new System.Drawing.Size(55, 18);
            this.CustomSongAuthorLabel.TabIndex = 3;
            this.CustomSongAuthorLabel.Text = "Author:";
            // 
            // CustomSongFilePathLabel
            // 
            this.CustomSongFilePathLabel.AutoSize = true;
            this.CustomSongFilePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomSongFilePathLabel.Location = new System.Drawing.Point(283, 21);
            this.CustomSongFilePathLabel.Name = "CustomSongFilePathLabel";
            this.CustomSongFilePathLabel.Size = new System.Drawing.Size(67, 18);
            this.CustomSongFilePathLabel.TabIndex = 5;
            this.CustomSongFilePathLabel.Text = "File path:";
            // 
            // CustomSongFileFullPathLabel
            // 
            this.CustomSongFileFullPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomSongFileFullPathLabel.Location = new System.Drawing.Point(283, 48);
            this.CustomSongFileFullPathLabel.Name = "CustomSongFileFullPathLabel";
            this.CustomSongFileFullPathLabel.Size = new System.Drawing.Size(334, 96);
            this.CustomSongFileFullPathLabel.TabIndex = 6;
            // 
            // SongSaveButton
            // 
            this.SongSaveButton.BackgroundImage = global::PistolWhipModSelector.Pictures.Check;
            this.SongSaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SongSaveButton.Location = new System.Drawing.Point(521, 288);
            this.SongSaveButton.Name = "SongSaveButton";
            this.SongSaveButton.Size = new System.Drawing.Size(30, 30);
            this.SongSaveButton.TabIndex = 7;
            this.SongSaveButton.UseVisualStyleBackColor = true;
            this.SongSaveButton.Click += new System.EventHandler(this.SongSaveButton_Click);
            // 
            // SongCancelButton
            // 
            this.SongCancelButton.BackgroundImage = global::PistolWhipModSelector.Pictures.Cross;
            this.SongCancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SongCancelButton.Location = new System.Drawing.Point(557, 288);
            this.SongCancelButton.Name = "SongCancelButton";
            this.SongCancelButton.Size = new System.Drawing.Size(30, 30);
            this.SongCancelButton.TabIndex = 8;
            this.SongCancelButton.UseVisualStyleBackColor = true;
            // 
            // finishButton
            // 
            this.finishButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.finishButton.Location = new System.Drawing.Point(557, 361);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 9;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            // 
            // CustomSongMoveCheckBox
            // 
            this.CustomSongMoveCheckBox.AutoSize = true;
            this.CustomSongMoveCheckBox.Location = new System.Drawing.Point(286, 258);
            this.CustomSongMoveCheckBox.Name = "CustomSongMoveCheckBox";
            this.CustomSongMoveCheckBox.Size = new System.Drawing.Size(59, 17);
            this.CustomSongMoveCheckBox.TabIndex = 10;
            this.CustomSongMoveCheckBox.Text = "Move?";
            this.CustomSongMoveCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddNewSongsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 396);
            this.Controls.Add(this.CustomSongMoveCheckBox);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.SongCancelButton);
            this.Controls.Add(this.SongSaveButton);
            this.Controls.Add(this.CustomSongFileFullPathLabel);
            this.Controls.Add(this.CustomSongFilePathLabel);
            this.Controls.Add(this.CustomSongAuthorTextBox);
            this.Controls.Add(this.CustomSongAuthorLabel);
            this.Controls.Add(this.CustomSongTitleTextBox);
            this.Controls.Add(this.CustomSongTitleLabel);
            this.Controls.Add(this.FilesListBox);
            this.Name = "AddNewSongsForm";
            this.Text = "Add new songs";
            this.Load += new System.EventHandler(this.AddNewSongsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FilesListBox;
        private System.Windows.Forms.Label CustomSongTitleLabel;
        private System.Windows.Forms.TextBox CustomSongTitleTextBox;
        private System.Windows.Forms.TextBox CustomSongAuthorTextBox;
        private System.Windows.Forms.Label CustomSongAuthorLabel;
        private System.Windows.Forms.Label CustomSongFilePathLabel;
        private System.Windows.Forms.Label CustomSongFileFullPathLabel;
        private System.Windows.Forms.Button SongSaveButton;
        private System.Windows.Forms.Button SongCancelButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.CheckBox CustomSongMoveCheckBox;
    }
}