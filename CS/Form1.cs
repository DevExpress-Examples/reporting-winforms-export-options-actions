using System;
using System.Windows.Forms;
using System.Text;
using System.Globalization;
using System.Drawing.Imaging;
using DevExpress.XtraPrinting;
// ...

namespace ExportOpts {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            report.CreateDocument();
            PrintingSystem printingSystem1 = report.PrintingSystem;

            // Obtain the current export options.
            ExportOptions options = printingSystem1.ExportOptions;

            // Set Print Preview options.
            options.PrintPreview.ActionAfterExport = ActionAfterExport.AskUser;
            options.PrintPreview.DefaultDirectory = "C:\\Temp";
            options.PrintPreview.DefaultFileName = "Report";
            options.PrintPreview.SaveMode = SaveMode.UsingDefaultPath;
            options.PrintPreview.ShowOptionsBeforeExport = false;

            // Set E-mail options.
            options.Email.RecipientAddress = "someone@somewhere.com";
            options.Email.RecipientName = "Someone";
            options.Email.Subject = "Test";
            options.Email.Body = "Test";

            // Set CSV-specific export options.
            options.Csv.Encoding = Encoding.Unicode;
            options.Csv.Separator = CultureInfo.CurrentCulture.TextInfo.ListSeparator.ToString();

            // Set HTML-specific export options.
            options.Html.CharacterSet = "UTF-8";
            options.Html.RemoveSecondarySymbols = false;
            options.Html.Title = "Test Title";

            // Set Image-specific export options.
            options.Image.Format = ImageFormat.Jpeg;

            // Set MHT-specific export options.
            options.Mht.CharacterSet = "UTF-8";
            options.Mht.RemoveSecondarySymbols = false;
            options.Mht.Title = "Test Title";

            // Set PDF-specific export options.
            options.Pdf.Compressed = true;
            options.Pdf.ImageQuality = PdfJpegImageQuality.Low;
            options.Pdf.NeverEmbeddedFonts = "Tahoma;Courier New";
            options.Pdf.DocumentOptions.Application = "Test Application";
            options.Pdf.DocumentOptions.Author = "Test Team";
            options.Pdf.DocumentOptions.Keywords = "Test1, Test2";
            options.Pdf.DocumentOptions.Subject = "Test Subject";
            options.Pdf.DocumentOptions.Title = "Test Title";

            // Set Text-specific export options.
            options.Text.Encoding = Encoding.Unicode;
            options.Text.Separator = CultureInfo.CurrentCulture.TextInfo.ListSeparator.ToString();

            // Set XLS-specific export options.
            options.Xls.ShowGridLines = true;
            options.Xls.UseNativeFormat = true;

            // Show the Print Preview form.
            printingSystem1.PreviewFormEx.ShowDialog();
        }

    }
}