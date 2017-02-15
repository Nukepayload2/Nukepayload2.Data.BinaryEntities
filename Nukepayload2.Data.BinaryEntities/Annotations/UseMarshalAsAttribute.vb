Imports System.Runtime.InteropServices

Namespace Annotations
    ''' <summary>
    ''' 表示这个结构体即使没有用 <see cref="StructLayoutAttribute"/> 修饰，也应当直接用 <see cref="Marshal.PtrToStructure(Of T)(IntPtr)"/> 或 <see cref="Marshal.StructureToPtr(Of T)(T, IntPtr, Boolean)"/> 进行序列化或反序列化。
    ''' </summary>
    <AttributeUsage(AttributeTargets.Struct)>
    Public Class UseMarshalAsAttribute
        Inherits Attribute

    End Class
End Namespace
