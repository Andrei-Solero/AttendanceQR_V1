using System;
using System.Drawing;
using System.IO;

namespace AttendanceQRScan.Helper
{
    public class ImageTools
    {
        private string LocalDirDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        private void CreateDir(string dir)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        public void SaveQR_Image(Bitmap qrCodeImage, Bitmap empImage, string fileName)
        {
            SaveImageLocalDirectory("Employee QR Codes", qrCodeImage, fileName);
            SaveImageLocalDirectory("Employee Images", empImage, fileName);
        }

        private void SaveImageLocalDirectory(string imageMainDir, Bitmap image, string fileName)
        {
            string mainPath = Path.Combine(LocalDirDocuments, "Attendance Management System QR", imageMainDir);
            CreateDir(mainPath);

            string filePath = Path.Combine(mainPath, $"{fileName}.jpg");

            image.Save(filePath);
        }

        public string LoadEmpployeeImage(string empID)
        {
            return Path.Combine(LocalDirDocuments, "Attendance Management System QR", "Employee Images", $"{empID}.jpg");
        }

    }
}
