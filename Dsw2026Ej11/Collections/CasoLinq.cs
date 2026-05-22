using Dsw2026Ej11.Domain;
using System.Timers;


namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private List<Libro> libros = Libro.CrearLista();


     // * 1. Obtener el primer libro(GetPrimero)

    public Libro GetPrimero()
    {
        return libros.First(); //El .Fisrt() devuelve el PRIMER elemento
    }

    // * 2. Obtener el último libro (GetUltimo)
    public Libro GetUltimo()
    {
        return libros.Last(); //El .Last() devuelve el ULTIMO elemento
    }

    // * 3. Obtener la suma de precios (GetTotalPrecios)
    public decimal GetTotalPrecios()
    {
        return libros.Sum(l => l.Precio); //Sum() suma TODOS los precios
    }

    //  * 4. Obtener el promedio de precios (GetPromedioPrecios)
    public decimal GetPromedioPrecios()
    {
        return libros.Average(l => l.Precio); //Average() calcula el promedio
    }

    // * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
    public List<Libro> GetListById()
    {
        return libros
            .Where(l => l.Id > 15) //el where() filtra, le pongo la condicion de los elementos que quiero, en este caso todos los libros cuyo id sea mayor a 15
            .ToList(); //where() devuelve IEnumerable y el ToList() lo convierte en una lista 
    }

    //* 6. Obtener una lista de cada libro con su título y precio en formato moneda(GetLibros) (debe retornar una lista de string)
    public List<string> GetLibros()
    {
        return libros
            .Select(l => $"{l.Titulo} - {l.Precio:C}")
            .ToList();
    }

    // * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
    public Libro GetMayorPrecio()
    {
        return libros.MaxBy(l => l.Precio);
    }

    // * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
    public Libro GetMenorPrecio()
    {
        return libros.MinBy(l => l.Precio);
    }

    // * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
    public List<Libro> GetMayorPromedio()
    {
        decimal promedio = libros.Average(l => l.Precio);
        return libros
            .Where(l => l.Precio > promedio)
            .ToList();
    }


    // * 10. Obtener libros ordenados por título descendente.
    public List<Libro> GetOrdenadosDesc()
    {
        // OrderByDescending ordena de Z a A.
        return libros
            .OrderByDescending(l => l.Titulo)
            .ToList();
    }



}
