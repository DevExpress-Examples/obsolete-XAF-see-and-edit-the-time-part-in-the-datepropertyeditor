Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Win.Editors
Imports DevExpress.ExpressApp
Imports DevExpress.XtraEditors

Namespace WinSolution.Module.Win
	<PropertyEditor(GetType(DateTime))> _
	Public Class MyDatePropertyEditor
		Inherits DatePropertyEditor
		Public Sub New(ByVal objectType As Type, ByVal info As DictionaryNode)
			MyBase.New(objectType, info)
		End Sub
		Protected Overrides Function CreateControlCore() As Object
			Dim control As DateEdit = CType(MyBase.CreateControlCore(), DateEdit)
			SetupRepositoryItemDateTimeEdit(CType(control.Properties, RepositoryItemDateTimeEdit))
			Return control
		End Function
		Protected Overrides Sub SetupRepositoryItem(ByVal item As DevExpress.XtraEditors.Repository.RepositoryItem)
			MyBase.SetupRepositoryItem(item)
			SetupRepositoryItemDateTimeEdit(CType(item, RepositoryItemDateTimeEdit))
		End Sub
		Protected Overridable Sub SetupRepositoryItemDateTimeEdit(ByVal item As RepositoryItemDateTimeEdit)
			item.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True
			item.VistaEditTime = DevExpress.Utils.DefaultBoolean.True
		End Sub
	End Class
End Namespace
