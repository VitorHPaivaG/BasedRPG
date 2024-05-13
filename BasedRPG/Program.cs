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
 */

//pra adicionar uma nova classe é: CTRL SHIFT A
using System;

namespace BasedRPG
{
    internal class Program
    {
        static void Main()
        {
            Player player = new Player();
            player.PlayerInfo();

            Console.ReadKey();
        }
    }
}
