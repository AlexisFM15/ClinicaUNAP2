Imports ClinicaUNAP.Entity
Imports System.Data.SqlClient

Public Class SeguroDAL

    'Heredamos de la conexion de la base de datos
    Inherits BaseDAL

    'Creamos los metodos CRUD (CREATE, READ, UPDATE, DELETE)

    'METODO CREATE

    Public Shared Sub Create(Seguro As SeguroEntity)
        'crear la conexion a la fuente de la base de datos y abrirla

        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            'Creamos la sentencia SQL para agregar registros

            Dim sql As String = "INSERT INTO Seguro (Nombre ) Values (@nombre ) SELECT SCOPE_IDENTITY()"

            'Creamos el comando cmd con los datos y la conexion

            Dim cmd As New SqlCommand(sql, conex)




            'Agregamos los parametros

            'EJEMPLO cmd.Parameters.AddWithValue("@nombre", articulo.Nombre)
            ' cmd.Parameters.AddWithValue("@idRecinto", recinto.IdRecinto)

            cmd.Parameters.AddWithValue("@nombre", Seguro.Nombre)


            'Lo ejecutamos de manera escalar por el id objeto primario  de la tabla

            'EJEMPLO articulo.ID = Convert.ToInt32(cmd.ExecuteScalar())

            Seguro.IdSeguro = cmd.ExecuteScalar()

        End Using

    End Sub


    'METODO UPDATE

    Public Shared Sub Update(Seguro As SeguroEntity)

        'crear la conexion a la fuente de la base de datos y abrirla

        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            'Creamos la sentencia SQL para agregar registros

            Dim sql As String = "UPDATE Seguro Set Nombre = @nombre  WHERE IdSeguro = @idSeguro"

            'Creamos el comando cmd con los datos y la conexion

            Dim cmd As New SqlCommand(sql, conex)

            'Agregamos los parametros

            'EJEMPLO cmd.Parameters.AddWithValue("@nombre", articulo.Nombre)

            cmd.Parameters.AddWithValue("@nombre", Seguro.Nombre)

            'Lo ejecutamos

            'EJEMPLO cmd.ExecuteNonQuery()

            cmd.ExecuteNonQuery()

        End Using

    End Sub

    'METOD DELETE

    Public Shared Function Delete(id As Integer) As Boolean
        'Creamos una variable que almacenara lo que se va a eliminar tipo boolean

        Dim SeElimino As Boolean

        'Creamos la conexion y la abrimos

        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            'Creamos sentencias SQL para eliminar registros

            Dim sql As String = "DELETE FROM Seguro WHERE IdSeguro"

            'Creamos el comando cmd con los datos y la conexion

            Dim cmd As New SqlCommand(sql, conex)

            'Agregamos los parametros

            cmd.Parameters.AddWithValue("IdSeguro", id)

            'La sentencia se ejecutara y se almacenara en la variable  cuando sea mayor que cero 
            SeElimino = cmd.ExecuteNonQuery() > 0

        End Using

        'Retornar la operacion

        Return SeElimino

    End Function

    'METODO READER

    'Convertir los datos a objetos

    Private Shared Function ConvertToObject(reader As IDataReader) As SeguroEntity

        'Se hace una intancia
        'EJEMPLO  Dim articulo As New ArticuloEntity()

        Dim Seguro As New SeguroEntity

        'Conversion a objetos
        'EJEMPLO articulo.IdCategoria = Convert.ToInt32(reader("IdCategoria"))
        'EJEMPLO articulo.Nombre = reader("Nombre")

        Seguro.IdSeguro = Convert.ToInt32(reader("IdSeguro"))
        Seguro.IdSeguro = reader("Nombre")


        'Se retorna la conversion

        Return Seguro 'La variable instanciada

    End Function

    'Obtener datos de tres manera (por valor, por todos y por id)

    '- POR VALOR

    Public Shared Function GetByValor(valor As String) As List(Of SeguroEntity)

        'Se enlista los objetos en una variable
        'EMJEMPLO Dim list As New List(Of ArticuloEntity)
        Dim list As New List(Of SeguroEntity)

        'Creamos la conexion y la abrimos
        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            'Se realiza la seleccion en SQL y se la pasamos a la variable sql

            Dim sql As String = "SELECT * FROM Seguro WHERE Nombre Like '%'+ @Valor +'%'  ORDER BY Nombre"

            'Creamos el comando cmd con los datos y la conexion

            Dim cmd As New SqlCommand(sql, conex)

            'Agregamos parametro de valor

            cmd.Parameters.AddWithValue("@valor", valor)

            'le pasamos la ejecucion con los registros a la variable reader

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            'Leer el listado y convertirlo a objeto
            While reader.Read()

                list.Add(ConvertToObject(reader))

            End While
        End Using

        'Retornamos el listado con el valor esperado en forma de objeto
        Return list

    End Function

    '- POR TODOS

    Public Shared Function GetAll() As List(Of SeguroEntity)
        'Se enlista los objetos en una variable

        'EMJEMPLO Dim list As New List(Of ArticuloEntity)

        Dim list As New List(Of SeguroEntity)

        'Creamos la conexion y la abrimos

        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            'Se realiza la seleccion en SQL y se la pasamos a la variable sql

            Dim sql As String = "SELECT * FROM Seguro  ORDER BY Nombre"

            'Creamos el comando cmd con los datos y la conexion

            Dim cmd As New SqlCommand(sql, conex)

            'le pasamos la ejecucion con los registros a la variable reader

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            'Mientras haya lectura en ejecucion agregar a la lista los datos convertidos a objetos

            While reader.Read()

                list.Add(ConvertToObject(reader))

            End While
        End Using

        'Retornamos el listado con el valor esperado en forma de objeto

        Return list

    End Function


    '- POR ID

    Public Shared Function GetByID(id As Integer) As SeguroEntity
        'Se hace una intancia igual a nothing

        'EJEMPLO Dim articulo As ArticuloEntity = Nothing

        Dim usuario As SeguroEntity = Nothing

        'Creamos la conexion y la abrimos
        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            'Se realiza la seleccion en SQL y se la pasamos a la variable sql

            'EJEMPLO Dim sql As String = "SELECT * FROM Articulo Where ID=@idArticulo"

            Dim sql As String = "SELECT * FROM Seguro Where IdSeguro = @idSeguro"

            'Creamos el comando cmd con los datos y la conexion

            Dim cmd As New SqlCommand(sql, conex)

            'Agregamos parametro de id primario de la tabla

            'EJEMPLO cmd.Parameters.AddWithValue("@idArticulo", id)

            cmd.Parameters.AddWithValue("@idSeguro", id)

            'le pasamos la ejecucion con los registros a la variable reader

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            'Si hay lectura ejecutada entonces pasar los objetos

            If reader.Read() Then

                'le pasamos la conversion a la instancia creada de tipo entity
                'EJEMPLO  articulo = ConvertToObject(reader)

                usuario = ConvertToObject(reader)

            End If
        End Using

        'Retornar los objetos leidos
        Return usuario

    End Function



End Class
