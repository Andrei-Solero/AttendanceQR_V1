using AttendanceQRScan.Helper;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Text;
using QRCoder;
using ZXing.Windows.Compatibility;
using ZXing;

namespace AttendanceQRScan.Services
{
    public class _QRCode
    {
        public Bitmap Generate(string empID)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrData = qrGenerator.CreateQrCode(empID, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrData);

            return qrCode.GetGraphic(20);
        }

        public string? ScanQR(Bitmap qrCode)
        {
            BarcodeReader barcodeReader = new BarcodeReader();
            Result result = barcodeReader.Decode(qrCode);

            return result?.ToString();
        }

    }
}
