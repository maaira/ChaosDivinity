using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaosDivinity.ConsoleApp
{
    static class ConsoleAux
    {
        static string Menssagem()
        {
            return "Bem vindo ao Chaos Divinity!\nO mundo vivia uma era tranquila, o mal se mantinha afastado por séculos, mas existiam aqueles que operavam das sombras para trazer o retorno das trevas. Uma seita começou seus planos de reviver o seu deus maligno Ba-Kon, e para isso não poupariam esforços. O fim do mundo estava próximo e a catástrofe espreitava perto. Os avatares do deus estavam vivos exerciam sua influencia devastadora sobre a natureza. As águas se envenenavam, o céu sufocava e a terra morria pouco a pouco. Monstros vinham de todos os lados e as pessoas perdiam sua esperança. E agora quem poderá nos defender?";
        }

        static string MenssagemGuerreiro()
        {
            return "Das montanhas vinha um homem, um soldado renegado, mercenário forjado nas guerras do reino que deixou, abandonando sua antiga glória para manter a sua honra. Sua força agora serviria aquele que pagasse mais alto, porém nunca se desviando de seus preceitos, o que faria de seu caminho ainda mais árduo. O guerreiro tinha cada vez mais trabalho devido às aparições das criaturas das trevas, mas sabia que existia algo muito maior por trás de tudo. Ele então decidiu mais uma vez usar sua espada não por si mesmo, mas por todo o mundo.";
        }

        static string MenssagemLadino()
        {
            return "Todos os reinos a procuravam, a ladra que já havia roubado em becos, estradas e castelos. Suas lâminas rasgavam carteiras e gargantas como uma folha dança no vento. Nenhuma parede era alta o suficiente, nenhuma guarda forte o bastante, porém aquelas hordas malignas eram algo a se temer. A mulher que cresceu nas ruas das cidades, e já tinha visto de tudo nunca tinha posto os olhos em miséria como aquela, ela então resolveu fazer algo sobre a escuridão iminente, e confronta-la pelas sombras, talvez algum lucro viesse ao seu encontro.";
        }

        static string MenssagemMago()
        {
            return "A imagem do jovem apaixonado por livros havia se dissipado. Os anos passaram e o erudito perdeu a noção do tempo. O mago já não sabia mais quando havia começado a se dedicar aos estudos, mas isso era o único pensamento em sua mente, não haviam mais família, amigos ou professores. Talvez até mesmo já tivesse perdido sua humanidade, enquanto contemplava o abismo arcano. Agora as figuras mais sombrias que apareceram em seus textos tocavam a realidade, e esse seria o seu chamado.";
        }



        static void MenuSeleçãoDePersonagem()
        {
            Console.WriteLine("Então...Oque voce vai querer ser!");
            Console.WriteLine("        1-Um Bravo Guerreiro.\n        2-Uma Astuta Ladina.\n        3-Um Poderoso Mago.\n ");

            string type = Console.ReadLine();

            
     

            if(Int32.TryParse(type, out int numValue))
            {
                switch(type)
                {
                case 1:

                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
                }
            }
            else
            {
                Console.WriteLine("Impossivel identificar sua opção. Digite novamente!");
                MenuSeleçãoDePersonagem();
            }
        }
    }
}
