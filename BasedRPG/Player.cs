using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedRPG
{
    class Player
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
        //public string Description { get; set; }//fazer isso outra hora
        
        public Player() { }
        //dar uma relembrada do pq ter o Name = _name, esqueci alguns detalhes
        public Player(string _name, string _sex, string _age) 
        {
            Name = _name;
            Sex = _sex;
            Age = _age;
            //Description = _description;
        }

        public Player PlayerInfo()
        {
            Console.Write("Welcome traveler, what is your name?: ");
            Name = Console.ReadLine();

            Console.Write("Intersting name, you are not from here, are you? Anyway, what is your sex?: ");
            Sex = Console.ReadLine();

            Console.Write("I see, mind if i know your age?: ");
            Age = Console.ReadLine();

            return new Player(Name, Sex, Age);
        }

    }
}
