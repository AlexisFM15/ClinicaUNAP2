Imports ClinicaUNAP.Entity
Imports System.Data.SqlClient

Public Class CitaDAL
    'Heredamos de la conexion de la base de datos
    Inherits BaseDAL

    'Creamos los metodos CRUD (CREATE, READ, UPDATE, DELETE)

    'METODO CREATE

    Public Shared Sub Create(Cita As CitaEntity)
        'crear la conexion a la fuente de la base de datos y abrirla

        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            'Creamos la sentencia SQL para agregar registros

            Dim sql As String = "INSERT INTO Cita ( IdPaciente, IdMedico, IdEmpleado, IdRecinto, TipoAtencion, Descripcion) Values (@idPaciente, @idMedico, @idEmpleado, @idRecinto, @tipoAtencion, @descripcion ) SELECT SCOPE_IDENTITY()"

            'Creamos el comando cmd con los datos y la conexion

            Dim cmd As New SqlCommand(sql, conex)

            'Agregamos los parametros

            'EJEMPLO cmd.Parameters.AddWithValue("@nombre", articulo.Nombre)
            ' cmd.Parameters.AddWithValue("@idRecinto", recinto.IdRecinto)

            cmd.Parameters.AddWithValue("@idPaciente", Cita.IdPaciente)
            cmd.Parameters.AddWithValue("@idMedico", Cita.IdMedico)
            cmd.Parameters.AddWithValue("@idEmpleado", Cita.IdEmpleado)
            cmd.Parameters.AddWithValue("@idRecinto", Cita.IdRecinto)
            cmd.Parameters.AddWithValue("@tipoAtencion", Cita.TipoAtencion)
            cmd.Parameters.AddWithValue("@descripcion", Cita.Descripcion)

            'Lo ejecutamos de manera escalar por el id objeto primario  de la tabla

            'EJEMPLO articulo.ID = Convert.ToInt32(cmd.ExecuteScalar())

            Cita.IdCita = cmd.ExecuteScalar()

        End Using

    End Sub



End Class
