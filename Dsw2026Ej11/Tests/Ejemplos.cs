using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.ComponentModel;

namespace Dsw2026Ej11.Tests;

internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList lista = new CasoList(); 

        Alumno a1 = new Alumno(1, "Mauro", 10);
        Alumno a2 = new Alumno(2, "Sofia", 10);
        Alumno a3 = new Alumno(3, "Joaquin", 10);

        lista.AgregarAlumno(a1);
        lista.AgregarAlumno(a2);
        lista.AgregarAlumno(a3);

        Console.WriteLine("LISTA DE ALUMNOS");

        foreach (Alumno alumno in lista.GetAlumnos())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine();

        Alumno encontrado = lista.BuscarPorNombre("Mauro"); //existe

        if (encontrado != null)
        {
            Console.WriteLine("Alumno encontrado: ");
            Console.WriteLine(encontrado);
        }

        Alumno inexistente = lista.BuscarPorNombre("Raúl"); //no existe

        if (inexistente != null)
        {
            Console.WriteLine("Alumno inexistente");
        }

        Console.WriteLine();

        lista.EliminarAlumno(a2);

        Console.WriteLine("LISTA DESPUES DE ELIMINAR A SOFIA");

       foreach (Alumno alumno in lista.GetAlumnos())
        {
            Console.WriteLine(alumno);
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {

        CasoDictionary diccionario = new CasoDictionary();
        Alumno a1 = new Alumno(1, "Mauro", 10);
        Alumno a2 = new Alumno(2, "Sofia", 7);
        Alumno a3 = new Alumno(3, "Joaquin", 5);

        diccionario.AgregarAlumno(a1);
        diccionario.AgregarAlumno(a2);
        diccionario.AgregarAlumno(a3);

        Console.WriteLine("LISTA DE ALUMNOS EN DICCIONARIO");

        foreach (KeyValuePair<int, Alumno> item in diccionario.GetDictionary()) // significa: Para cada par clave-valor del diccionario, guardalo temporalmente en item.
        {
            Console.WriteLine($"Clave: {item.Key}");
            Console.WriteLine(item.Value);

            // item.Key -> clave
            // item.Value -> valor
        }

        Console.WriteLine();

        Alumno encontrado = diccionario.BuscarPorClave(2);

        if (encontrado != null)
        {
            Console.WriteLine("ALUMNO ENCONTRADO");
            Console.WriteLine(encontrado);
        }

        Console.WriteLine();

        Alumno inexistente = diccionario.BuscarPorClave(99);

        if (inexistente == null)
        {
            Console.WriteLine("ALUMNO INEXISTENTE");
        }

        Console.WriteLine();

        diccionario.EliminarAlumno(2);

        Console.WriteLine("LISTA DESPUES DE ELIMINAR");

        foreach (KeyValuePair<int, Alumno> item in diccionario.GetDictionary())
        {
            Console.WriteLine(item.Value);
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        // Creamos una instancia de CasoLinq.
        CasoLinq caso = new CasoLinq();


        // 1) Mostrar primer libro.
        Console.WriteLine("PRIMER LIBRO");
        Console.WriteLine(caso.GetPrimero());


        Console.WriteLine();


        // 2) Mostrar último libro.
        Console.WriteLine("ÚLTIMO LIBRO");
        Console.WriteLine(caso.GetUltimo());


        Console.WriteLine();


        // 3) Mostrar suma de precios.
        Console.WriteLine("SUMA DE PRECIOS");
        Console.WriteLine(caso.GetTotalPrecios());


        Console.WriteLine();


        // 4) Mostrar promedio de precios.
        Console.WriteLine("PROMEDIO DE PRECIOS");
        Console.WriteLine(caso.GetPromedioPrecios());


        Console.WriteLine();


        // 5) Mostrar libros con Id mayor a 15.
        Console.WriteLine("LIBROS CON ID MAYOR A 15");


        // Recorremos la lista retornada.
        foreach (Libro libro in caso.GetListById())
        {
            Console.WriteLine(libro);
        }


        Console.WriteLine();


        // 6) Mostrar strings personalizados.
        Console.WriteLine("LIBROS FORMATEADOS");


        foreach (string texto in caso.GetLibros())
        {
            Console.WriteLine(texto);
        }


        Console.WriteLine();


        // 7) Mostrar libro más caro.
        Console.WriteLine("LIBRO MÁS CARO");
        Console.WriteLine(caso.GetMayorPrecio());


        Console.WriteLine();


        // 8) Mostrar libro más barato.
        Console.WriteLine("LIBRO MÁS BARATO");
        Console.WriteLine(caso.GetMenorPrecio());


        Console.WriteLine();


        // 9) Mostrar libros con precio mayor al promedio.
        Console.WriteLine("LIBROS MAYORES AL PROMEDIO");


        foreach (Libro libro in caso.GetMayorPromedio())
        {
            Console.WriteLine(libro);
        }


        Console.WriteLine();


        // 10) Mostrar libros ordenados descendente.
        Console.WriteLine("LIBROS ORDENADOS DESCENDENTE");


        foreach (Libro libro in caso.GetOrdenadosDesc())
        {
            Console.WriteLine(libro);
        }
    }
}
