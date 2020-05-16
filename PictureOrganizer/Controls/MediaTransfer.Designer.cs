namespace PictureOrganizer.Controls
{
    partial class MediaTransfer
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
            this.panelTransferControls = new System.Windows.Forms.Panel();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.panelTransferControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTransferControls
            // 
            this.panelTransferControls.Controls.Add(this.buttonTransfer);
            this.panelTransferControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTransferControls.Location = new System.Drawing.Point(0, 375);
            this.panelTransferControls.Name = "panelTransferControls";
            this.panelTransferControls.Size = new System.Drawing.Size(435, 29);
            this.panelTransferControls.TabIndex = 4;
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonTransfer.Location = new System.Drawing.Point(360, 0);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(75, 29);
            this.buttonTransfer.TabIndex = 1;
            this.buttonTransfer.Text = "Transfer";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            // 
            // MediaTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTransferControls);
            this.Name = "MediaTransfer";
            this.Size = new System.Drawing.Size(435, 404);
            this.panelTransferControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTransferControls;
        public System.Windows.Forms.Button buttonTransfer;
    }
}
