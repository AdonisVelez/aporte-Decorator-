public class Microfono : HardwareDecorador
{
    public Microfono(Dispositivo dispositivo) : base (dispositivo){}

    public override string hardware()
    {
        return base.hardware()+" + Microfono";
    }
}