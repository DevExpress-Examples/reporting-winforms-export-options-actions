using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System;
using System.Drawing.Imaging;
using System.Globalization;
using System.Text;

namespace ExportOptionSample {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            var report = new XtraReport1();

            report.CreateDocument();

            // Obtain the current export options.
            ExportOptions options = report.PrintingSystem.ExportOptions;

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
            options.Csv.Separator =
                CultureInfo.CurrentCulture.TextInfo.ListSeparator.ToString();

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
            options.Text.Separator =
                CultureInfo.CurrentCulture.TextInfo.ListSeparator.ToString();

            // Set XLS-specific export options.
            options.Xls.ShowGridLines = true;
            options.Xls.SheetName = "Page 1";
            options.Xls.TextExportMode = TextExportMode.Value;

            // Set XLSX-specific export options.
            options.Xlsx.ShowGridLines = true;
            options.Xlsx.SheetName = "Page 1";
            options.Xlsx.TextExportMode = TextExportMode.Value;

            report.ShowPreviewDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            var report = new XtraReport1();
            var preview = new ReportPrintTool(report);
            preview.PrintingSystem.AddCommandHandler(new CustomPDFExportCommandHandler());
            preview.ShowRibbonPreviewDialog();
        }
    }
    public class CustomPDFExportCommandHandler : DevExpress.XtraPrinting.ICommandHandler {
        public virtual void HandleCommand(PrintingSystemCommand command,
        object[] args, IPrintControl printControl, ref bool handled) {
            if (!CanHandleCommand(command, printControl))
                return;

            var pdfExportOptions = new PdfExportOptions();
            // You can configure your export options.
            pdfExportOptions.DocumentOptions.Author = "VisualExportTool";
            VisualExportTool.ExportFile(pdfExportOptions, printControl.PrintingSystem);
            // You can add a log entry about the PDF export operation.

            handled = true;
        }

        public virtual bool CanHandleCommand(PrintingSystemCommand command, IPrintControl printControl) {
            return command == PrintingSystemCommand.ExportPdf;
        }
    }
}
