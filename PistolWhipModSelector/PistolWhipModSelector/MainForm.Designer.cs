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
            this.CustomSongsDataGridView = new System.Windows.Forms.DataGridView();
            this.songTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReloadAllButton = new System.Windows.Forms.Button();
            this.CustomSongsResetButton = new System.Windows.Forms.Button();
            this.CustomSongsReplaceButton = new System.Windows.Forms.Button();
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
            this.CustomSongsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            // ReloadAllButton
            // 
            this.ReloadAllButton.BackgroundImage = global::PistolWhipModSelector.Pictures.Reload;
            this.ReloadAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReloadAllButton.Location = new System.Drawing.Point(758, 12);
            this.ReloadAllButton.Name = "ReloadAllButton";
            this.ReloadAllButton.Size = new System.Drawing.Size(30, 30);
            this.ReloadAllButton.TabIndex = 4;
            this.ReloadAllButton.UseVisualStyleBackColor = true;
            this.ReloadAllButton.Click += new System.EventHandler(this.ReloadAllButton_Click);
            // 
            // CustomSongsResetButton
            // 
            this.CustomSongsResetButton.Location = new System.Drawing.Point(370, 16);
            this.CustomSongsResetButton.Name = "CustomSongsResetButton";
            this.CustomSongsResetButton.Size = new System.Drawing.Size(75, 23);
            this.CustomSongsResetButton.TabIndex = 5;
            this.CustomSongsResetButton.Text = "Reset Song";
            this.CustomSongsResetButton.UseVisualStyleBackColor = true;
            this.CustomSongsResetButton.Click += new System.EventHandler(this.CustomSongsResetButton_Click);
            // 
            // CustomSongsReplaceButton
            // 
            this.CustomSongsReplaceButton.Location = new System.Drawing.Point(451, 16);
            this.CustomSongsReplaceButton.Name = "CustomSongsReplaceButton";
            this.CustomSongsReplaceButton.Size = new System.Drawing.Size(75, 23);
            this.CustomSongsReplaceButton.TabIndex = 6;
            this.CustomSongsReplaceButton.Text = "Replace";
            this.CustomSongsReplaceButton.UseVisualStyleBackColor = true;
            this.CustomSongsReplaceButton.Click += new System.EventHandler(this.CustomSongsReplaceButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomSongsReplaceButton);
            this.Controls.Add(this.CustomSongsResetButton);
            this.Controls.Add(this.ReloadAllButton);
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
        private System.Windows.Forms.Button ReloadAllButton;
        private System.Windows.Forms.Button CustomSongsResetButton;
        private System.Windows.Forms.Button CustomSongsReplaceButton;
    }
}

