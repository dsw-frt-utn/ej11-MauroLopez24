using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//1)Crear un campo que represente una lista de alumnos (List<>)
//2)Incluir un método para agregar alumnos a la lista 
//3)Incluir un método para retornar la lista
//4)Incluir un método para buscar un alumno por nombre
//5)Incluir un método para eliminar un alumno (debe recibir un alumno)
//6)Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    //1)Crear un campo que represente una lista de alumnos (List<>)
    private List<Alumno> alumnos = new List<Alumno>();

    //2)Incluir un método para agregar alumnos a la lista
    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno); //el Add agrega un elemento al final de la lista
    }

    //3)Incluir un método para retornar la lista
    public List<Alumno> GetAlumnos()
    {
        return alumnos;
    }

    //4)Incluir un método para buscar un alumno por nombre
    public Alumno BuscarPorNombre(string nombre)
    {
        //.Find funciona reciviendo un metodo
        return alumnos.Find(a => a.Nombre == nombre); //.Find recorre la lista buscando la primer coincidencia y puede devolver un objeto o null
    }
    

    //5)Incluir un método para eliminar un alumno (debe recibir un alumno)
    public void EliminarAlumno(Alumno alumno)
    {
        alumnos.Remove(alumno); //.Remove elimina el OBJETO entero
    }


    //6)Incluir un método para eliminar un alumno en una determinada posición de la lista
    public void EliminarPorPosicion(int posicion)
    {

        alumnos.RemoveAt(posicion); //.RemoveAt elimina el elemento indicado
    }
}
