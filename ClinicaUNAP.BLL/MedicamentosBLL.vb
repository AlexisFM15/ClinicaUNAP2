Imports ClinicaUNAP.DAL
Imports ClinicaUNAP.Entity

Public Class MedicamentosBLL
    'ESTA CAPA SE REALIZARA EN DOS PASOS (1- METODO GUARDAR (crear o actualizar) Y 2- EL RETORNO DE LOS METODS OMOLOGOS DE LECTURA)
    'PUDE SER TRE PASOS PORQUE FALTARIA UTILIZAR EL METODO DELETE PARA ELIMINAR EN ESTA CAPA

    '1- METODO GUARDAR (crear o actualizar)

    Public Shared Sub Save(Medicamentos As MedicamentosEntity) 'Se crea una variable la contendra los objetos entities del cual deseemos tener

        'Decimo si el objecto id es igual a 0 entonces es un nuevo registro por tanto de la capa DAL llamamos nuestro metodo crear con parametro de la variable que tendra los objetos entities
        'de lo contrario es una actualizacion, se llama el metodo actualizar.

        If Medicamentos.IdMedicamentos = 0 Then

            'es una nueva

            MedicamentosDAL.Create(Medicamentos)
        Else

            'es una actualizacion

            MedicamentosDAL.Update(Medicamentos)
        End If

    End Sub


    '2- Retorno del metodo delete 

    'Public Shared Sub Eliminar(recinto As RecintoEntity)

    '    RecintoDAL.Delete(Convert.ToInt32(recinto.ID))

    'End Sub



    '3- EL RETORNO DE LOS METODS OMOLOGOS DE LECTURA

    Public Shared Function GetById(id As Integer) As MedicamentosEntity

        Return MedicamentosDAL.GetByID(id)

    End Function

    Public Shared Function GetAll() As List(Of MedicamentosEntity)

        Return MedicamentosDAL.GetAll()

    End Function

    Public Shared Function GetByValor(valor As String) As List(Of MedicamentosEntity)

        Return MedicamentosDAL.GetByValor(valor)

    End Function




End Class
