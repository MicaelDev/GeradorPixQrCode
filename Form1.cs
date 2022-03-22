using System;
using System.Windows.Forms;
using System.IO;
using ImeQrCode;
using QRCoder;

namespace ImeQrCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculaCRC_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string chave = txtChavePix.Text;
            string valor = txtValor.Text;

            int countNome = txtNome.Text.Length;
            int countPix = txtChavePix.Text.Length;
            int countValor = txtValor.Text.Length;
            int countTotal = countPix + 63;

            var text = "00020126" + countTotal.ToString() + "0014br.gov.bcb.pix01" + countPix.ToString() + chave + "0237Ref. fatura 02/2022 Venc.: 11/02/202252040000530398654" + countValor.ToString("00") + valor + "5802BR59" + countNome.ToString() + nome + "6006Cidade62090505Teste6304";

            var textBuffer = System.Text.Encoding.UTF8.GetBytes(text);
            var textCrc = NullFX.CRC.Crc16.ComputeChecksum(NullFX.CRC.Crc16Algorithm.CcittInitialValue0xFFFF, textBuffer);
            string crc16 = string.Format("{0:x}", textCrc).ToUpper();

            var qrCodeKey = text + crc16;
            generateQrCode(qrCodeKey);
        }

        private void generateQrCode(string qrKey)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrKey, QRCodeGenerator.ECCLevel.L);
            QRCode qrCode = new QRCode(qrCodeData);
            pbQrCode.BackgroundImage = qrCode.GetGraphic(3);
        }
    }
}