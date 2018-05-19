Imports Microsoft.VisualBasic
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports System

Namespace WinSolution.Module
	<DefaultClassOptions> _
	Public Class DomainObject1
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private _createdOn As DateTime
		<Custom("DisplayFormat", "{0: ddd, dd MMMM yyyy hh:mm:ss tt}"), Custom("EditMask", "ddd, dd MMMM yyyy hh:mm:ss tt"), Custom("PropertyEditorType", "WinSolution.Module.Win.MyDatePropertyEditor")> _
		Public Property CreatedOn() As DateTime
			Get
				Return _createdOn
			End Get
			Set(ByVal value As DateTime)
				SetPropertyValue("CreatedOn", _createdOn, value)
			End Set
		End Property
	End Class
End Namespace
