
using System;
using System.Threading;

namespace CoreEscuela.util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            Console.WriteLine("".PadLeft(tam, '='));
        }

        public static void EscribirTitulo(string titulo)
        {
            var tamaño = titulo.Length + 4;
            DibujarLinea(tamaño) ;
            Console.WriteLine($"| {titulo} |");
            DibujarLinea(tamaño);
        }

        public static void Beep(int cantidad = 1)
        {
            
            var Solb = 185; var Lab = 207; var Sib = 233; var Reb = 277; var Mib =311 ; var Fa = 349; var La2 = 329;
            var negra = 250;
            var blanca = negra * 2;
            var corchea = negra /2;
            var dotblanca = blanca + negra;
            var dotnegra = negra + corchea;
            
            while(cantidad-- > 0)
            {
                Console.Beep(Solb,dotnegra);
                Console.Beep(Fa,dotnegra);
                Console.Beep(Mib,dotnegra);
                Console.Beep(Mib,negra);
                Console.Beep(Reb,corchea);
                Thread.Sleep(negra);
                Console.Beep(Mib,dotnegra);
                Console.Beep(Mib,negra);
                Console.Beep(Fa,corchea);
                Console.Beep(Mib,negra);
                Console.Beep(Reb,corchea);
                Console.Beep(Sib,negra);
                Console.Beep(Lab,corchea);
                Thread.Sleep(negra);
                Console.Beep(Sib,dotnegra);
                Console.Beep(Fa,dotnegra);
                Console.Beep(Mib,dotnegra);
                Console.Beep(Mib,negra);
                Console.Beep(Reb,corchea);
                Thread.Sleep(negra);
                Console.Beep(Mib,dotnegra);
                Console.Beep(Mib,negra);
                Console.Beep(Fa,corchea);
                Console.Beep(Mib,negra);
                Console.Beep(Reb,corchea);
                Console.Beep(Sib,negra);
                Console.Beep(Lab,corchea);
                Thread.Sleep(negra);
                Console.Beep(Sib,dotnegra);
                Console.Beep(Reb,dotnegra);
                Console.Beep(La2,dotblanca);
            }    
        
        }
    }
}