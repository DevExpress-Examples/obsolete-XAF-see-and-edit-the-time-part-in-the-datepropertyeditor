<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/134076051/11.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1497)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Model.DesignedDiffs.xafml](./CS/WinSolution.Module.Win/Model.DesignedDiffs.xafml) (VB: [Model.DesignedDiffs.xafml](./VB/WinSolution.Module.Win/Model.DesignedDiffs.xafml))
* [MyDatePropertyEditor.cs](./CS/WinSolution.Module.Win/MyDatePropertyEditor.cs) (VB: [MyDatePropertyEditor.vb](./VB/WinSolution.Module.Win/MyDatePropertyEditor.vb))
* [Updater.cs](./CS/WinSolution.Module.Win/Updater.cs) (VB: [Updater.vb](./VB/WinSolution.Module.Win/Updater.vb))
* [WinModule.cs](./CS/WinSolution.Module.Win/WinModule.cs) (VB: [WinModule.vb](./VB/WinSolution.Module.Win/WinModule.vb))
* [DomainObject1.cs](./CS/WinSolution.Module/DomainObject1.cs) (VB: [DomainObject1.vb](./VB/WinSolution.Module/DomainObject1.vb))
* [Model.DesignedDiffs.xafml](./CS/WinSolution.Module/Model.DesignedDiffs.xafml) (VB: [Model.DesignedDiffs.xafml](./VB/WinSolution.Module/Model.DesignedDiffs.xafml))
* [Module.cs](./CS/WinSolution.Module/Module.cs) (VB: [Module.vb](./VB/WinSolution.Module/Module.vb))
* [Updater.cs](./CS/WinSolution.Module/Updater.cs) (VB: [Updater.vb](./VB/WinSolution.Module/Updater.vb))
* [Model.xafml](./CS/WinSolution.Win/Model.xafml) (VB: [Model.xafml](./VB/WinSolution.Win/Model.xafml))
* [Program.cs](./CS/WinSolution.Win/Program.cs) (VB: [Program.vb](./VB/WinSolution.Win/Program.vb))
* [WinApplication.cs](./CS/WinSolution.Win/WinApplication.cs) (VB: [WinApplication.vb](./VB/WinSolution.Win/WinApplication.vb))
<!-- default file list end -->
# OBSOLETE - How to see and edit the time part in the DatePropertyEditor for the System.DateTime property


<p><strong>==============================</strong><br><strong>This example is now obsolete. Refer to the <a href="https://www.devexpress.com/Support/Center/p/T411714">How to view and edit only time values without the date part using the WinForms TimeEdit and ASP.NET WebForms ASPxTimeEdit components</a> help topic instead.</strong><br><strong>==============================</strong><br><br>This example demonstrates how to implement a custom PropertyEditor based on the standard one. Here we inherited our editor from the DatePropertyEditor and changed its default behavior to enable Vista style of the editor. This editor will be used for the DateTime property of our business class. We also changed the default display and edit format options to allow entering the time part, not only the date part. To learn more about formatting, please check out MSDN as well as the XtraEditors documentation at:<br> <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument587">Formatting</a>.</p>
<p><strong>IMPORTANT NOTE</strong><br> By default, the CreatedOn property of the DomainObject1 class is formatted using en-US culture settings. So, you might want to modify the EditMask and DisplayFormat to reflect the specifics of your culture.<br> For instance, you might want to change the hh part in the default mask to HH if your culture formatting settings assume hours to be in a 24-hour format.</p>
<p><strong>See Also:</strong><br> <a href="http://documentation.devexpress.com/#Xaf/CustomDocument3014">Built-in Property Editors</a><br> <a href="http://documentation.devexpress.com/#Xaf/CustomDocument3097">Implement Custom Property Editors</a><br> <a href="http://documentation.devexpress.com/#Xaf/CustomDocument3104">How to: Extend Built-in Property Editor's Functionality</a></p>

<br/>


