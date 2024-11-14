public abstract class Forma
{
    public abstract double CalcularArea();
}

public class Círculo : Forma
{
    public double Radio { get; set; }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }
}

public class Rectángulo : Forma
{
    public double Largo { get; set; }
    public double Ancho { get; set; }

    public override double CalcularArea()
    {
        return Largo * Ancho;
    }
}

public class Programa
{
    public static void MostrarAreas(Forma[] formas)
    {
        foreach (var forma in formas)
        {
            Console.WriteLine($"Área: {forma.CalcularArea()}");
        }
    }

    public static void Main(string[] args)
    {
        Forma[] formas = new Forma[]
        {
            new Círculo { Radio = 5 },
            new Rectángulo { Largo = 4, Ancho = 6 }
        };

        MostrarAreas(formas);
    }
}
