using System.Reflection;
using System;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base()
        {

            Numero = numero;
            IMEI = imei;
            Memoria = memoria;
            Modelo = modelo;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O nokia esta instalando o aplicativo: {nomeApp}");
        }
    }
}