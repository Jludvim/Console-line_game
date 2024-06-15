using livingBeings;

namespace OtherCreatures{
 /*
 This is a file in which the monster class is defined, and gives room for the definition of many other classes that are non-human.
 It does derive from LivingBeing, and defines many overloads to create characters.
 Some defining no feature, and using default stat-values (see line 20), 
 defining basic physical attributes and a name to idenfity it (hp, strength, speed, agility, intelligence, endurance and a name) (line 32),
 defining basic physical attributes without a name to identify the instance (line 43),
 and lastly a constructor that takes an integer as an overload parameter and returns an object of the type of the following presets, correspondingly:
aldean 1, hunter 2, everyday fighter 3, real fighter 4, Swordman 5, hobbit 6, heracles 7, Samson 9 (line 56) 
 */
   
        class Monster : LivingBeing
        {
            public String monstername;


          
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

            /*Monstruos:
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
