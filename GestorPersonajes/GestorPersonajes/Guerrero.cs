using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Guerrero : Personaje
{
    private int fuerza;

    public int Fuerza
    {
        get { return fuerza; }
        set { fuerza = value; }
    }

    public override void SubirNivel()
    {
        base.SubirNivel();
        fuerza += 5;
    }

    public override string Atacar()
    {
        return $"{Nombre} está atacando con su fuerza de {fuerza}.";
    }
}
