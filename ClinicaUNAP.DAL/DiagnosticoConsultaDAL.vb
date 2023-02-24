Imports ClinicaUNAP.Entity
Imports System.Data.SqlClient

Public Class DiagnosticoConsultaDAL
    'Heredamos de la conexion de la base de datos
    Inherits BaseDAL

    'Creamos los metodos CRUD (CREATE, READ, UPDATE, DELETE)

    'METODO CREATE

    Public Shared Sub Create(DiagnosticoConsulta As DiagnosticoConsultaEntity)
        'crear la conexion a la fuente de la base de datos y abrirla

        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            'Creamos la sentencia SQL para agregar registros

            Dim sql As String = "INSERT INTO DiagnosticoConsulta ( Analsis, Evaluacion, IdConsulta) Values (@analisis, @Evaluacion, @IdConsulta) SELECT SCOPE_IDENTITY()"

            'Creamos el comando cmd con los datos y la conexion

            Dim cmd As New SqlCommand(sql, conex)




            'Agregamos los parametros

            'EJEMPLO cmd.Parameters.AddWithValue("@nombre", articulo.Nombre)
            ' cmd.Parameters.AddWithValue("@idRecinto", recinto.IdRecinto)
            cmd.Parameters.AddWithValue("@analisis", DiagnosticoConsulta.Analisis)
            cmd.Parameters.AddWithValue("@evaluacion", DiagnosticoConsulta.Evaluacion)
            cmd.Parameters.AddWithValue("@idConsulta", DiagnosticoConsulta.IdConsulta)


            'Lo ejecutamos de manera escalar por el id objeto primario  de la tabla

            'EJEMPLO articulo.ID = Convert.ToInt32(cmd.ExecuteScalar())

            DiagnosticoConsulta.IdDiagnosticoConsulta = cmd.ExecuteScalar()

        End Using

    End Sub

    'METODO UPDATE

    Public Shared Sub Update(DiagnosticoConsulta As DiagnosticoConsultaEntity)

        'crear la conexion a la fuente de la base de datos y abrirla

        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            'Creamos la sentencia SQL para agregar registros

            Dim sql As String = "UPDATE DiagnosticoConsulta Set IdConsulta = @idconsulta WHERE IdDiagnosticoConsulta = @idDiagnosticoConsulta"

            'Creamos el comando cmd con los datos y la conexion

            Dim cmd As New SqlCommand(sql, conex)

            'Agregamos los parametros

            'EJEMPLO cmd.Parameters.AddWithValue("@nombre", articulo.Nombre)

            cmd.Parameters.AddWithValue("@analisis", DiagnosticoConsulta.Analisis)
            cmd.Parameters.AddWithValue("@evaluacion", DiagnosticoConsulta.Evaluacion)
            cmd.Parameters.AddWithValue("@idConsulta", DiagnosticoConsulta.IdConsulta)
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

            Dim sql As String = "DELETE FROM DiagnosticoConsulta WHERE IdDiagnosticoConsulta"

            'Creamos el comando cmd con los datos y la conexion

            Dim cmd As New SqlCommand(sql, conex)

            'Agregamos los parametros

            cmd.Parameters.AddWithValue("IdDiagnosticoConsulta", id)

            'La sentencia se ejecutara y se almacenara en la variable  cuando sea mayor que cero 
            SeElimino = cmd.ExecuteNonQuery() > 0

        End Using

        'Retornar la operacion

        Return SeElimino

    End Function

    'METODO READER

    'Convertir los datos a objetos

    Private Shared Function ConvertToObject(reader As IDataReader) As DiagnosticoConsultaEntity

        'Se hace una intancia
        'EJEMPLO  Dim articulo As New ArticuloEntity()

        Dim DiagnosticoConsulta As New DiagnosticoConsultaEntity

        'Conversion a objetos
        'EJEMPLO articulo.IdCategoria = Convert.ToInt32(reader("IdCategoria"))
        'EJEMPLO articulo.Nombre = reader("Nombre")
        DiagnosticoConsulta.IdDiagnosticoConsulta = Convert.ToInt32(reader("IdDiagnosticoConsulta"))
        DiagnosticoConsulta.IdConsulta = Convert.ToInt32(reader("IdConsulta"))
        DiagnosticoConsulta.Analisis = reader("Analisis")
        DiagnosticoConsulta.Evaluacion = reader("Evaluacion")



        'Se retorna la conversion

        Return DiagnosticoConsulta 'La variable instanciada

    End Function

    'Obtener datos de tres manera (por valor, por todos y por id)

    '- POR VALOR

    Public Shared Function GetByValor(valor As String) As List(Of DiagnosticoConsultaEntity)

        'Se enlista los objetos en una variable
        'EMJEMPLO Dim list As New List(Of ArticuloEntity)
        Dim list As New List(Of DiagnosticoConsultaEntity)

        'Creamos la conexion y la abrimos
        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            'Se realiza la seleccion en SQL y se la pasamos a la variable sql

            Dim sql As String = "SELECT * FROM DiagnosticoConsulta WHERE IdConsulta Like '%'+ @Valor +'%'  ORDER BY IdConsulta"

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

    Public Shared Function GetAll() As List(Of DiagnosticoConsultaEntity)
        'Se enlista los objetos en una variable

        'EMJEMPLO Dim list As New List(Of ArticuloEntity)

        Dim list As New List(Of DiagnosticoConsultaEntity)

        'Creamos la conexion y la abrimos

        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            'Se realiza la seleccion en SQL y se la pasamos a la variable sql

            Dim sql As String = "SELECT * FROM DiagnosticoConsulta  ORDER BY IdConsulta"

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

    Public Shared Function GetByID(id As Integer) As DiagnosticoConsultaEntity
        'Se hace una intancia igual a nothing

        'EJEMPLO Dim articulo As ArticuloEntity = Nothing

        Dim DiagnosticoConsulta As DiagnosticoConsultaEntity = Nothing

        'Creamos la conexion y la abrimos
        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            'Se realiza la seleccion en SQL y se la pasamos a la variable sql

            'EJEMPLO Dim sql As String = "SELECT * FROM Articulo Where ID=@idArticulo"

            Dim sql As String = "SELECT * FROM DiagnosticoConsulta  Where IdDiagnosticoConsulta  = @idDiagnosticoConsulta "

            'Creamos el comando cmd con los datos y la conexion

            Dim cmd As New SqlCommand(sql, conex)

            'Agregamos parametro de id primario de la tabla

            'EJEMPLO cmd.Parameters.AddWithValue("@idArticulo", id)

            cmd.Parameters.AddWithValue("@idDiagnosticoConsulta ", id)

            'le pasamos la ejecucion con los registros a la variable reader

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            'Si hay lectura ejecutada entonces pasar los objetos

            If reader.Read() Then

                'le pasamos la conversion a la instancia creada de tipo entity
                'EJEMPLO  articulo = ConvertToObject(reader)

                DiagnosticoConsulta = ConvertToObject(reader)

            End If
        End Using

        'Retornar los objetos leidos
        Return DiagnosticoConsulta

    End Function

End Class
