﻿namespace PistolWhipModSelector
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
            this.CustomSongsDataGridView = new System.Windows.Forms.DataGridView();
            this.songTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloadAllButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomSongsDataGridView)).BeginInit();
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
            this.OriginalSongNamesListBox.SelectedIndexChanged += new System.EventHandler(this.OriginalSongNamesListBox_SelectedIndexChanged);
            // 
            // OriginalSongShowIDCheckBox
            // 
            this.OriginalSongShowIDCheckBox.AutoSize = true;
            this.OriginalSongShowIDCheckBox.Checked = true;
            this.OriginalSongShowIDCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.OriginalSongShowNameCheckBox.Checked = true;
            this.OriginalSongShowNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OriginalSongShowNameCheckBox.Location = new System.Drawing.Point(85, 21);
            this.OriginalSongShowNameCheckBox.Name = "OriginalSongShowNameCheckBox";
            this.OriginalSongShowNameCheckBox.Size = new System.Drawing.Size(84, 17);
            this.OriginalSongShowNameCheckBox.TabIndex = 2;
            this.OriginalSongShowNameCheckBox.Text = "Show Name";
            this.OriginalSongShowNameCheckBox.UseVisualStyleBackColor = true;
            this.OriginalSongShowNameCheckBox.CheckedChanged += new System.EventHandler(this.OriginalSongCheckBox_CheckedChanged);
            // 
            // CustomSongsDataGridView
            // 
            this.CustomSongsDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CustomSongsDataGridView.AllowDrop = true;
            this.CustomSongsDataGridView.AllowUserToAddRows = false;
            this.CustomSongsDataGridView.AllowUserToDeleteRows = false;
            this.CustomSongsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomSongsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomSongsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songTitle,
            this.songAuthor,
            this.songPath});
            this.CustomSongsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CustomSongsDataGridView.Location = new System.Drawing.Point(370, 44);
            this.CustomSongsDataGridView.MultiSelect = false;
            this.CustomSongsDataGridView.Name = "CustomSongsDataGridView";
            this.CustomSongsDataGridView.RowHeadersVisible = false;
            this.CustomSongsDataGridView.ShowEditingIcon = false;
            this.CustomSongsDataGridView.Size = new System.Drawing.Size(418, 384);
            this.CustomSongsDataGridView.TabIndex = 3;
            this.CustomSongsDataGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.CustomSongsDataGridView_DragDrop);
            this.CustomSongsDataGridView.DragEnter += new System.Windows.Forms.DragEventHandler(this.CustomSongsDataGridView_DragEnter);
            // 
            // songTitle
            // 
            this.songTitle.HeaderText = "Title";
            this.songTitle.Name = "songTitle";
            // 
            // songAuthor
            // 
            this.songAuthor.HeaderText = "Author";
            this.songAuthor.Name = "songAuthor";
            // 
            // songPath
            // 
            this.songPath.HeaderText = "Path";
            this.songPath.Name = "songPath";
            // 
            // reloadAllButton
            // 
            this.reloadAllButton.BackgroundImage = global::PistolWhipModSelector.Pictures.Reload;
            this.reloadAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reloadAllButton.Location = new System.Drawing.Point(758, 12);
            this.reloadAllButton.Name = "reloadAllButton";
            this.reloadAllButton.Size = new System.Drawing.Size(30, 30);
            this.reloadAllButton.TabIndex = 4;
            this.reloadAllButton.UseVisualStyleBackColor = true;
            this.reloadAllButton.Click += new System.EventHandler(this.reloadAllButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reloadAllButton);
            this.Controls.Add(this.CustomSongsDataGridView);
            this.Controls.Add(this.OriginalSongShowNameCheckBox);
            this.Controls.Add(this.OriginalSongShowIDCheckBox);
            this.Controls.Add(this.OriginalSongNamesListBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomSongsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OriginalSongNamesListBox;
        private System.Windows.Forms.CheckBox OriginalSongShowIDCheckBox;
        private System.Windows.Forms.CheckBox OriginalSongShowNameCheckBox;
        private System.Windows.Forms.DataGridView CustomSongsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn songTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn songAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn songPath;
        private System.Windows.Forms.Button reloadAllButton;
    }
}

