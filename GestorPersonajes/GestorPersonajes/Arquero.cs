using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Arquero : Personaje
{
    private int precision;

    public int Precision
    {
        get { return precision; }
        set { precision = value; }
    }

    public override void SubirNivel()
    {
        base.SubirNivel();
        precision += 3;
    }

    public override string Atacar()
    {
        return $"{Nombre} está disparando una flecha con una precisión de {precision}.";
    }
}
