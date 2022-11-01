<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128597370/22.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E172)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Reporting for WinForms - Export Options and After Export Actions

This example shows how to specify export options for various export formats, and how to modify export commands to perform additional actions.

- The [DevExpress.XtraPrinting.ExportOptions](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.ExportOptions) stores the document export options for different export formats. 
- The [DevExpress.PrintingSystemBase.AddCommandHandler](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintingSystemBase.AddCommandHandler(DevExpress.XtraPrinting.ICommandHandler)) method allows you to add a custom command.
- The **DevExpress.XtraPrinting.VisualExportTool** class contains methods that work in the same manner as the export commands. 

## Files to Review

- [Form1.cs](CS\ExportOptionSample\Form1.cs) ([VB: Form1.vb](VB\ExportOptionSample\Form1.vb))

## Documentation

- [Printing-Exporting](https://docs.devexpress.com/WindowsForms/2079/controls-and-libraries/printing-exporting)
- [Export Reports](https://docs.devexpress.com/XtraReports/1302/detailed-guide-to-devexpress-reporting/store-and-distribute-reports/export-reports)




