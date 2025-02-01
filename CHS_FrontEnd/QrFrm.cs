using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace CHS_FrontEnd
{
    public partial class QrFrm : Form
    {
        string qrData;
        public QrFrm(string qrData)
        {
            InitializeComponent();
            this.qrData = qrData;
        }

        private void QrFrm_Load(object sender, EventArgs e)
        {
            var qr = new BarcodeWriter()
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions()
                {
                    Width = 300,
                    Height = 300,
                    Margin = 2
                }
            };
            pcb.Image = qr.Write(qrData);
        }
    }
}
