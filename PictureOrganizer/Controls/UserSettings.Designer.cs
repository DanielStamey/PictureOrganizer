namespace PictureOrganizer
{
    partial class UserSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelUserSettings = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSaveUserSettings = new System.Windows.Forms.Button();
            this.labelSourceSettingValue = new System.Windows.Forms.Label();
            this.labelDestinationSettingValue = new System.Windows.Forms.Label();
            this.buttonSourceBrowse = new System.Windows.Forms.Button();
            this.buttonDestinationBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.labelSourcePath = new System.Windows.Forms.Label();
            this.labelDestinationPath = new System.Windows.Forms.Label();
            this.panelUserSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserSettings
            // 
            this.panelUserSettings.Controls.Add(this.buttonClose);
            this.panelUserSettings.Controls.Add(this.buttonSaveUserSettings);
            this.panelUserSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUserSettings.Location = new System.Drawing.Point(0, 432);
            this.panelUserSettings.Name = "panelUserSettings";
            this.panelUserSettings.Size = new System.Drawing.Size(658, 32);
            this.panelUserSettings.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.Location = new System.Drawing.Point(508, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 32);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSaveUserSettings
            // 
            this.buttonSaveUserSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSaveUserSettings.Location = new System.Drawing.Point(583, 0);
            this.buttonSaveUserSettings.Name = "buttonSaveUserSettings";
            this.buttonSaveUserSettings.Size = new System.Drawing.Size(75, 32);
            this.buttonSaveUserSettings.TabIndex = 0;
            this.buttonSaveUserSettings.Text = "Save";
            this.buttonSaveUserSettings.UseVisualStyleBackColor = true;
            this.buttonSaveUserSettings.Click += new System.EventHandler(this.buttonSaveUserSettings_Click);
            // 
            // labelSourceSettingValue
            // 
            this.labelSourceSettingValue.AutoSize = true;
            this.labelSourceSettingValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PictureOrganizer.Settings.Default, "SourcePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelSourceSettingValue.Location = new System.Drawing.Point(92, 9);
            this.labelSourceSettingValue.Name = "labelSourceSettingValue";
            this.labelSourceSettingValue.Size = new System.Drawing.Size(0, 17);
            this.labelSourceSettingValue.TabIndex = 1;
            this.labelSourceSettingValue.Text = global::PictureOrganizer.Settings.Default.SourcePath;
            // 
            // labelDestinationSettingValue
            // 
            this.labelDestinationSettingValue.AutoSize = true;
            this.labelDestinationSettingValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PictureOrganizer.Settings.Default, "DestinationPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelDestinationSettingValue.Location = new System.Drawing.Point(92, 38);
            this.labelDestinationSettingValue.Name = "labelDestinationSettingValue";
            this.labelDestinationSettingValue.Size = new System.Drawing.Size(0, 17);
            this.labelDestinationSettingValue.TabIndex = 2;
            this.labelDestinationSettingValue.Text = global::PictureOrganizer.Settings.Default.DestinationPath;
            // 
            // buttonSourceBrowse
            // 
            this.buttonSourceBrowse.Location = new System.Drawing.Point(580, 3);
            this.buttonSourceBrowse.Name = "buttonSourceBrowse";
            this.buttonSourceBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonSourceBrowse.TabIndex = 3;
            this.buttonSourceBrowse.Text = "Browse";
            this.buttonSourceBrowse.UseVisualStyleBackColor = true;
            this.buttonSourceBrowse.Click += new System.EventHandler(this.buttonSourceBrowse_Click);
            // 
            // buttonDestinationBrowse
            // 
            this.buttonDestinationBrowse.Location = new System.Drawing.Point(580, 32);
            this.buttonDestinationBrowse.Name = "buttonDestinationBrowse";
            this.buttonDestinationBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonDestinationBrowse.TabIndex = 4;
            this.buttonDestinationBrowse.Text = "Browse";
            this.buttonDestinationBrowse.UseVisualStyleBackColor = true;
            this.buttonDestinationBrowse.Click += new System.EventHandler(this.buttonDestinationBrowse_Click);
            // 
            // labelSourcePath
            // 
            this.labelSourcePath.AutoSize = true;
            this.labelSourcePath.Location = new System.Drawing.Point(29, 9);
            this.labelSourcePath.Name = "labelSourcePath";
            this.labelSourcePath.Size = new System.Drawing.Size(57, 17);
            this.labelSourcePath.TabIndex = 5;
            this.labelSourcePath.Text = "Source:";
            // 
            // labelDestinationPath
            // 
            this.labelDestinationPath.AutoSize = true;
            this.labelDestinationPath.Location = new System.Drawing.Point(3, 38);
            this.labelDestinationPath.Name = "labelDestinationPath";
            this.labelDestinationPath.Size = new System.Drawing.Size(83, 17);
            this.labelDestinationPath.TabIndex = 6;
            this.labelDestinationPath.Text = "Destination:";
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSourcePath);
            this.Controls.Add(this.labelDestinationPath);
            this.Controls.Add(this.buttonSourceBrowse);
            this.Controls.Add(this.labelSourceSettingValue);
            this.Controls.Add(this.buttonDestinationBrowse);
            this.Controls.Add(this.labelDestinationSettingValue);
            this.Controls.Add(this.panelUserSettings);
            this.Name = "UserSettings";
            this.Size = new System.Drawing.Size(658, 464);
            this.panelUserSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUserSettings;
        private System.Windows.Forms.Label labelSourceSettingValue;
        private System.Windows.Forms.Label labelDestinationSettingValue;
        private System.Windows.Forms.Button buttonSourceBrowse;
        private System.Windows.Forms.Button buttonDestinationBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        public System.Windows.Forms.Button buttonSaveUserSettings;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelSourcePath;
        private System.Windows.Forms.Label labelDestinationPath;
    }
}
