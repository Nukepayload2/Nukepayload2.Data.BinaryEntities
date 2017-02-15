Namespace Annotations

    ''' <summary>
    ''' 指示这个字段中的数据从某个字段获取偏移量，然后读取。如果这个字段是数组类型，则指定从某个偏移量数组读取与偏移量数组数量相同的数据。不指定这个特性则会按照声明的顺序读取。
    ''' </summary>
    <AttributeUsage(AttributeTargets.Field)>
    Public Class ReadFromAttribute
        Inherits Attribute

        Sub New(path As FieldBinding)
            Me.Path = path
        End Sub

        Public Property Path As FieldBinding
    End Class

End Namespace