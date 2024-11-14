using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public abstract class Personaje
{
    private string nombre;
    private int nivel;
    private int puntosVida;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Nivel
    {
        get { return nivel; }
        set
        {
            if (value >= 0)
                nivel = value;
            else
                throw new ArgumentException("El nivel no puede ser negativo.");
        }
    }

    public int PuntosVida
    {
        get { return puntosVida; }
        set
        {
            if (value >= 0)
                puntosVida = value;
            else
                throw new ArgumentException("Los puntos de vida no pueden ser negativos.");
        }
    }

    public virtual void SubirNivel()
    {
        nivel++;
        puntosVida += 10;
    }

    public abstract string Atacar();

    public string MostrarInformacion()
    {
        return $"Nombre: {nombre}, Nivel: {nivel}, Puntos de Vida: {puntosVida}";
    }
}
