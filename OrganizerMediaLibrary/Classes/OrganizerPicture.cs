using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace OrganizerMediaLibrary
{
    public class OrganizerPicture : IOrganizerMedia
    {
        #region Private Properties
        private FileInfo _pictureInfo;
        private string _hash;
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

        public string Hash
        {
            get
            {
                if (string.IsNullOrEmpty(_hash))
                {
                    using (Bitmap bitmap = (Bitmap)Image.FromFile(FullName))
                    {
                        _hash = GetHash(bitmap);
                    }
                }

                return _hash;
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
        private string GetHash(Bitmap bitmap)
        {
            // Shrink the original image and display the result.
            Bitmap shrunk_bm = ScaleTo(bitmap, 9, 9, InterpolationMode.High);

            // Convert to grayscale and display the result.
            Bitmap grayscale_bm = ToMonochrome(shrunk_bm);

            // Calculate the hash code.
            return GetHashCode(grayscale_bm);
        }

        private Bitmap ScaleTo(Bitmap bm, int wid, int hgt, InterpolationMode interpolation_mode)
        {
            Bitmap new_bm = new Bitmap(wid, hgt);
            using (Graphics gr = Graphics.FromImage(new_bm))
            {
                RectangleF source_rect = new RectangleF(-0.5f, -0.5f, bm.Width, bm.Height);
                Rectangle dest_rect = new Rectangle(0, 0, wid, hgt);
                gr.InterpolationMode = interpolation_mode;
                gr.DrawImage(bm, dest_rect, source_rect, GraphicsUnit.Pixel);
            }
            return new_bm;
        }

        private Bitmap ToMonochrome(Image image)
        {
            // Make the ColorMatrix.
            ColorMatrix cm = new ColorMatrix(new float[][]
            {
                new float[] {0.299f, 0.299f, 0.299f, 0, 0},
                new float[] {0.587f, 0.587f, 0.587f, 0, 0},
                new float[] {0.114f, 0.114f, 0.114f, 0, 0},
                new float[] { 0, 0, 0, 1, 0},
                new float[] { 0, 0, 0, 0, 1}
            });
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(cm);

            // Draw the image onto the new bitmap while
            // applying the new ColorMatrix.
            Point[] points =
            {
                new Point(0, 0),
                new Point(image.Width, 0),
                new Point(0, image.Height),
            };
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

            // Make the result bitmap.
            Bitmap bm = new Bitmap(image.Width, image.Height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.DrawImage(image, points, rect,
                    GraphicsUnit.Pixel, attributes);
            }

            // Return the result.
            return bm;
        }

        private string GetHashCode(Bitmap bm)
        {
            string row_hash = "";
            for (int r = 0; r < 8; r++)
                for (int c = 0; c < 8; c++)
                    if (bm.GetPixel(c + 1, r).R >= bm.GetPixel(c, r).R)
                        row_hash += "1";
                    else
                        row_hash += "0";

            string col_hash = "";
            for (int c = 0; c < 8; c++)
                for (int r = 0; r < 8; r++)
                    if (bm.GetPixel(c, r + 1).R >= bm.GetPixel(c, r).R)
                        col_hash += "1";
                    else
                        col_hash += "0";

            return row_hash + "," + col_hash;
        }
        #endregion
    }
}
