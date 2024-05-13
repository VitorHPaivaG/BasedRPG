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
        
        public Player() { }
        //dar uma relembrada do pq ter o Name = _name, esqueci alguns detalhes
        public Player(string _name, string _sex, string _age) 
        {
            Name = _name;
            Sex = _sex;
            Age = _age;
        }

        public Player PlayerInfo()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();

            Console.Write("Sex [M/F]: ");
            Sex = Console.ReadLine();

            Console.Write("Age: \n");
            Age = Console.ReadLine();

            return new Player(Name, Sex, Age);
        }


    }
}
