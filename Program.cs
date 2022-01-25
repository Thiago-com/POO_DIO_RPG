using System;
using POO.Mentoria.src.Entities;

namespace POO_mentoria
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Heroi arus = new Heroi("Arus", "Guerreiro");
            Mago wedge = new Mago("Wedge", "Mago Negro");
            Inimigo kingMummy = new Inimigo("King Mummy", "Zumbi");

            Console.WriteLine(arus.Atacar());
            Console.WriteLine(kingMummy.Atacar());

            if(arus.ValorUltimoAtaque == kingMummy.ValorUltimoAtaque){
                Console.WriteLine(" Empate, ambos deram dano de " + arus.ValorUltimoAtaque);
            }else if(arus.ValorUltimoAtaque > kingMummy.ValorUltimoAtaque){
                kingMummy.ReceberDano(arus.ValorUltimoAtaque - kingMummy.ValorUltimoAtaque);
                Console.WriteLine(arus.Nome + "Venceu esse round");
            } else {
                arus.ReceberDano(kingMummy.ValorUltimoAtaque - arus.ValorUltimoAtaque);
                Console.WriteLine(kingMummy.Nome + "Venceu esse round");
            }


            Console.WriteLine(arus.ValorUltimoAtaque);
            Console.WriteLine(wedge.ValorUltimoAtaque);

        }
    }
}


