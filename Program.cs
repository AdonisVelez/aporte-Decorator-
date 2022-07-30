using System;
namespace Aporte
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var celular = new Celular(1234,"Huawei","Y9","Android");
            celular.Imprimir();
            celular.Funcionalidad(); 
            Console.WriteLine(celular.hardware());

            var microfono1 = new Microfono(celular);
            Console.WriteLine(microfono1.hardware());
            Console.WriteLine();

            var tablet = new Tablet("Claro","Ecuador",1254,"Samsung","J5","Andriod");
            tablet.Imprimir();
            celular.Funcionalidad();
            Console.WriteLine(tablet.hardware());

            var microfono2 = new Microfono(tablet);
            Console.WriteLine(microfono2.hardware());
            
            var arm = new ProcesadorARM(microfono2);
            Console.WriteLine(arm.hardware());
            Console.WriteLine();
        }
    }
}
