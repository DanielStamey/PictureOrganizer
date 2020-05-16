﻿using OrganizerMediaLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PictureOrganizer
{
    public partial class FormPictureOrganizer : Form
    {
        #region Private Properties

        #endregion

        #region Constructors
        public FormPictureOrganizer()
        {
            InitializeComponent();

            Init();
        }

        #endregion

        #region Event Handlers
        private void resetSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Reset();
        }

        private void changeSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenControl(new UserSettings(CloseControl));
        }

        private void ButtonTransfer_Click(object sender, EventArgs e)
        {
            TransferPictures();
        }

        #endregion

        #region Private Methods
        private void Init()
        {
            mediaTransfer.buttonTransfer.Click += ButtonTransfer_Click;
        }

        private void TransferPictures()
        {
            string sourcePath = Settings.Default.SourcePath;
            string destinationPath = Settings.Default.DestinationPath;

            if (Directory.Exists(sourcePath) && Directory.Exists(destinationPath))
            {
                OrganizerPictureService mediaService = new OrganizerPictureService(new DirectoryInfo(sourcePath), new DirectoryInfo(destinationPath));

                foreach (OrganizerPicture sourcePicture in mediaService.SourcePictures)
                {
                    List<OrganizerPicture> possibleDups = mediaService.GetPossibleDuplicates(sourcePicture);
                    if (possibleDups.Count > 0)
                    {
                        HandleDuplicate handleDuplicate = new HandleDuplicate(sourcePicture, possibleDups);
                        DialogResult result = handleDuplicate.ShowDialog();
                        switch (result)
                        {
                            case DialogResult.No:
                                {
                                    continue;
                                }
                            case DialogResult.Cancel:
                                {
                                    return;
                                }
                        }
                    }
                    mediaService.Transfer(sourcePicture);
                }
            }
        }

        private void OpenControl(Control control, string name = "")
        {
            if (!string.IsNullOrEmpty(name))
            {
                control.Name = name;
            }
            control.Dock = DockStyle.Fill;
            panelControlContainer.Controls.Add(control);
        }

        private void CloseControl(Control control)
        {
            panelControlContainer.Controls.Remove(control);
        }
        #endregion

    }
}
