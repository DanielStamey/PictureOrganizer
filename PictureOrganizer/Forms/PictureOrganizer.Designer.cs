namespace PictureOrganizer
{
    partial class FormPictureOrganizer
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
            this.menuStripPictureOrganizer = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControlContainer = new System.Windows.Forms.Panel();
            this.mediaTransfer = new PictureOrganizer.Controls.MediaTransfer();
            this.menuStripPictureOrganizer.SuspendLayout();
            this.panelControlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPictureOrganizer
            // 
            this.menuStripPictureOrganizer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripPictureOrganizer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStripPictureOrganizer.Location = new System.Drawing.Point(0, 0);
            this.menuStripPictureOrganizer.Name = "menuStripPictureOrganizer";
            this.menuStripPictureOrganizer.Size = new System.Drawing.Size(800, 28);
            this.menuStripPictureOrganizer.TabIndex = 0;
            this.menuStripPictureOrganizer.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeSettingsToolStripMenuItem,
            this.resetSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changeSettingsToolStripMenuItem
            // 
            this.changeSettingsToolStripMenuItem.Name = "changeSettingsToolStripMenuItem";
            this.changeSettingsToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.changeSettingsToolStripMenuItem.Text = "Change Settings";
            this.changeSettingsToolStripMenuItem.Click += new System.EventHandler(this.changeSettingsToolStripMenuItem_Click);
            // 
            // resetSettingsToolStripMenuItem
            // 
            this.resetSettingsToolStripMenuItem.Name = "resetSettingsToolStripMenuItem";
            this.resetSettingsToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.resetSettingsToolStripMenuItem.Text = "Reset Settings";
            this.resetSettingsToolStripMenuItem.Click += new System.EventHandler(this.resetSettingsToolStripMenuItem_Click);
            // 
            // panelControlContainer
            // 
            this.panelControlContainer.Controls.Add(this.mediaTransfer);
            this.panelControlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlContainer.Location = new System.Drawing.Point(0, 28);
            this.panelControlContainer.Name = "panelControlContainer";
            this.panelControlContainer.Size = new System.Drawing.Size(800, 422);
            this.panelControlContainer.TabIndex = 1;
            // 
            // mediaTransfer
            // 
            this.mediaTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaTransfer.Location = new System.Drawing.Point(0, 0);
            this.mediaTransfer.Name = "mediaTransfer";
            this.mediaTransfer.Size = new System.Drawing.Size(800, 422);
            this.mediaTransfer.TabIndex = 0;
            // 
            // FormPictureOrganizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControlContainer);
            this.Controls.Add(this.menuStripPictureOrganizer);
            this.MainMenuStrip = this.menuStripPictureOrganizer;
            this.Name = "FormPictureOrganizer";
            this.Text = "Picture Organizer";
            this.menuStripPictureOrganizer.ResumeLayout(false);
            this.menuStripPictureOrganizer.PerformLayout();
            this.panelControlContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripPictureOrganizer;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSettingsToolStripMenuItem;
        private System.Windows.Forms.Panel panelControlContainer;
        private Controls.MediaTransfer mediaTransfer;
    }
}

