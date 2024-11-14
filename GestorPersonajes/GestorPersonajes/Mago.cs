using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mago : Personaje
{
    private int mana;

    public int Mana
    {
        get { return mana; }
        set { mana = value; }
    }

    public override void SubirNivel()
    {
        base.SubirNivel();
        mana += 20;
    }

    public override string Atacar()
    {
        if (mana >= 10)
        {
            mana -= 10;
            return $"{Nombre} está lanzando un hechizo. Mana restante: {mana}.";
        }
        else
        {
            return $"{Nombre} no tiene suficiente mana para lanzar un hechizo.";
        }
    }
}
