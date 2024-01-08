using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_desafio.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o Aplicativo '{nomeApp}' no Nokia.");
        }
    }
}