Namespace Annotations
    ''' <summary>
    ''' 指示这个结构体中的数据应当用特定的流读取。
    ''' </summary>
    <AttributeUsage(AttributeTargets.Struct)>
    Public Class ReadWithAttribute
        Inherits Attribute

        Sub New(stream As Stream)
            Me.Stream = stream
        End Sub

        Public Property Stream As Stream
    End Class
End Namespace
