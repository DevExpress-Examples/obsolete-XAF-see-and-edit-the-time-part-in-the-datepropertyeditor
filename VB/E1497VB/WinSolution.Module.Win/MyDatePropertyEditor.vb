Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Win.Editors
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Model
Imports DevExpress.XtraEditors

Namespace WinSolution.Module.Win
	<PropertyEditor(GetType(DateTime))> _
	Public Class MyDatePropertyEditor
		Inherits DatePropertyEditor
        Public Sub New(ByVal objectType As Type, ByVal item As IModelMemberViewItem)
            MyBase.New(objectType, item)
        End Sub
		Protected Overrides Sub SetupRepositoryItem(ByVal item As DevExpress.XtraEditors.Repository.RepositoryItem)
			MyBase.SetupRepositoryItem(item)
			Dim defaultItem As RepositoryItemDateTimeEdit = CType(item, RepositoryItemDateTimeEdit)
			defaultItem.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True
			defaultItem.VistaEditTime = DevExpress.Utils.DefaultBoolean.True
		End Sub
	End Class
End Namespace
