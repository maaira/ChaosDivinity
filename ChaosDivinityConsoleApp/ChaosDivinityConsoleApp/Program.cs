using ChaosDivinity.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaosDivinityConsole
{
    class Program
    {        

           
        static void Main(string[] args)
        {
            Console.WriteLine(ConsoleAux.Menssagem());
            ConsoleAux.MenuSeleçãoDePersonagem();
            Console.ReadKey();


        }

        
    }
}
