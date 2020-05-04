using System.IO;

namespace OrganizerMediaLibrary
{
    class OrganizerPicture : IOrganizerMedia
    {
        #region Private Properties
        private FileInfo _pictureInfo;
        #endregion

        #region Public Properties
        public FileInfo PictureInfo
        {
            get
            {
                return _pictureInfo;
            }
        }
        #endregion

        #region Constructors
        public OrganizerPicture(FileInfo fileInfo)
        {
            _pictureInfo = fileInfo;
        }
        #endregion

        #region Public Methods

        #endregion

        #region Private Methods

        #endregion
    }
}
