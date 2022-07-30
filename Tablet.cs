public class Tablet : Dispositivo, IFuncionalidad
{
    public string chip { get; set;}
    public string pais {get; set;}

    public Tablet(string chip, string pais,int imei, string marca, string modelo, string sistemaoperativo)
    {
        this.chip = chip;
        this.pais = pais;
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
        Console.WriteLine("Pais de origen: "+pais);
        Console.WriteLine("Chip: "+chip);
    }

    public override string hardware()
    {
        return "Audifono";
    }

    public void Funcionalidad()
    {
        Console.WriteLine();
        Console.WriteLine("Reperacion de entrada de audifonos");
        Console.WriteLine("Cambio de pantalla");
        Console.WriteLine("Cambio del tactil");
    }
}