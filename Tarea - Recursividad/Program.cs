using System;

class LaberintoSolver
{
    public static bool ResolverLaberinto(int[][] laberinto, int filaInicial, int columnaInicial, int filaFinal, int columnaFinal)
    {
        if (filaInicial < 0 || filaInicial >= laberinto.Length || columnaInicial < 0 || columnaInicial >= laberinto[0].Length ||
            laberinto[filaInicial][columnaInicial] == 1)
        {
            return false;
        }

        if (filaInicial == filaFinal && columnaInicial == columnaFinal)
        {
            return true;
        }

        laberinto[filaInicial][columnaInicial] = 1;

        if (ResolverLaberinto(laberinto, filaInicial + 1, columnaInicial, filaFinal, columnaFinal) || // Abajo
            ResolverLaberinto(laberinto, filaInicial - 1, columnaInicial, filaFinal, columnaFinal) || // Arriba
            ResolverLaberinto(laberinto, filaInicial, columnaInicial + 1, filaFinal, columnaFinal) || // Derecha
            ResolverLaberinto(laberinto, filaInicial, columnaInicial - 1, filaFinal, columnaFinal))   // Izquierda
        {
            return true;
        }

        laberinto[filaInicial][columnaInicial] = 0;

        return false;
    }

    static void Main(string[] args)
    {
        int[][] laberinto1 = new int[][] {
            new int[] { 0, 1, 0, 0, 0 },
            new int[] { 0, 1, 1, 1, 0 },
            new int[] { 0, 0, 0, 1, 0 },
            new int[] { 1, 1, 0, 1, 1 },
            new int[] { 0, 0, 0, 0, 0 }
        };

        int[][] laberinto2 = new int[][] {
            new int[] { 0, 0, 1, 1, 1, 0, 0, 0 },
            new int[] { 1, 0, 1, 0, 0, 0, 1, 1 },
            new int[] { 1, 0, 0, 0, 1, 1, 0, 1 },
            new int[] { 0, 1, 1, 1, 0, 0, 0, 0 },
            new int[] { 0, 0, 0, 1, 1, 1, 1, 0 },
            new int[] { 1, 1, 0, 0, 0, 0, 1, 0 },
            new int[] { 0, 1, 1, 1, 0, 1, 0, 0 },
            new int[] { 0, 0, 0, 0, 0, 1, 1, 0 }
        };

        int[][] laberinto3 = new int[][] {
            new int[] { 0, 1, 0, 0, 0, 1, 0, 0, 0, 1 },
            new int[] { 0, 1, 1, 1, 0, 1, 1, 1, 0, 1 },
            new int[] { 0, 0, 0, 1, 0, 0, 0, 1, 0, 1 },
            new int[] { 1, 1, 0, 1, 1, 1, 0, 0, 0, 0 },
            new int[] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 0 },
            new int[] { 1, 1, 1, 1, 0, 0, 0, 0, 0, 0 },
            new int[] { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
            new int[] { 1, 1, 1, 1, 1, 1, 1, 0, 1, 0 },
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
        };

        Console.WriteLine("Laberinto 1: " + ResolverLaberinto(laberinto1, 0, 0, 4, 4));
        Console.WriteLine("Laberinto 2: " + ResolverLaberinto(laberinto2, 0, 0, 7, 4));
        Console.WriteLine("Laberinto 3: " + ResolverLaberinto(laberinto3, 0, 0, 9, 9));
    }
}
