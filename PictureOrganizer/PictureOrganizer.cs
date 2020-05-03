using System;
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
        
        #endregion

        #region Private Methods
        private void Init()
        {
            
        }

        private void OpenControl(Control control, string name = "")
        {
            if(!string.IsNullOrEmpty(name))
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
