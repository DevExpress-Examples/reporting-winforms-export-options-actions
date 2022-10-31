# Reporting for WinForms - Export Options and After Export Actions

This example shows how to specify export options for various export formats, and how to modify export commands to perform additional actions.

- The [DevExpress.XtraPrinting.ExportOptions](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.ExportOptions) stores the document export options for different export formats. 
- The [DevExpress.PrintingSystemBase.AddCommandHandler](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintingSystemBase.AddCommandHandler(DevExpress.XtraPrinting.ICommandHandler)) method allows you to add a custom command.
- The [DevExpress.XtraPrinting.VisualExportTool](VisualExportTool) class contains methods that work in the same manner as the export commands. 

## Files to Review

- [Form1.cs](CS\ExportOptionSample\Form1.cs) ([VB: Form1.vb](VB\ExportOptionSample\Form1.vb))

## Documentation

- [Printing-Exporting](https://docs.devexpress.com/WindowsForms/2079/controls-and-libraries/printing-exporting)
- [Export Reports](https://docs.devexpress.com/XtraReports/1302/detailed-guide-to-devexpress-reporting/store-and-distribute-reports/export-reports)




