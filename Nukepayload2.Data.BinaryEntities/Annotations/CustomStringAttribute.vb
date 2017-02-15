Imports System.Runtime.InteropServices
Imports System.Text

Namespace Annotations
    ''' <summary>
    ''' 表示当前结构体是某种二进制序列化程序生成的变长字符串。如果是定长字符串，请使用 <see cref="MarshalAsAttribute"/> 指定 <see cref="UnmanagedType.ByValTStr"/>。
    ''' </summary>
    <AttributeUsage(AttributeTargets.Struct)>
    Public Class CustomStringAttribute
        Inherits Attribute

        Sub New(length As FieldBinding, bytes As FieldBinding)
            Me.Length = length
            Me.Bytes = bytes
        End Sub

        ''' <summary>
        ''' 数据数组的元素个数（不包括空白终止字符）。
        ''' </summary>
        Public Property Length As FieldBinding
        ''' <summary>
        ''' 存放字符串的 <see cref="Byte"/> 数组。
        ''' </summary>
        Public Property Bytes As FieldBinding
        ''' <summary>
        ''' 字符串采用哪种编码。如果留空则使用 UTF-8。
        ''' </summary>
        Public Property Encoding As Encoding
        ''' <summary>
        ''' 指示数据在尾部添加了多长的终止字符。默认没有终止字符。
        ''' </summary>
        Public Property TerminatorLength As Integer
    End Class

End Namespace