using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.QrCode;
using ZXing;

namespace QuanLiQuanAnA
{
    public partial class QrCodeForm : Form
    {
        public bool IsPaid { get; private set; }
        public QrCodeForm(string qrCodeData)
        {
            InitializeComponent();
            GenerateQrCode(qrCodeData);

        }
       
       

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        private void GenerateQrCode(string data)
        {
            try
            {
                var writer = new BarcodeWriter
                {
                    Format = BarcodeFormat.QR_CODE,
                    Options = new ZXing.Common.EncodingOptions
                    {
                        Width = 300,
                        Height = 300,
                        Margin = 1
                    }
                };

                using (var qrCode = writer.Write(data))
                {
                    pictureBoxQRCode.Image = new Bitmap(qrCode);
                    pictureBoxQRCode.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tạo mã QR: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
