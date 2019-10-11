using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabSDES.Models
{
    public class SDES
    {
        public string K1;
        public string K2;

        public string P10(string Binario)  //Cambiar a que lo lea en txt
        {
            var Secuencia = "9743521806";
            var Nuevo = "";
            if (Binario.Length < 10) Binario.PadLeft(10, '0');

            for (int i = 0; i < 10; i++)
            {
                var Posicion = Convert.ToInt32(Secuencia[i]);
                Nuevo = $"{Nuevo}{Binario[Posicion]}";
            }

            return Nuevo;
        }
    }
}