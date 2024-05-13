/*what can i do?
 * sex, name, age
 * an race system
 * select an initial class (barbarian, mage, rogue)
 * an initial gift based on the choosen player class
 * each initial class have different attributes and weapons and spells and whatever
 * there would be spec changes if the char is a male or female
 * an attributes sytem? like points to attribuite to health, force, intelligence, faith and things like that
 * you can invite people for the party
 * decisions would be based on the dices used (theres like dices with 4, 6, 8, 10, 12 and 20 sides. See how to implement that)
 * 
 *fazer um sistema onde o jogador cria a propria historia, o console passa algumas alternativas, e baseadas nelas, o jogador
 *consegue montar a propria historia (na minha cabeça parece simples de fazer, mas, parece ser um pé no saco pra conseguir)
 *a principio, é melhor montar uma historia fechada, e depois faz uns updates com divisões de caminhos, mortes, recrutamento, etc
 */

//pra adicionar uma nova classe é: CTRL SHIFT A
using System;
using System.Threading;

namespace BasedRPG
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "BasedRPG";

            Console.WriteLine("Welcome to the BasedRPG, we will need some information about your character. . .");
            Console.WriteLine("Please, be wise when putting the informations, you can´t change it later.\n");

            Console.WriteLine("Press any key if you understood the rules. . .");
            Console.ReadKey();

            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine("==User Character==\n");

            Player player = new Player();
            player.PlayerInfo();

            Console.WriteLine("Select between three of the initial classes: ");
            

            Console.ReadKey();
        }
    }
}
