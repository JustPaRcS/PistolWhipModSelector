namespace PistolWhipModSelector.GamePath
{
    partial class SetGamePath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetGamePath));
            this.CustomFolderPathLabel = new System.Windows.Forms.Label();
            this.CustomFolderSearchButton = new System.Windows.Forms.Button();
            this.GameFolderOkButton = new System.Windows.Forms.Button();
            this.CustomFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.GameFolderCancelButton = new System.Windows.Forms.Button();
            this.GamePathErrorLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CustomFolderPathPanel = new System.Windows.Forms.Panel();
            this.CustomFolderSteamButton = new System.Windows.Forms.Button();
            this.SteamGameFolderPanel = new System.Windows.Forms.Panel();
            this.SteamGameFolderNotUseButton = new System.Windows.Forms.Button();
            this.SteamGameFolderPathUseButton = new System.Windows.Forms.Button();
            this.SteamGameFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.SteamGameFolderLabel = new System.Windows.Forms.Label();
            this.CustomFolderPathPanel.SuspendLayout();
            this.SteamGameFolderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomFolderPathLabel
            // 
            this.CustomFolderPathLabel.AutoSize = true;
            this.CustomFolderPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomFolderPathLabel.Location = new System.Drawing.Point(5, 2);
            this.CustomFolderPathLabel.Name = "CustomFolderPathLabel";
            this.CustomFolderPathLabel.Size = new System.Drawing.Size(181, 20);
            this.CustomFolderPathLabel.TabIndex = 0;
            this.CustomFolderPathLabel.Text = "Select \"Pistol Whip.exe\":";
            // 
            // CustomFolderSearchButton
            // 
            this.CustomFolderSearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CustomFolderSearchButton.BackgroundImage")));
            this.CustomFolderSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CustomFolderSearchButton.Location = new System.Drawing.Point(349, 20);
            this.CustomFolderSearchButton.Name = "CustomFolderSearchButton";
            this.CustomFolderSearchButton.Size = new System.Drawing.Size(30, 30);
            this.CustomFolderSearchButton.TabIndex = 1;
            this.CustomFolderSearchButton.UseVisualStyleBackColor = true;
            this.CustomFolderSearchButton.Click += new System.EventHandler(this.CustomFolderSearchButton_Click);
            // 
            // GameFolderOkButton
            // 
            this.GameFolderOkButton.Location = new System.Drawing.Point(275, 104);
            this.GameFolderOkButton.Name = "GameFolderOkButton";
            this.GameFolderOkButton.Size = new System.Drawing.Size(75, 23);
            this.GameFolderOkButton.TabIndex = 3;
            this.GameFolderOkButton.Text = "OK";
            this.GameFolderOkButton.UseVisualStyleBackColor = true;
            this.GameFolderOkButton.Click += new System.EventHandler(this.CustomFolderOkButton_Click);
            // 
            // CustomFolderPathTextBox
            // 
            this.CustomFolderPathTextBox.Location = new System.Drawing.Point(9, 25);
            this.CustomFolderPathTextBox.Name = "CustomFolderPathTextBox";
            this.CustomFolderPathTextBox.Size = new System.Drawing.Size(334, 20);
            this.CustomFolderPathTextBox.TabIndex = 2;
            this.CustomFolderPathTextBox.TextChanged += new System.EventHandler(this.CustomFolderPathTextBox_TextChanged);
            // 
            // GameFolderCancelButton
            // 
            this.GameFolderCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GameFolderCancelButton.Location = new System.Drawing.Point(359, 104);
            this.GameFolderCancelButton.Name = "GameFolderCancelButton";
            this.GameFolderCancelButton.Size = new System.Drawing.Size(75, 23);
            this.GameFolderCancelButton.TabIndex = 4;
            this.GameFolderCancelButton.Text = "Cancel";
            this.GameFolderCancelButton.UseVisualStyleBackColor = true;
            this.GameFolderCancelButton.Click += new System.EventHandler(this.CustomFolderCancelButton_Click);
            // 
            // GamePathErrorLabel
            // 
            this.GamePathErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePathErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.GamePathErrorLabel.Location = new System.Drawing.Point(16, 60);
            this.GamePathErrorLabel.Name = "GamePathErrorLabel";
            this.GamePathErrorLabel.Size = new System.Drawing.Size(418, 41);
            this.GamePathErrorLabel.TabIndex = 5;
            this.GamePathErrorLabel.Text = "Error label";
            this.GamePathErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Pistol Whip |Pistol Whip.exe";
            // 
            // CustomFolderPathPanel
            // 
            this.CustomFolderPathPanel.Controls.Add(this.CustomFolderSteamButton);
            this.CustomFolderPathPanel.Controls.Add(this.CustomFolderPathTextBox);
            this.CustomFolderPathPanel.Controls.Add(this.CustomFolderPathLabel);
            this.CustomFolderPathPanel.Controls.Add(this.CustomFolderSearchButton);
            this.CustomFolderPathPanel.Location = new System.Drawing.Point(10, 10);
            this.CustomFolderPathPanel.Name = "CustomFolderPathPanel";
            this.CustomFolderPathPanel.Size = new System.Drawing.Size(426, 62);
            this.CustomFolderPathPanel.TabIndex = 6;
            // 
            // CustomFolderSteamButton
            // 
            this.CustomFolderSteamButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CustomFolderSteamButton.BackgroundImage")));
            this.CustomFolderSteamButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CustomFolderSteamButton.Location = new System.Drawing.Point(385, 20);
            this.CustomFolderSteamButton.Name = "CustomFolderSteamButton";
            this.CustomFolderSteamButton.Size = new System.Drawing.Size(30, 30);
            this.CustomFolderSteamButton.TabIndex = 3;
            this.CustomFolderSteamButton.UseVisualStyleBackColor = true;
            this.CustomFolderSteamButton.Click += new System.EventHandler(this.CustomFolderSteamButton_Click);
            // 
            // SteamGameFolderPanel
            // 
            this.SteamGameFolderPanel.Controls.Add(this.SteamGameFolderNotUseButton);
            this.SteamGameFolderPanel.Controls.Add(this.SteamGameFolderPathUseButton);
            this.SteamGameFolderPanel.Controls.Add(this.SteamGameFolderPathTextBox);
            this.SteamGameFolderPanel.Controls.Add(this.SteamGameFolderLabel);
            this.SteamGameFolderPanel.Location = new System.Drawing.Point(8, 190);
            this.SteamGameFolderPanel.Name = "SteamGameFolderPanel";
            this.SteamGameFolderPanel.Size = new System.Drawing.Size(426, 62);
            this.SteamGameFolderPanel.TabIndex = 7;
            // 
            // SteamGameFolderNotUseButton
            // 
            this.SteamGameFolderNotUseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SteamGameFolderNotUseButton.BackgroundImage")));
            this.SteamGameFolderNotUseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SteamGameFolderNotUseButton.Location = new System.Drawing.Point(387, 21);
            this.SteamGameFolderNotUseButton.Name = "SteamGameFolderNotUseButton";
            this.SteamGameFolderNotUseButton.Size = new System.Drawing.Size(30, 30);
            this.SteamGameFolderNotUseButton.TabIndex = 9;
            this.SteamGameFolderNotUseButton.UseVisualStyleBackColor = true;
            this.SteamGameFolderNotUseButton.Click += new System.EventHandler(this.SteamGameFolderNotUseButton_Click);
            // 
            // SteamGameFolderPathUseButton
            // 
            this.SteamGameFolderPathUseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SteamGameFolderPathUseButton.BackgroundImage")));
            this.SteamGameFolderPathUseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SteamGameFolderPathUseButton.Location = new System.Drawing.Point(351, 21);
            this.SteamGameFolderPathUseButton.Name = "SteamGameFolderPathUseButton";
            this.SteamGameFolderPathUseButton.Size = new System.Drawing.Size(30, 30);
            this.SteamGameFolderPathUseButton.TabIndex = 8;
            this.SteamGameFolderPathUseButton.UseVisualStyleBackColor = true;
            this.SteamGameFolderPathUseButton.Click += new System.EventHandler(this.SteamGameFolderPathUseButton_Click);
            // 
            // SteamGameFolderPathTextBox
            // 
            this.SteamGameFolderPathTextBox.Enabled = false;
            this.SteamGameFolderPathTextBox.Location = new System.Drawing.Point(9, 25);
            this.SteamGameFolderPathTextBox.Name = "SteamGameFolderPathTextBox";
            this.SteamGameFolderPathTextBox.Size = new System.Drawing.Size(334, 20);
            this.SteamGameFolderPathTextBox.TabIndex = 2;
            // 
            // SteamGameFolderLabel
            // 
            this.SteamGameFolderLabel.AutoSize = true;
            this.SteamGameFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SteamGameFolderLabel.Location = new System.Drawing.Point(5, 2);
            this.SteamGameFolderLabel.Name = "SteamGameFolderLabel";
            this.SteamGameFolderLabel.Size = new System.Drawing.Size(173, 20);
            this.SteamGameFolderLabel.TabIndex = 0;
            this.SteamGameFolderLabel.Text = "Use your steam folder?";
            // 
            // SetGamePath
            // 
            this.AcceptButton = this.GameFolderOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GameFolderCancelButton;
            this.ClientSize = new System.Drawing.Size(446, 358);
            this.Controls.Add(this.SteamGameFolderPanel);
            this.Controls.Add(this.CustomFolderPathPanel);
            this.Controls.Add(this.GamePathErrorLabel);
            this.Controls.Add(this.GameFolderCancelButton);
            this.Controls.Add(this.GameFolderOkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SetGamePath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set game folder";
            this.Load += new System.EventHandler(this.CustomPath_Load);
            this.CustomFolderPathPanel.ResumeLayout(false);
            this.CustomFolderPathPanel.PerformLayout();
            this.SteamGameFolderPanel.ResumeLayout(false);
            this.SteamGameFolderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CustomFolderPathLabel;
        private System.Windows.Forms.Button CustomFolderSearchButton;
        private System.Windows.Forms.TextBox CustomFolderPathTextBox;
        private System.Windows.Forms.Button GameFolderCancelButton;
        public System.Windows.Forms.Button GameFolderOkButton;
        private System.Windows.Forms.Label GamePathErrorLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel CustomFolderPathPanel;
        private System.Windows.Forms.Panel SteamGameFolderPanel;
        private System.Windows.Forms.Button SteamGameFolderNotUseButton;
        private System.Windows.Forms.Button SteamGameFolderPathUseButton;
        private System.Windows.Forms.TextBox SteamGameFolderPathTextBox;
        private System.Windows.Forms.Label SteamGameFolderLabel;
        private System.Windows.Forms.Button CustomFolderSteamButton;
    }
}