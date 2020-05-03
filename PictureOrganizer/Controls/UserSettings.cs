using System;
using System.Windows.Forms;

namespace PictureOrganizer
{
    public partial class UserSettings : UserControl
    {
        private Action<Control> CallBack;
        public UserSettings(Action<Control> callBack)
        {
            InitializeComponent();
            CallBack = callBack;
            Init();
        }

        #region Event Handlers
        private void buttonSourceBrowse_Click(object sender, EventArgs e)
        {
            ChangePathSetting("SourcePath");
        }

        private void buttonDestinationBrowse_Click(object sender, EventArgs e)
        {
            ChangePathSetting("DestinationPath");
        }

        private void buttonSaveUserSettings_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            CallBack(this);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            CallBack(this);
        }
        #endregion

        #region Private Methods
        private void Init()
        {
        }

        private void ChangePathSetting(string settingName)
        {
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Settings.Default[settingName] = folderBrowserDialog.SelectedPath;
            }
        }
        #endregion
    }
}
