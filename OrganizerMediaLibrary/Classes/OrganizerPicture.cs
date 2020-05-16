using System.IO;

namespace OrganizerMediaLibrary
{
    public class OrganizerPicture : IOrganizerMedia
    {
        #region Private Properties
        private FileInfo _pictureInfo;
        #endregion

        #region Public Properties
        public string Name
        {
            get
            {
                return _pictureInfo.Name;
            }
        }

        public string LastWriteDateUtc
        {
            get
            {
                return _pictureInfo.LastWriteTimeUtc.ToString("yyyy-MM-dd");
            }
        }

        public string Extension
        {
            get
            {
                return _pictureInfo.Extension;
            }
        }

        public long Size
        {
            get
            {
                return _pictureInfo.Length;
            }
        }

        public string FullName
        {
            get
            {
                return _pictureInfo.FullName;
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
        public void MoveTo(string destinationPath)
        {
            _pictureInfo.MoveTo(destinationPath);
        }
        public void CopyTo(string destinationPath)
        {
            _pictureInfo.CopyTo(destinationPath);
        }

        public string GetDatePath()
        {
            string datePath = "No_Date";

            // ToDo: Check to see if there is any other dates we want to look at.
            datePath = LastWriteDateUtc;

            return datePath;
        }
        #endregion

        #region Private Methods

        #endregion
    }
}
