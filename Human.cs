 using livingBeings;

 //clase humana
namespace humanities{

 /*
 This is a file in which the human class is defined. It does derive from LivingBeing, and defines many overloads to create characters.
 Some defining no feature, and using default stat-values (see line 20), 
 defining basic physical attributes and a name to idenfity it (hp, strength, speed, agility, intelligence, endurance and a name) (line 33),
 defining basic physical attributes without a name to identify the instance (line 45),
 and lastly a constructor that takes an integer as an overload parameter and returns an object of the type of the following presets, correspondingly:
aldean 1, hunter 2, everyday fighter 3, real fighter 4, Swordman 5, hobbit 6, heracles 7, Samson 9 (line 62) 
 */
        class Human : LivingBeing
        {
 

            //constructores
            public Human()
            {
                this.name = "A person";
                Hp = 100;
                this.Strength = 10;
                this.Speed = 10;
                this.Endurance = 10;
                this.Agility = 10;
                this.Intelligence = 10;
                
            }

            /*Construcción totalmente personalizable*/
            public Human(double hp, int strength, int speed, int agility, int intelligence, int endurance, string name)
            {
                this.Hp = hp;
                this.Strength = strength;
                this.Speed = speed;
                this.Agility = agility;
                this.Intelligence = intelligence;
                this.Endurance = endurance;
                this.name = name;
            }

            /*Personalizable, sin definir un identificador único*/
            public Human(double hp, int strength, int speed, int agility, int intelligence, int endurance)
            {
                this.name = "a person";
                this.Hp = hp;
                this.Strength = strength;
                this.Speed = speed;
                this.Agility = agility;
                this.Intelligence = intelligence;
                this.Endurance = endurance;
                
            }


            /*constructor de sobrecarga, que devuelve una persona de alguno de los tipos definidos:
             aldean 1, hunter 2, everyday fighter 3, real fighter 4, Swordman 5, hobbit 6, heracles 7, Samson 9
            */

            public Human(int overload)
            {

                
                if (overload == 1)
                {
                    this.name = "Aldean";
                    this.Endurance = 8;
                    this.Intelligence = 10;
                    this.Agility = 6;
                    this.Strength = 7;
                    this.Speed = 5;
                    this.Hp = 20;
                }
                else if (overload == 2)
                {
                    this.name = "hunter";
                    this.Endurance = 10;
                    this.Intelligence = 9;
                    this.Agility = 6;
                    this.Strength = 14;
                    this.Speed = 7;
                    this.Hp = 20;
                }
                else if (overload == 3)
                {
                    this.name = "Every-day fighter";
                    this.Endurance = 10;
                    this.Intelligence = 7;
                    this.Agility = 11;
                    this.Strength = 20;
                    this.Speed = 11;
                    this.Hp = 150;
                }
            
                else if (overload == 4)
                {
                    this.name = "Real fighter";
                    this.Endurance = 15;
                    this.Intelligence = 15;
                    this.Agility = 15;
                    this.Strength = 15;
                    this.Speed = 15;
                    this.Hp = 150;
                }
                else if (overload == 5)
                {
                    this.name = "Swordman";
                    this.Endurance = 20;
                    this.Intelligence = 10;
                    this.Agility = 20;
                    this.Strength = 30;
                    this.Speed = 25;
                    this.Hp = 200;
                }

                else if (overload == 6)
                {
                    this.name = "Hobbit";
                    this.Hp = 77;
                    this.Strength = 7;
                    this.Speed = 20;
                    this.Agility = 25;
                    this.Endurance = 15;
                    //bool luck = true; /*needs a proper implementation!*/

                }

                else if (overload == 7)
                {
                    this.name = "Hercules";
                    this.Hp = 200;
                    this.Strength = 300;
                    this.Speed = 40;
                    this.Agility = 40;
                    this.Endurance = 200;
                }

                /*Couldn't think of anything between, and liked the 9 for Samson*/

                else if (overload == 9)
                {
                    this.name = "Samson";
                    this.Hp = 210;
                    this.Strength = 500;
                    this.Speed = 70;
                    this.Agility = 70;
                    this.Endurance = 77;

                }

                else if (overload < 1)
                {
                    this.name = "weak one";
                    this.Endurance = 5;
                    this.Agility = 4;
                    this.Strength = 3;
                    this.Speed = 2;
                    this.Hp = 10;
                }
            }



          public override void sound()
            {
 
                Console.WriteLine("Buenas!"); 
                /*That's what a spanish knight should sound like*/
            } 

        }

    }
