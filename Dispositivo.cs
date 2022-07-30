public abstract class Dispositivo
{
    public int imei { get; set;}
    public string marca { get; set;}
    public string modelo { get; set;}
    public string sistemaoperativo { get; set;}

    
    public abstract string hardware();

}