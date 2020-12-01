using System;

namespace Atributos_e_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem objetoPersonagem2 = new Personagem();

            objetoPersonagem2.nome = "Tsukamato";
            objetoPersonagem2.idade = 32;
            objetoPersonagem2.armadura = "Voadora";


            Personagem objetoPersonagem1 = new Personagem();

            objetoPersonagem1.nome = "Tupac";
            objetoPersonagem1.idade = 25;
            objetoPersonagem1.armadura = "Flash";

            Console.WriteLine($"Personagem 1 = {objetoPersonagem1.nome} - {objetoPersonagem1.Atacar()}");
            Console.WriteLine($"Personagem 2 = {objetoPersonagem2.nome} - {objetoPersonagem2.Defender()}");
        }

            public class Personagem
            {
                public string nome;
                public int idade;
                public string armadura;


                public string Atacar(){
                    return "Ataque de fogo!";
                }


                public string Defender(){
                    return "Não foi dessa vez!";
                }
            }
        }
    }

