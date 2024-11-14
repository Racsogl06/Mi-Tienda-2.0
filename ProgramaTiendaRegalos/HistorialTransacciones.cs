using System.Collections.Generic;

public class HistorialTransacciones
{
    private List<Transaccion> transacciones = new List<Transaccion>();

    public void AgregarTransaccion(Transaccion transaccion)
    {
        transacciones.Add(transaccion);
    }

    public List<Transaccion> ListarTransacciones()
    {
        return transacciones;
    }
}
