Namespace Annotations
    ''' <summary>
    ''' 用于标记变长的数组的长度。
    ''' </summary>
    <AttributeUsage(AttributeTargets.Field)>
    Public Class CustomArrayAttribute
        Inherits Attribute

        ''' <summary>
        ''' 数组的元素个数。
        ''' </summary>
        Public Property Length As FieldBinding
    End Class
End Namespace