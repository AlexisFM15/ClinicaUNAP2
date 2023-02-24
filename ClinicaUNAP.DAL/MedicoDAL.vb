Imports ClinicaUNAP.Entity
Imports System.Data.SqlClient

Public Class MedicoDAL

    'Heredamos de la conexion de la base de datos
    Inherits BaseDAL

    'Creamos los metodos CRUD (CREATE, READ, UPDATE, DELETE)

    'METODO CREATE

    Public Shared Sub Create(medico As MedicoEntity)
        'crear la conexion a la fuente de la base de datos y abrirla

        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            'Creamos la sentencia SQL para agregar registros

            Dim sql As String = "INSERT INTO Medico ( IdRecinto, IdEspecialidad, Nombre, Apellido, Cedula, Direccion, Telefono, Edad) Values (@idRecinto, @idEspecialidad, @nombre, @apellido, @cedula, @direccion, @telefono, @edad ) SELECT SCOPE_IDENTITY()"

            'Creamos el comando cmd con los datos y la conexion

            Dim cmd As New SqlCommand(sql, conex)




            'Agregamos los parametros

            'EJEMPLO cmd.Parameters.AddWithValue("@nombre", articulo.Nombre)
            ' cmd.Parameters.AddWithValue("@idRecinto", recinto.IdRecinto)

            cmd.Parameters.AddWithValue("@nombre", medico.Nombre)
            cmd.Parameters.AddWithValue("@apellido", medico.Apellido)
            cmd.Parameters.AddWithValue("@cedula", medico.Cedula)
            cmd.Parameters.AddWithValue("@direccion", medico.Direccion)
            cmd.Parameters.AddWithValue("@telefono", medico.Telefono)
            cmd.Parameters.AddWithValue("@edad", medico.Edad)
            cmd.Parameters.AddWithValue("@idRecinto", medico.IdRecinto)
            cmd.Parameters.AddWithValue("@idEspecialidad", medico.IdEspecialidad)

            'Lo ejecutamos de manera escalar por el id objeto primario  de la tabla

            'EJEMPLO articulo.ID = Convert.ToInt32(cmd.ExecuteScalar())

            medico.IdMedico = cmd.ExecuteScalar()

        End Using

    End Sub

    'METODO UPDATE

    Public Shared Sub Update(medico As MedicoEntity)

        'crear la conexion a la fuente de la base de datos y abrirla

        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            'Creamos la sentencia SQL para agregar registros

            Dim sql As String = "UPDATE Medico Set IdRecinto = @idRecinto, IdEspecialidad = @idEspecialidad, Nombre = @nombre, Apellido = @apellido, Cedula = @cedula, Direccion = @direccion, Telefono = @telefono, Edad = @edad WHERE IdMedico = @idMedico"

            'Creamos el comando cmd con los datos y la conexion

            Dim cmd As New SqlCommand(sql, conex)

            'Agregamos los parametros

            'EJEMPLO cmd.Parameters.AddWithValue("@nombre", articulo.Nombre)

            cmd.Parameters.AddWithValue("@nombre", medico.Nombre)
            cmd.Parameters.AddWithValue("@apellido", medico.Apellido)
            cmd.Parameters.AddWithValue("@cedula", medico.Cedula)
            cmd.Parameters.AddWithValue("@direccion", medico.Direccion)
            cmd.Parameters.AddWithValue("@telefono", medico.Telefono)
            cmd.Parameters.AddWithValue("@edad", medico.Edad)
            cmd.Parameters.AddWithValue("@idRecinto", medico.IdRecinto)
            cmd.Parameters.AddWithValue("@idEspecialidad", medico.IdEspecialidad)
            cmd.Parameters.AddWithValue("@idMedico", medico.IdMedico)


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

            Dim sql As String = "DELETE FROM Medico WHERE IdMedico"

            'Creamos el comando cmd con los datos y la conexion

            Dim cmd As New SqlCommand(sql, conex)

            'Agregamos los parametros

            cmd.Parameters.AddWithValue("IdMedico", id)

            'La sentencia se ejecutara y se almacenara en la variable  cuando sea mayor que cero 
            SeElimino = cmd.ExecuteNonQuery() > 0

        End Using

        'Retornar la operacion

        Return SeElimino

    End Function

    'METODO READER

    'Convertir los datos a objetos

    Private Shared Function ConvertToObject(reader As IDataReader) As MedicoEntity

        'Se hace una intancia
        'EJEMPLO  Dim articulo As New ArticuloEntity()

        Dim medico As New MedicoEntity

        'Conversion a objetos
        'EJEMPLO articulo.IdCategoria = Convert.ToInt32(reader("IdCategoria"))
        'EJEMPLO articulo.Nombre = reader("Nombre")
        medico.IdMedico = Convert.ToInt32(reader("IdMedico"))
        medico.IdRecinto = Convert.ToUInt64(reader("IdRecinto"))
        medico.IdEspecialidad = Convert.ToInt32(reader("IdEspecialidad"))
        medico.Nombre = reader("Nombre")
        medico.Apellido = reader("Apellido")
        medico.Cedula = Convert.ToInt32(reader("Cedula"))
        medico.Telefono = reader("Telefono")
        medico.Direccion = reader("Direccion")
        medico.Edad = Convert.ToInt32(reader("Edad"))

        'Se retorna la conversion

        Return medico 'La variable instanciada

    End Function

    'Obtener datos de tres manera (por valor, por todos y por id)

    '- POR VALOR

    Public Shared Function GetByValor(valor As String) As List(Of MedicoEntity)

        'Se enlista los objetos en una variable
        'EMJEMPLO Dim list As New List(Of ArticuloEntity)
        Dim list As New List(Of MedicoEntity)

        'Creamos la conexion y la abrimos
        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            'Se realiza la seleccion en SQL y se la pasamos a la variable sql

            Dim sql As String = "SELECT * FROM Medico WHERE Nombre Like '%'+ @Valor +'%' or Apellido Like '%' + @valor + '%' or Cedula Like '%' + @valor + '%' ORDER BY Nombre"

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

    Public Shared Function GetAll() As List(Of MedicoEntity)
        'Se enlista los objetos en una variable

        'EMJEMPLO Dim list As New List(Of ArticuloEntity)

        Dim list As New List(Of MedicoEntity)

        'Creamos la conexion y la abrimos

        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            'Se realiza la seleccion en SQL y se la pasamos a la variable sql

            Dim sql As String = "SELECT * FROM Medico  ORDER BY Nombre"

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

    Public Shared Function GetByID(id As Integer) As MedicoEntity
        'Se hace una intancia igual a nothing

        'EJEMPLO Dim articulo As ArticuloEntity = Nothing

        Dim medico As MedicoEntity = Nothing

        'Creamos la conexion y la abrimos
        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            'Se realiza la seleccion en SQL y se la pasamos a la variable sql

            'EJEMPLO Dim sql As String = "SELECT * FROM Articulo Where ID=@idArticulo"

            Dim sql As String = "SELECT * FROM Medico Where IdMedico = @idMedico"

            'Creamos el comando cmd con los datos y la conexion

            Dim cmd As New SqlCommand(sql, conex)

            'Agregamos parametro de id primario de la tabla

            'EJEMPLO cmd.Parameters.AddWithValue("@idArticulo", id)

            cmd.Parameters.AddWithValue("@idMedico", id)

            'le pasamos la ejecucion con los registros a la variable reader

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            'Si hay lectura ejecutada entonces pasar los objetos

            If reader.Read() Then

                'le pasamos la conversion a la instancia creada de tipo entity
                'EJEMPLO  articulo = ConvertToObject(reader)

                medico = ConvertToObject(reader)

            End If
        End Using

        'Retornar los objetos leidos
        Return medico

    End Function
End Class
