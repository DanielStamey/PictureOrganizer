using OrganizerMediaLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PictureOrganizer
{
    public partial class HandleDuplicate : Form
    {
        private OrganizerPicture _sourcePicture;
        private List<OrganizerPicture> _possibleDups;

        public HandleDuplicate(OrganizerPicture sourcePicture, List<OrganizerPicture> possibleDups)
        {
            InitializeComponent();

            _sourcePicture = sourcePicture;
            _possibleDups = possibleDups;

            Init();
        }

        private void Init()
        {
            pictureBoxSource.Load(_sourcePicture.FullName);
            foreach(OrganizerPicture pic in _possibleDups)
            {
                flowLayoutPanelDuplicateImages.Controls.Add(BuildPictureBox(pic));
            }
        }

        private PictureBox BuildPictureBox(OrganizerPicture pic)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new System.Drawing.Size(100, 100);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Load(pic.FullName);

            return pictureBox;
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
