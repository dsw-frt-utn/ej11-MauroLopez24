using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//1)Crear un diccionario donde la clave sea el legajo y el valor el alumno
//2)Incluir un método para agregar un alumno al diccionario
//3)Incluir un método para buscar un alumno utilizando la clave
//4)Incluir un método para retornar el diccionario
//5)Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    //1)Crear un diccionario donde la clave sea el legajo y el valor el alumno
    private Dictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();

    //2)Incluir un método para agregar un alumno al diccionario
    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno.Id, alumno); //recordar que add agrega al final de la fila
    }

    //3)Incluir un método para buscar un alumno utilizando la clave
public Alumno BuscarPorClave(int clave)
    {
        bool existe = alumnos.TryGetValue(clave, out Alumno alumno);

        if (existe)
        {
            return alumno;
        }

        return null;
    }

    //4)Incluir un método para retornar el diccionario
    public Dictionary<int, Alumno> GetDictionary()
    {
        return alumnos;
    }


    //5)Incluir un método para eliminar un alumno utilizando la clave
    public void EliminarAlumno(int calve)
    {
        alumnos.Remove(calve); //Elimina el obj pero le tengo que pasar la clave
    }

}
