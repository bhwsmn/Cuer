using System.Drawing;
using QRCoder;

namespace Cuer.Services
{
    public class CuerService
    {
        private readonly QRCodeGenerator _qrCodeGenerator;

        public CuerService(QRCodeGenerator qrCodeGenerator)
        {
            _qrCodeGenerator = qrCodeGenerator;
        }
        
        /// <summary>
        /// Generate SVG String of the qr for the given text
        /// </summary>
        /// <param name="text">The text to generate the QR</param>
        /// <returns>SVG Image String of generated QR</returns>
        public string GenerateSvgString(string text)
        {
            var qrCodeData = _qrCodeGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.H);
            var qrCodeSvg = new SvgQRCode(qrCodeData);
            
            var svgString = qrCodeSvg.GetGraphic(
                viewBox: new Size(width: 1, height: 1),
                drawQuietZones: true,
                sizingMode: SvgQRCode.SizingMode.ViewBoxAttribute
            );

            return svgString;
        }
    }
}