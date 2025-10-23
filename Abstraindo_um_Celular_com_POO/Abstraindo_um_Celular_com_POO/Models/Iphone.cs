namespace Abstraindo_um_Celular_com_POO.Models;

// TODO: Herdar da classe "Smartphone"
public class Iphone : Smartphone
{
    public Iphone(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
    {
    }
    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone.");
    }

    // TODO: Sobrescrever o método "InstalarAplicativo"

}