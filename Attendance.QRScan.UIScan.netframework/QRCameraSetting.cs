using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance.QRScan.UIScan.netframework
{
    public partial class QRCameraSetting : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public QRCameraSetting()
        {
            InitializeComponent();
        }

        private void QRCameraSetting_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cmbDevice.Items.Add(filterInfo.Name);
            }

            cmbDevice.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string deviceMonikerString = filterInfoCollection[cmbDevice.SelectedIndex].MonikerString;
            QRScanning qrForm = new QRScanning(deviceMonikerString);
            qrForm.Show();
            //this.Hide();
        }
    }
}
