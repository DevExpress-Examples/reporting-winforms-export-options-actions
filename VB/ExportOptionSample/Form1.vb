Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.Text

Namespace ExportOptionSample
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim report = New XtraReport1()

			report.CreateDocument()

			' Obtain the current export options.
			Dim options As ExportOptions = report.PrintingSystem.ExportOptions

			' Set Print Preview options.
			options.PrintPreview.ActionAfterExport = ActionAfterExport.AskUser
			options.PrintPreview.DefaultDirectory = "C:\Temp"
			options.PrintPreview.DefaultFileName = "Report"
			options.PrintPreview.SaveMode = SaveMode.UsingDefaultPath
			options.PrintPreview.ShowOptionsBeforeExport = False

			' Set E-mail options.
			options.Email.RecipientAddress = "someone@somewhere.com"
			options.Email.RecipientName = "Someone"
			options.Email.Subject = "Test"
			options.Email.Body = "Test"

			' Set CSV-specific export options.
			options.Csv.Encoding = Encoding.Unicode
			options.Csv.Separator = CultureInfo.CurrentCulture.TextInfo.ListSeparator.ToString()

			' Set HTML-specific export options.
			options.Html.CharacterSet = "UTF-8"
			options.Html.RemoveSecondarySymbols = False
			options.Html.Title = "Test Title"

			' Set Image-specific export options.
			options.Image.Format = ImageFormat.Jpeg

			' Set MHT-specific export options.
			options.Mht.CharacterSet = "UTF-8"
			options.Mht.RemoveSecondarySymbols = False
			options.Mht.Title = "Test Title"

			' Set PDF-specific export options.
			options.Pdf.Compressed = True
			options.Pdf.ImageQuality = PdfJpegImageQuality.Low
			options.Pdf.NeverEmbeddedFonts = "Tahoma;Courier New"
			options.Pdf.DocumentOptions.Application = "Test Application"
			options.Pdf.DocumentOptions.Author = "Test Team"
			options.Pdf.DocumentOptions.Keywords = "Test1, Test2"
			options.Pdf.DocumentOptions.Subject = "Test Subject"
			options.Pdf.DocumentOptions.Title = "Test Title"

			' Set Text-specific export options.
			options.Text.Encoding = Encoding.Unicode
			options.Text.Separator = CultureInfo.CurrentCulture.TextInfo.ListSeparator.ToString()

			' Set XLS-specific export options.
			options.Xls.ShowGridLines = True
			options.Xls.SheetName = "Page 1"
			options.Xls.TextExportMode = TextExportMode.Value

			' Set XLSX-specific export options.
			options.Xlsx.ShowGridLines = True
			options.Xlsx.SheetName = "Page 1"
			options.Xlsx.TextExportMode = TextExportMode.Value

			report.ShowPreviewDialog()
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			Dim report = New XtraReport1()
			Dim preview = New ReportPrintTool(report)
			preview.PrintingSystem.AddCommandHandler(New CustomPDFExportCommandHandler())
			preview.ShowRibbonPreviewDialog()
		End Sub
	End Class
	Public Class CustomPDFExportCommandHandler
		Implements DevExpress.XtraPrinting.ICommandHandler

		Public Overridable Sub HandleCommand(ByVal command As PrintingSystemCommand, ByVal args() As Object, ByVal printControl As IPrintControl, ByRef handled As Boolean) Implements DevExpress.XtraPrinting.ICommandHandler.HandleCommand
			If Not CanHandleCommand(command, printControl) Then
				Return
			End If

			Dim pdfExportOptions = New PdfExportOptions()
			' You can configure your export options.
			pdfExportOptions.DocumentOptions.Author = "VisualExportTool"
			VisualExportTool.ExportFile(pdfExportOptions, printControl.PrintingSystem)
			' You can add a log entry about the PDF export operation.

			handled = True
		End Sub

		Public Overridable Function CanHandleCommand(ByVal command As PrintingSystemCommand, ByVal printControl As IPrintControl) As Boolean Implements DevExpress.XtraPrinting.ICommandHandler.CanHandleCommand
			Return command = PrintingSystemCommand.ExportPdf
		End Function
	End Class
End Namespace
