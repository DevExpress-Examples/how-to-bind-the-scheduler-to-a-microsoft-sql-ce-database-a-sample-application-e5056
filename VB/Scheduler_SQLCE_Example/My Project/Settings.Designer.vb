﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18051
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
Imports System
Namespace My


	<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")> _
	Friend NotInheritable Partial Class Settings
		Inherits System.Configuration.ApplicationSettingsBase

		Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

		Public Shared ReadOnly Property [Default]() As Settings
			Get
				Return defaultInstance
			End Get
		End Property

		<Global.System.Configuration.ApplicationScopedSettingAttribute(), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString), Global.System.Configuration.DefaultSettingValueAttribute("Data Source=.\sqlexpress;Initial Catalog=DXDBScheduler;Integrated Security=True")> _
		Public ReadOnly Property DXDBSchedulerConnectionString() As String
			Get
				Return (CStr(Me("DXDBSchedulerConnectionString")))
			End Get
		End Property

		<Global.System.Configuration.ApplicationScopedSettingAttribute(), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString), Global.System.Configuration.DefaultSettingValueAttribute("Data Source=.\sqlexpress;Initial Catalog=CarsXtraScheduling;Integrated Security=T" & "rue")> _
		Public ReadOnly Property CarsXtraSchedulingConnectionString() As String
			Get
				Return (CStr(Me("CarsXtraSchedulingConnectionString")))
			End Get
		End Property

		<Global.System.Configuration.ApplicationScopedSettingAttribute(), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString), Global.System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\DXDB.mdf;Integrated " & "Security=True;Connect Timeout=30")> _
		Public ReadOnly Property DXDBConnectionString() As String
			Get
				Return (CStr(Me("DXDBConnectionString")))
			End Get
		End Property

		<Global.System.Configuration.ApplicationScopedSettingAttribute(), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString), Global.System.Configuration.DefaultSettingValueAttribute("Data Source=|DataDirectory|\Database1.sdf")> _
		Public ReadOnly Property Database1ConnectionString() As String
			Get
				Return (CStr(Me("Database1ConnectionString")))
			End Get
		End Property

		<Global.System.Configuration.ApplicationScopedSettingAttribute(), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString), Global.System.Configuration.DefaultSettingValueAttribute("Data Source=|DataDirectory|\DXDB.sdf")> _
		Public ReadOnly Property DXDBConnectionString1() As String
			Get
				Return (CStr(Me("DXDBConnectionString1")))
			End Get
		End Property
	End Class
End Namespace