Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Text
Imports System.Globalization
Imports System.Drawing.Imaging
Imports DevExpress.XtraPrinting
' ...

Namespace ExportOpts
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim report As New XtraReport1()
			report.CreateDocument()
			Dim printingSystem1 As PrintingSystem = report.PrintingSystem

			' Obtain the current export options.
			Dim options As ExportOptions = printingSystem1.ExportOptions

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
			options.Xls.UseNativeFormat = True

			' Show the Print Preview form.
			printingSystem1.PreviewFormEx.ShowDialog()
		End Sub

	End Class
End Namespace