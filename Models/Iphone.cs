namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base() 
        {
            Numero = numero;
            IMEI = imei;
            Memoria = memoria;
            Modelo = modelo;
        }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O Iphone esta instalando o aplicativo: {nomeApp}");
        }
    }
}