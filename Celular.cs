public class Celular : Dispositivo , IFuncionalidad
{
    
    public Celular(int imei, string marca, string modelo, string sistemaoperativo )
    {
        this.imei = imei;
        this.marca = marca;
        this.modelo = modelo;
        this.sistemaoperativo = sistemaoperativo;
    }
    public void Imprimir()
    {
        Console.WriteLine(marca+ modelo);
        Console.WriteLine("IMEI: "+imei);
        Console.WriteLine("Sistema Operativo: "+sistemaoperativo);
    }

    public override string hardware()
    {
        return "Cargador";
    }

    public void Funcionalidad()
    {
        Console.WriteLine();
        Console.WriteLine("Cambio de bateria");
        Console.WriteLine("Pin de carga");
        Console.WriteLine("Limpieza");
    }
}