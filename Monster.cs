using livingBeings;

namespace OtherCreatures{
   /*class for monsters "Auurgh!"
    *
    */
        class Monster : LivingBeing
        {
            public String monstername;


            /*constructors
             * They follow the same structure as those of the human class
             *   There is a parameter-less build, a fully configurable constructor for the monster,
             *   And last, one that configures its status without setting a name
             */
            public Monster()
            {
                this.Hp = 100;
                this.Strength = 10;
                this.Speed = 10;
                this.Agility = 10;
                this.Intelligence = 10;
                this.Endurance = 10;
                this.monstername = "monster";

            }

            public Monster(double hp, int strength, int speed, int agility, int intelligence, int endurance, string monstername)
            {
                this.Hp = hp;
                this.Strength = strength;
                this.Speed = speed;
                this.Agility = agility;
                this.Intelligence = intelligence;
                this.Endurance = endurance;
                this.monstername = monstername;
            }

            public Monster(double hp, int strength, int speed, int agility, int intelligence, int endurance)
            {
                this.Hp = hp;
                this.Strength = strength;
                this.Speed = speed;
                this.Agility = agility;
                this.Intelligence = intelligence;
                this.Endurance = endurance;
                this.monstername = "Unnamed wild monster";
            }

            /*Monster rooster:
             * 1. normal monster, 2. goblin, 3. troll, 4. wolf, 5. minotaur*/
            public Monster(int overload)
            {

                if (overload == 1)
                {
                    this.monstername = "normal monster";
                    this.Hp = 100;
                    this.Strength = 10;
                    this.Speed = 10;
                    this.Agility = 10;
                    this.Intelligence = 10;
                    this.Endurance = 10;
                    
                }

                else if (overload == 2)
                {
                    this.monstername = "Goblin";
                    this.Hp = 15;
                    this.Strength = 4;
                    this.Speed = 7;
                    this.Agility = 4;
                    this.Endurance = 4;
                }
                
                else if (overload == 3)
                {
                    this.monstername = "Troll";
                    this.Hp = 200;
                    this.Strength = 30;
                    this.Speed = 10;
                    this.Agility = 9;
                    this.Endurance = 35;
                }


                else if (overload == 4)
                {
                    this.monstername = "Wolf";
                    this.Hp = 100;
                    this.Strength = 18;
                    this.Speed = 25;
                    this.Agility = 30;
                    this.Endurance = 20;
                }

                else if (overload == 5)
                {
                    this.monstername = "Minotaur";
                    this.Hp = 500;
                    this.Strength = 200;
                    this.Speed = 50;
                    this.Agility = 50;
                    this.Endurance = 100;
                }

                else if (overload < 1)
                {
                    this.name = "weak monster";
                    this.Endurance = 3;
                    this.Agility = 3;
                    this.Strength = 5;
                    this.Speed = 4;
                    this.Hp = 8;
                }
                

            }

            public override void sound()
            {
                Console.WriteLine("Aurrgh!");
                /*Very monstruous!*/
            }



        }

}