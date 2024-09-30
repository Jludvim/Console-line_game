using livingBeings;

 /*
 This is a file in which the monster class is defined, and gives room for the definition of many other classes that are non-human.
 It does derive from LivingBeing, and defines many overloads to create characters.
 Some defining no feature, and using default stat-values (see line 20), 
 defining basic physical attributes and a name to idenfity it (hp, strength, speed, agility, intelligence, endurance and a name) (line 32),
 defining basic physical attributes without a name to identify the instance (line 43),
 and lastly a constructor that takes an integer as an overload parameter and returns an object of the type of the following presets, correspondingly:
aldean 1, hunter 2, everyday fighter 3, real fighter 4, Swordman 5, hobbit 6, heracles 7, Samson 9 (line 56) 
 */
   
        public class Monster : LivingBeing
        {
            public String name;

            public string[] attackStrings;
            string lastAttack;
             public static string[] namesByNumericOverload = {"normal monster", "Goblin", "Troll", "Wolf", "Minotaur" };

            public Monster()
            {
                this.Hp = 100;
                this.Strength = 10;
                this.Speed = 10;
                this.Agility = 10;
                this.Intelligence = 10;
                this.Endurance = 10;
                this.name = "monster";
                this.typeOfCreature = "monster";

            }

            public Monster(double hp, int strength, int speed, int agility, int intelligence, int endurance, string monstername)
            {
                this.Hp = hp;
                this.Strength = strength;
                this.Speed = speed;
                this.Agility = agility;
                this.Intelligence = intelligence;
                this.Endurance = endurance;
                this.name = monstername;
                this.typeOfCreature = "monster";
            }

            public Monster(double hp, int strength, int speed, int agility, int intelligence, int endurance)
            {
                this.Hp = hp;
                this.Strength = strength;
                this.Speed = speed;
                this.Agility = agility;
                this.Intelligence = intelligence;
                this.Endurance = endurance;
                this.name = "Unnamed wild monster";
                this.typeOfCreature = "monster";
            }

            /*Monstruos:
             * 1. normal monster, 2. goblin, 3. troll, 4. wolf, 5. minotaur*/
            public Monster(int overload)
            {

                if (overload == 0)
                {
                    //normal monster
                    this.name = namesByNumericOverload[overload];
                    this.Hp = 100;
                    this.Strength = 10;
                    this.Speed = 10;
                    this.Agility = 10;
                    this.Intelligence = 10;
                    this.Endurance = 10;
                    attackStrings = new string[] {"SCRATCH"};

                    
                }

                else if (overload == 1)
                {
                    //goblin
                    this.name = namesByNumericOverload[overload];
                    this.Hp = 15;
                    this.Strength = 4;
                    this.Speed = 7;
                    this.Agility = 4;
                    this.Endurance = 4;
                    attackStrings = new string[] {"SCRATCH", "PUNCH"};
                }
                
                else if (overload == 2)
                {
                    //Troll
                    this.name = namesByNumericOverload[overload];
                    this.Hp = 200;
                    this.Strength = 30;
                    this.Speed = 10;
                    this.Agility = 9;
                    this.Endurance = 35;
                    attackStrings = new string[] {"SCRATCH", "PUNCH", "KICK", "RUSH"};
                }


                else if (overload == 3)
                {
                    //Wolf
                    this.name = namesByNumericOverload[overload];
                    this.Hp = 100;
                    this.Strength = 18;
                    this.Speed = 25;
                    this.Agility = 30;
                    this.Endurance = 20;
                    attackStrings = new string[] {"SCRATCH", "BITE", "RUSH"};
                }

                else if (overload == 4)
                {
                    //Minotaur
                    this.name = namesByNumericOverload[overload];
                    this.Hp = 500;
                    this.Strength = 200;
                    this.Speed = 50;
                    this.Agility = 50;
                    this.Endurance = 100;
                    attackStrings = new string[] {"KICK", "PUNCH", "HORN PIERCE", "RUSH"};
                }

            }

            public override void sound()
            {
                Console.WriteLine("Aurrgh!");
                /*Very monstruous!*/
            }


       public double punch() {
        double atkPower = (this.getStrength() + 0.1 * this.getSpeed()+ 0.3 * this.getEndurance()) / 2;

        this.lastAttack = "PUNCH";

        return atkPower;
        }

        public double kick(){
        double atkPower = (this.getStrength() + 0.2 * this.getSpeed()+ 0.5 * this.getEndurance()) / 2;

        this.lastAttack = "KICK";

        return atkPower;
        }

        public double bite(){
        double atkPower = (this.getStrength() + 0.4 * this.getSpeed()+ 0.8 * this.getEndurance()) / 2;

        this.lastAttack = "BITE";

        return atkPower;
        }

        public double scratch(){
        double atkPower = (this.getStrength() + 0.9 * this.getSpeed()+ 0.1 * this.getEndurance()) / 2;

        this.lastAttack = "SCRATCH";

        return atkPower;
        }

        public double hornPierce(){
        double atkPower = (this.getStrength() + 0.9 * this.getSpeed()+ 0.1 * this.getEndurance()) / 2;

        this.lastAttack = "HORN PIERCE";

        return atkPower;
        }
        
        public double rush(){
        double atkPower = ( this.getStrength() + 0.9 * this.getSpeed() + 0.9 * this.getEndurance() ) / 2;

        this.lastAttack = "RUSH";

        return atkPower; 
        }

        
   
   
        public override (double,string) attackSelector(string atk){
            double atkPower=0;
            string strEffective;
            double attack;

            if(atk == "PUNCH"){
            atkPower = punch();
            }
            else if(atk == "KICK"){
            atkPower = kick();
            }
            else if(atk == "BITE"){
            atkPower = bite();
            }
            else if(atk == "SCRATCH"){
            atkPower = scratch();
            }
            else if(atk == "HORN PIERCE"){
            atkPower = hornPierce();
            }
            else if(atk == "RUSH"){
                atkPower = rush();
            }

            
                
            (attack, strEffective) = this.attack(atkPower);
            return (attack, strEffective);
        }
        
        public override string[] getAttackStrings(){
            return attackStrings;
        }

    }


