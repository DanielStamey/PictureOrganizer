using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace OrganizerMediaLibrary
{
    public class OrganizerPictureService : IOrganizerMediaService
    {
        #region Fields
        private const string _pictureExtensionRegex = "([.](jpeg|jpg|png|bmp|tiff))$";
        private string _basePath;
        #endregion

        #region Properties
        public List<OrganizerPicture> SourcePictures { get; }
        public List<OrganizerPicture> DestinationPictures { get; }
        public string SubDirectory { get; set; } = "Pictures";
        public int FileSizeThreshold { get; set; } = 500;
        public string TransferAction { get; set; } = "Move";

        #endregion

        #region Constructors
        public OrganizerPictureService(DirectoryInfo sourceDirectory, DirectoryInfo destinationDirectory)
        {
            _basePath = destinationDirectory.FullName;
            SourcePictures = GetAllPicturesFromDirectory(sourceDirectory).ToList();
            DestinationPictures = GetAllPicturesFromDirectory(destinationDirectory).ToList();
        }
        #endregion

        #region Public Methods
        public IEnumerable<OrganizerPicture> GetAllPicturesFromDirectory(string path)
        {
            if(Directory.Exists(path))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                return GetAllPicturesFromDirectory(directoryInfo);
            }

            return new List<OrganizerPicture>();
        }

        public IEnumerable<OrganizerPicture> GetAllPicturesFromDirectory(DirectoryInfo path)
        {
            List<OrganizerPicture> files = new List<OrganizerPicture>();

            files = path.GetFiles()
                    .Where(f => Regex.IsMatch(f.Name, _pictureExtensionRegex, RegexOptions.IgnoreCase))
                    .Select(f => new OrganizerPicture(f))
                    .ToList();

            DirectoryInfo[] directories = path.GetDirectories();
            foreach (DirectoryInfo di in directories)
            {
                files.AddRange(GetAllPicturesFromDirectory(di));
            }

            return files;
        }

        public List<OrganizerPicture> GetPossibleDuplicates(OrganizerPicture sourcePicture)
        {
            // ToDo: This will be a huge part of the work for this application.

            long maxSize = sourcePicture.Size + FileSizeThreshold;
            long minSize = sourcePicture.Size - FileSizeThreshold;
            List<OrganizerPicture> possibleDuplicates = DestinationPictures
                .Where(d => (d.Size < maxSize && d.Size > minSize))
                .ToList();
            
            return possibleDuplicates;
        }

        public void Transfer(OrganizerPicture picture)
        {
            if(TransferAction == "Move")
            {
                picture.MoveTo(GetDestinationFullName(picture));
            }
            else if (TransferAction == "Copy")
            {
                picture.CopyTo(GetDestinationFullName(picture));
            }
            DestinationPictures.Add(picture);
        }

        #endregion

        #region Private Methods
        private string GetDestinationFullName(OrganizerPicture organizerPicture)
        {
            string directory = GetDestinationDirectory(organizerPicture);
            string name = GetDestinationName(directory, organizerPicture.Name);
            return $"{directory}\\{name}";
        }
        private string GetDestinationDirectory(OrganizerPicture organizerPicture)
        {
            string destinationDirectory = $"{_basePath}{(!string.IsNullOrEmpty(SubDirectory) ? $"\\{SubDirectory}\\" : "\\")}{organizerPicture.GetDatePath()}";
            
            if (!Directory.Exists(destinationDirectory))
            {
                Directory.CreateDirectory(destinationDirectory);
            }
            return destinationDirectory;
        }

        private string GetDestinationName(string basePath, string name)
        {
            string fullName = $"{basePath}\\{name}";
            if (File.Exists(fullName))
            {
                string newName = Regex.Replace(name, _pictureExtensionRegex, "(1)$1", RegexOptions.IgnoreCase);
                return GetDestinationName(basePath, newName);
            }
            return name;
        }

        #endregion
    }
}
