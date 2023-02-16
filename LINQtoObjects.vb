Public Class LINQtoObjects

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLINQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLINQ.Click
        ' Declaramos la matriz y la inicializamos con valores
        Dim material() As String = {"mesa", "reloj", "libro", "pluma", "borrador", "pelota", "botella"}
        ' Ejecutamos LINQ para obtener los datos buscados
        ' Concretamente, buscamos los materiales que empiezan por "b"
        Dim materialBuscado = From busqueda In material _
        Where busqueda.StartsWith("b") _
        Select busqueda  ' es una coleccion de datos del arreglo creada aqui mismo
        ' En materialBuscado tendremos toda la seleccirealizada, por(lo)
        ' que deberemos recorrerla para extraer los elementos encontrados()
        Dim resultado As String = ""
        For Each elementos In materialBuscado
            resultado &= elementos & vbCrLf  ' salta al final de la linea a la siguiente y vuelve a imprimir en pantalla 
        Next
        ' Mostramos la información
        MessageBox.Show(resultado)
    End Sub

    Private Sub LINQtoObjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
