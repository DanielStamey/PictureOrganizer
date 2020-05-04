using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace OrganizerMediaLibrary
{
    public class OrganizerMediaService : IOrganizerMediaService
    {
        #region Fields
        const string _pictureRegex = ".*[.](jpeg|jpg|png|bmp|tiff)$";
        #endregion

        #region Properties
        // public List<OrganizerPicture> SourceFiles { get; set; }
        // public List<OrganizerPicture> DestinationFiles { get; set; }
        #endregion

        #region Constructors
        public OrganizerMediaService()
        {

        }
        #endregion

        #region Public Methods
        public void TransferPictures(string sourcePath, string destinationPath)
        {
            List<OrganizerPicture> sourcePictures = GetAllPictures(sourcePath).ToList();
            List<OrganizerPicture> destinationPictures = GetAllPictures(destinationPath).ToList();


        }
        #endregion

        #region Private Methods
        private IEnumerable<OrganizerPicture> GetAllPictures(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            List<OrganizerPicture> files = directoryInfo.GetFiles()
                .Where(f => Regex.IsMatch(f.Name, _pictureRegex, RegexOptions.IgnoreCase))
                .Select(f => new OrganizerPicture(f))
                .ToList();

            DirectoryInfo[] directories = directoryInfo.GetDirectories();
            foreach(DirectoryInfo di in directories)
            {
                files.AddRange(GetAllPictures(di.FullName));
            }

            return files;
        }
        #endregion
    }
}
