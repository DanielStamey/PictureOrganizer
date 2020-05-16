namespace PictureOrganizer
{
    partial class HandleDuplicate
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
            this.flowLayoutPanelDuplicateImages = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSourcePhoto = new System.Windows.Forms.Panel();
            this.pictureBoxSource = new System.Windows.Forms.PictureBox();
            this.panelHandleDuplicatesControl = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.panelSourcePhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).BeginInit();
            this.panelHandleDuplicatesControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelDuplicateImages
            // 
            this.flowLayoutPanelDuplicateImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDuplicateImages.Location = new System.Drawing.Point(0, 102);
            this.flowLayoutPanelDuplicateImages.Name = "flowLayoutPanelDuplicateImages";
            this.flowLayoutPanelDuplicateImages.Size = new System.Drawing.Size(710, 356);
            this.flowLayoutPanelDuplicateImages.TabIndex = 2;
            // 
            // panelSourcePhoto
            // 
            this.panelSourcePhoto.Controls.Add(this.pictureBoxSource);
            this.panelSourcePhoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSourcePhoto.Location = new System.Drawing.Point(0, 0);
            this.panelSourcePhoto.Name = "panelSourcePhoto";
            this.panelSourcePhoto.Size = new System.Drawing.Size(710, 102);
            this.panelSourcePhoto.TabIndex = 4;
            // 
            // pictureBoxSource
            // 
            this.pictureBoxSource.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxSource.Location = new System.Drawing.Point(255, 3);
            this.pictureBoxSource.MaximumSize = new System.Drawing.Size(200, 0);
            this.pictureBoxSource.MinimumSize = new System.Drawing.Size(200, 95);
            this.pictureBoxSource.Name = "pictureBoxSource";
            this.pictureBoxSource.Size = new System.Drawing.Size(200, 95);
            this.pictureBoxSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSource.TabIndex = 2;
            this.pictureBoxSource.TabStop = false;
            // 
            // panelHandleDuplicatesControl
            // 
            this.panelHandleDuplicatesControl.Controls.Add(this.buttonCancel);
            this.panelHandleDuplicatesControl.Controls.Add(this.buttonMove);
            this.panelHandleDuplicatesControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHandleDuplicatesControl.Location = new System.Drawing.Point(0, 458);
            this.panelHandleDuplicatesControl.Name = "panelHandleDuplicatesControl";
            this.panelHandleDuplicatesControl.Size = new System.Drawing.Size(710, 29);
            this.panelHandleDuplicatesControl.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancel.Location = new System.Drawing.Point(560, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 29);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMove.Location = new System.Drawing.Point(635, 0);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 29);
            this.buttonMove.TabIndex = 1;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // HandleDuplicate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 487);
            this.Controls.Add(this.flowLayoutPanelDuplicateImages);
            this.Controls.Add(this.panelSourcePhoto);
            this.Controls.Add(this.panelHandleDuplicatesControl);
            this.Name = "HandleDuplicate";
            this.Text = "HandleDuplicate";
            this.panelSourcePhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).EndInit();
            this.panelHandleDuplicatesControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDuplicateImages;
        private System.Windows.Forms.Panel panelSourcePhoto;
        private System.Windows.Forms.PictureBox pictureBoxSource;
        private System.Windows.Forms.Panel panelHandleDuplicatesControl;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonMove;
    }
}