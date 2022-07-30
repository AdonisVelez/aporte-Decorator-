public class HardwareDecorador : Dispositivo
{
    protected Dispositivo dispositivo;

    public HardwareDecorador(Dispositivo dispositivo)
    {
        this.dispositivo = dispositivo;
    }
   public override string hardware()
   {
     return dispositivo.hardware();
   }
}