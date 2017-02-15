''' <summary>
''' 提供绑定信息。
''' </summary>
Public Class FieldBinding
    ''' <summary>
    ''' 初始绑定信息
    ''' </summary>
    ''' <param name="path">绑定路径。例如，结构体 Bug 有 Feets 数组使用了当前 Attribute, 在 Bug 的 Mind 字段中的 FeetsControl 字段中储存了 Count，则绑定路径为：Mind.FeetsControl.Count。</param>
    Sub New(path As String)
        Me.Path = path
    End Sub
    ''' <summary>
    ''' 绑定的路径。
    ''' </summary>
    Public Property Path As String
    ''' <summary>
    ''' 寻找路径之前，应当沿着这个字段的结构体再向上找多少级。
    ''' </summary>
    Public Property ParentLevel As Integer
End Class