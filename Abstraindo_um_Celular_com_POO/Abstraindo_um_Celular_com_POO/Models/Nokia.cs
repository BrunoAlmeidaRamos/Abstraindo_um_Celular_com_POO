namespace Abstraindo_um_Celular_com_POO.Models;

// TODO: Herdar da classe "Smartphone"
public class Nokia : Smartphone
{
    public Nokia(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
    {
    }
 
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia."); ;
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"

}

