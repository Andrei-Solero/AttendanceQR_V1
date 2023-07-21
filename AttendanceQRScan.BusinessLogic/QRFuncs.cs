using AttendanceQRScan.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AttendanceQRScan.BusinessLogic
{
    public class QRFuncs
    {
        _QRCode qrCode;
        public QRFuncs()
        {
            qrCode = new _QRCode();
        }

        public string QRReadResult(Bitmap qrCodeImage)
        {
            return qrCode.ScanQR(qrCodeImage);
        }
    }
}
