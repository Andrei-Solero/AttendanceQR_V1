using AttendanceQRScan.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceQRScan.UInetframework
{
    public partial class QRCodeView : Form
    {
        private readonly string employeeID;
        ImageTools imageTool;
        public QRCodeView(string employeeID)
        {
            InitializeComponent();
            imageTool = new ImageTools();
            this.employeeID = employeeID;
        }

        private void QRCodeView_Load(object sender, EventArgs e)
        {
            empQrCode.Image = Image.FromFile(imageTool.LoadEmployeeQRImage(employeeID));
        }
    }
}
