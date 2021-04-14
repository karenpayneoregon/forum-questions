Option Infer On

Imports System
Imports System.Globalization
Imports System.Windows.Forms

Namespace BasicExample.DataGridViewColumns
	''' <summary>
	''' Provides a calendar column for the DataGridView control.
	''' Original code from Microsoft https://tinyurl.com/y8nr9okh
	''' </summary>
	Public Class CalendarColumn
		Inherits DataGridViewColumn

		Public Sub New()
			MyBase.New(New CalendarCell())
		End Sub
		Public Overrides Property CellTemplate() As DataGridViewCell
			Get
				Return MyBase.CellTemplate
			End Get
			Set(ByVal value As DataGridViewCell)
				If value IsNot Nothing AndAlso Not (value.GetType().IsAssignableFrom(GetType(CalendarCell))) Then
					Throw New InvalidCastException("Must be a CalendarCell")
				End If

				MyBase.CellTemplate = value
			End Set
		End Property
	End Class
	Public Class CalendarCell
		Inherits DataGridViewTextBoxCell

		Public Sub New()
			EmptyDate = DateTime.Now
		End Sub
		''' <summary>
		''' Set default Date
		''' </summary>
		Public Property EmptyDate() As DateTime

		Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, ByVal initialFormattedValue As Object, ByVal dataGridViewCellStyle As DataGridViewCellStyle)
			MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)
			Dim theControl = CType(DataGridView.EditingControl, CalendarEditingControl)

			If Convert.IsDBNull(Value) OrElse (Value Is Nothing) Then
				theControl.Value = DateTime.Now
			Else
				theControl.Value = Convert.ToDateTime(Value)
			End If

		End Sub
		Public Overrides ReadOnly Property EditType() As Type
			Get
				Return GetType(CalendarEditingControl)
			End Get
		End Property
		Public Overrides ReadOnly Property ValueType() As Type
			Get
				Return GetType(DateTime)
			End Get
		End Property
		Public Overrides ReadOnly Property DefaultNewRowValue() As Object
			Get
				Return DateTime.Now
			End Get
		End Property
	End Class
	''' <summary>
	''' Provides Calendar popup within the DataGridView.
	''' </summary>
	''' <remarks></remarks>
	Friend Class CalendarEditingControl
		Inherits DateTimePicker
		Implements IDataGridViewEditingControl

		Private _dataGridViewControl As DataGridView
		Private _valueChanged As Boolean = False
		Private _rowIndexNumber As Integer

		Public Sub New()
			Format = DateTimePickerFormat.Short
		End Sub

		Public Property EditingControlFormattedValue() As Object Implements IDataGridViewEditingControl.EditingControlFormattedValue
			Get
				Return Value.ToShortDateString()
			End Get
			Set(ByVal value As Object)
				If TypeOf value Is String Then
					value = DateTime.Parse(Convert.ToString(value))
				End If
			End Set
		End Property
		Public Function GetEditingControlFormattedValue(ByVal context As DataGridViewDataErrorContexts) As Object Implements IDataGridViewEditingControl.GetEditingControlFormattedValue
			Return Value.ToString(CultureInfo.InvariantCulture)
		End Function
		Public Sub ApplyCellStyleToEditingControl(ByVal dataGridViewCellStyle As DataGridViewCellStyle) Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl
			Font = dataGridViewCellStyle.Font
			CalendarForeColor = dataGridViewCellStyle.ForeColor
			CalendarMonthBackground = dataGridViewCellStyle.BackColor
		End Sub

		''' <inheritdoc />
		Public Property EditingControlRowIndex() As Integer Implements IDataGridViewEditingControl.EditingControlRowIndex
			Get
				Return _rowIndexNumber
			End Get
			Set(ByVal value As Integer)
				_rowIndexNumber = value
			End Set
		End Property
		Public Function EditingControlWantsInputKey(ByVal key As Keys, ByVal dataGridViewWantsInputKey As Boolean) As Boolean Implements IDataGridViewEditingControl.EditingControlWantsInputKey
			If ((key And Keys.KeyCode) = Keys.Left) OrElse ((key And Keys.KeyCode) = Keys.Up) OrElse ((key And Keys.KeyCode) = Keys.Down) OrElse ((key And Keys.KeyCode) = Keys.Right) OrElse ((key And Keys.KeyCode) = Keys.Home) OrElse ((key And Keys.KeyCode) = Keys.End) OrElse ((key And Keys.KeyCode) = Keys.PageDown) OrElse ((key And Keys.KeyCode) = Keys.PageUp) Then
				Return True
			Else
				Return False
			End If
		End Function
		Public Sub PrepareEditingControlForEdit(ByVal selectAll As Boolean) Implements IDataGridViewEditingControl.PrepareEditingControlForEdit
		End Sub
		Public ReadOnly Property RepositionEditingControlOnValueChange() As Boolean Implements IDataGridViewEditingControl.RepositionEditingControlOnValueChange
			Get
				Return False
			End Get
		End Property

		Public Property EditingControlDataGridView() As DataGridView Implements IDataGridViewEditingControl.EditingControlDataGridView
			Get
				Return _dataGridViewControl
			End Get
			Set(ByVal value As DataGridView)
				_dataGridViewControl = value
			End Set
		End Property
		Public Property EditingControlValueChanged() As Boolean Implements IDataGridViewEditingControl.EditingControlValueChanged
			Get
				Return _valueChanged
			End Get
			Set(ByVal value As Boolean)
				_valueChanged = value
			End Set
		End Property
		Private ReadOnly Property IDataGridViewEditingControl_EditingPanelCursor() As Cursor Implements IDataGridViewEditingControl.EditingPanelCursor
			Get
				Return EditingControlCursor
			End Get
		End Property
		Public ReadOnly Property EditingControlCursor() As Cursor
			Get
				Return MyBase.Cursor
			End Get
		End Property
		Protected Overrides Sub OnValueChanged(ByVal eventArgs As EventArgs)
			_valueChanged = True
			EditingControlDataGridView.NotifyCurrentCellDirty(True)
			MyBase.OnValueChanged(eventArgs)
		End Sub
	End Class
End Namespace
