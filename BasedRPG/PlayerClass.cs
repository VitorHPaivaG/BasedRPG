namespace BasedRPG
{
    class PlayerClass
    {
        public int InitialHP;
        public int InitialSTR;
        public int InitialINT;


        public class Warrior
        {
            private PlayerClass WarriorClass;

            public Warrior()
            {
                WarriorClass.InitialHP = 100;
                WarriorClass.InitialSTR = 14;
                WarriorClass.InitialINT = 9;
            }
        }

        public class Sorcerer
        {
            private PlayerClass SorcererClass;

            public Sorcerer()
            {
                SorcererClass.InitialHP = 100;
                SorcererClass.InitialSTR = 9;
                SorcererClass.InitialINT = 15;
            }
        }

        public class Thief
        {
            private PlayerClass ThiefClass;

            public Thief()
            {
                ThiefClass.InitialHP = 100;
                ThiefClass.InitialSTR = 9;
                ThiefClass.InitialINT = 12;
            }
        }

    }
}
