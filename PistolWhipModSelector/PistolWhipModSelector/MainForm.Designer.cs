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
            this.OriginalSongShowIDCheckBox = new System.Windows.Forms.CheckBox();
            this.OriginalSongShowNameCheckBox = new System.Windows.Forms.CheckBox();
            this.CustomSongsDataGridView = new System.Windows.Forms.DataGridView();
            this.songTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReloadAllButton = new System.Windows.Forms.Button();
            this.CustomSongsResetButton = new System.Windows.Forms.Button();
            this.CustomSongsReplaceButton = new System.Windows.Forms.Button();
            this.CustomSongsDeleteButton = new System.Windows.Forms.Button();
            this.CustomSongsEditButton = new System.Windows.Forms.Button();
            this.Creator = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.CopyStateLabel = new System.Windows.Forms.Label();
            this.songsTreeView = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.CustomSongsDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.CustomSongsDataGridView.AllowUserToAddRows = false;
            this.CustomSongsDataGridView.AllowUserToDeleteRows = false;
            this.CustomSongsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.CustomSongsDataGridView.Size = new System.Drawing.Size(418, 352);
            this.CustomSongsDataGridView.TabIndex = 3;
            this.CustomSongsDataGridView.SelectionChanged += new System.EventHandler(this.CustomSongsDataGridView_SelectionChanged);
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
            this.ReloadAllButton.Enabled = false;
            this.ReloadAllButton.Location = new System.Drawing.Point(758, 12);
            this.ReloadAllButton.Name = "ReloadAllButton";
            this.ReloadAllButton.Size = new System.Drawing.Size(30, 30);
            this.ReloadAllButton.TabIndex = 4;
            this.ReloadAllButton.UseVisualStyleBackColor = true;
            this.ReloadAllButton.Click += new System.EventHandler(this.ReloadAllButton_Click);
            // 
            // CustomSongsResetButton
            // 
            this.CustomSongsResetButton.Enabled = false;
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
            this.CustomSongsReplaceButton.Enabled = false;
            this.CustomSongsReplaceButton.Location = new System.Drawing.Point(451, 16);
            this.CustomSongsReplaceButton.Name = "CustomSongsReplaceButton";
            this.CustomSongsReplaceButton.Size = new System.Drawing.Size(75, 23);
            this.CustomSongsReplaceButton.TabIndex = 6;
            this.CustomSongsReplaceButton.Text = "Replace";
            this.CustomSongsReplaceButton.UseVisualStyleBackColor = true;
            this.CustomSongsReplaceButton.Click += new System.EventHandler(this.CustomSongsReplaceButton_Click);
            // 
            // CustomSongsDeleteButton
            // 
            this.CustomSongsDeleteButton.Enabled = false;
            this.CustomSongsDeleteButton.Location = new System.Drawing.Point(561, 16);
            this.CustomSongsDeleteButton.Name = "CustomSongsDeleteButton";
            this.CustomSongsDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.CustomSongsDeleteButton.TabIndex = 7;
            this.CustomSongsDeleteButton.Text = "Delete";
            this.CustomSongsDeleteButton.UseVisualStyleBackColor = true;
            this.CustomSongsDeleteButton.Click += new System.EventHandler(this.CustomSongsDeleteButton_Click);
            // 
            // CustomSongsEditButton
            // 
            this.CustomSongsEditButton.Enabled = false;
            this.CustomSongsEditButton.Location = new System.Drawing.Point(642, 16);
            this.CustomSongsEditButton.Name = "CustomSongsEditButton";
            this.CustomSongsEditButton.Size = new System.Drawing.Size(75, 23);
            this.CustomSongsEditButton.TabIndex = 8;
            this.CustomSongsEditButton.Text = "Edit";
            this.CustomSongsEditButton.UseVisualStyleBackColor = true;
            this.CustomSongsEditButton.Click += new System.EventHandler(this.CustomSongsEditButton_Click);
            // 
            // Creator
            // 
            this.Creator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Creator.AutoSize = true;
            this.Creator.Location = new System.Drawing.Point(668, 440);
            this.Creator.Name = "Creator";
            this.Creator.Size = new System.Drawing.Size(126, 13);
            this.Creator.TabIndex = 9;
            this.Creator.Text = "Created by PaRcS#2179";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 440);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(232, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "github.com/JustPaRcS/PistolWhipModSelector";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // CopyStateLabel
            // 
            this.CopyStateLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CopyStateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CopyStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyStateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CopyStateLabel.Location = new System.Drawing.Point(370, 399);
            this.CopyStateLabel.Name = "CopyStateLabel";
            this.CopyStateLabel.Size = new System.Drawing.Size(418, 29);
            this.CopyStateLabel.TabIndex = 11;
            this.CopyStateLabel.Text = "State";
            this.CopyStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // songsTreeView
            // 
            this.songsTreeView.Location = new System.Drawing.Point(12, 44);
            this.songsTreeView.Name = "songsTreeView";
            this.songsTreeView.Size = new System.Drawing.Size(309, 384);
            this.songsTreeView.TabIndex = 12;
            this.songsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.songsTreeView_AfterSelect);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.songsTreeView);
            this.Controls.Add(this.CopyStateLabel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Creator);
            this.Controls.Add(this.CustomSongsEditButton);
            this.Controls.Add(this.CustomSongsDeleteButton);
            this.Controls.Add(this.CustomSongsReplaceButton);
            this.Controls.Add(this.CustomSongsResetButton);
            this.Controls.Add(this.ReloadAllButton);
            this.Controls.Add(this.CustomSongsDataGridView);
            this.Controls.Add(this.OriginalSongShowNameCheckBox);
            this.Controls.Add(this.OriginalSongShowIDCheckBox);
            this.MinimumSize = new System.Drawing.Size(816, 500);
            this.Name = "MainForm";
            this.Text = "Pistol Whip Custom Songs";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomSongsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox OriginalSongShowIDCheckBox;
        private System.Windows.Forms.CheckBox OriginalSongShowNameCheckBox;
        private System.Windows.Forms.DataGridView CustomSongsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn songTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn songAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn songPath;
        private System.Windows.Forms.Button ReloadAllButton;
        private System.Windows.Forms.Button CustomSongsResetButton;
        private System.Windows.Forms.Button CustomSongsReplaceButton;
        private System.Windows.Forms.Button CustomSongsDeleteButton;
        private System.Windows.Forms.Button CustomSongsEditButton;
        private System.Windows.Forms.Label Creator;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label CopyStateLabel;
        private System.Windows.Forms.TreeView songsTreeView;
    }
}

