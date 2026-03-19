using System;

public class Departamento
{
    public string Nombre{get; set;}
    
    public void mostrarProfesor(Profesor p)// Aqui se crea la agrgacion
    {
        Console.WriteLine("Profesor:"+ p.Nombre);
        Console.WriteLine("Departamento:"+ Nombre);
    }
}

public class Profesor
{
    public string Nombre{get; set;}
}

class Program
{
    static void Main()
    {
        // Se creo un objeto para la clase departamento
        Departamento Ingenierias =new Departamento();
        Ingenierias.Nombre="Ingenierias";
        
        // Se creo un objeto Para Profesor
        Profesor Taco=new Profesor();
        Taco.Nombre= "Paco";
        
        Ingenierias.mostrarProfesor(Taco);
        
        
    }
}
