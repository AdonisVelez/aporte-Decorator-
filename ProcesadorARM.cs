public class ProcesadorARM : HardwareDecorador
{
    public ProcesadorARM(Dispositivo dispositivo) : base(dispositivo){}

    public override string hardware()
    {
        return base.hardware()+" + Procesador ARM";
    }
}