 using livingBeings;

 //clase humana
namespace humanities{


        public class Human : LivingBeing
        {
 
            public static string[] namesByNumericOverload =
             {"Aldean", "hunter", "Every-day fighter", "Real fighter", "Swordman", "Hobbit", "Heracles", "Samson"};

            
            public string[] attackStrings;
            /*public enum attacks{
                NormalPunch, Kick
            }*/
            
            public string lastAttack;

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
                this.typeOfCreature = "human";
            }

            public Human(double hp, int strength, int speed, int agility, int intelligence, int endurance, string name)
            {
                this.Hp = hp;
                this.Strength = strength;
                this.Speed = speed;
                this.Agility = agility;
                this.Intelligence = intelligence;
                this.Endurance = endurance;
                this.name = name;
                this.typeOfCreature = "human";                
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
                this.typeOfCreature = "human";
                
            }


            /*constructor de sobrecarga, que devuelve una persona de alguno de los tipos definidos:
             aldean 0, hunter 1, everyday fighter 2, real fighter 3, Swordman 4, hobbit 5, heracles 6, Samson 7
            */

            public Human(int overload)
            {

                this.typeOfCreature = "human";

                if (overload == 0)
                {
                    //aldean
                    this.name = namesByNumericOverload[overload];
                    this.Endurance = 8;
                    this.Intelligence = 10;
                    this.Agility = 6;
                    this.Strength = 7;
                    this.Speed = 5;
                    this.Hp = 20;
                    attackStrings = new string[] {"PUNCH", "KICK"};
                }
                else if (overload == 1)
                {
                    //hunter
                    this.name = namesByNumericOverload[overload];
                    this.Endurance = 10;
                    this.Intelligence = 9;
                    this.Agility = 6;
                    this.Strength = 14;
                    this.Speed = 7;
                    this.Hp = 20;
                    attackStrings = new string[] {"PUNCH", "KICK", "SPEAR PIERCE"};
                }
                else if (overload == 2)
                {
                    //everyday fighter
                    this.name = namesByNumericOverload[overload];
                    this.Endurance = 10;
                    this.Intelligence = 7;
                    this.Agility = 11;
                    this.Strength = 20;
                    this.Speed = 11;
                    this.Hp = 150;
                    attackStrings = new string[] {"PUNCH", "KICK"};
                }
            
                else if (overload == 3)
                {
                    //real fighter
                    this.name = namesByNumericOverload[overload];
                    this.Endurance = 15;
                    this.Intelligence = 15;
                    this.Agility = 15;
                    this.Strength = 15;
                    this.Speed = 15;
                    this.Hp = 150;
                    attackStrings = new string[] {"PUNCH", "KICK", "MARTIAL HIT"};
                }
                else if (overload == 4)
                {
                    //Swordman
                    this.name = namesByNumericOverload[overload];
                    this.Endurance = 20;
                    this.Intelligence = 10;
                    this.Agility = 20;
                    this.Strength = 30;
                    this.Speed = 25;
                    this.Hp = 200;
                    attackStrings = new string[] {"PUNCH", "KICK", "SWORD SWING"};
                }

                else if (overload == 5)
                {
                    //hobbit
                    this.name = namesByNumericOverload[overload];
                    this.Hp = 77;
                    this.Strength = 7;
                    this.Speed = 20;
                    this.Agility = 25;
                    this.Endurance = 15;
                    //bool luck = true; /*Parece una buena idea*/
                    attackStrings = new string[] {"PUNCH", "KICK", "SWORD SWING", "HILT HIT"};
                }

                else if (overload == 6)
                {
                    //Heracles
                    this.name = namesByNumericOverload[overload];
                    this.Hp = 200;
                    this.Strength = 300;
                    this.Speed = 40;
                    this.Agility = 40;
                    this.Endurance = 200;
                    attackStrings = new string[] {"PUNCH", "KICK", "SWORD SWING", "HILT HIT"};
                }

                else if (overload == 7)
                {
                    //Samson
                    this.name = namesByNumericOverload[overload];
                    this.Hp = 210;
                    this.Strength = 500;
                    this.Speed = 70;
                    this.Agility = 70;
                    this.Endurance = 77;
                    attackStrings = new string[] {"PUNCH", "KICK", "DONKEY JAWBONE HIT"};
                }

            }



            public override void sound()
            {
 
                Console.WriteLine("Buenas!"); 
                /*That's what a spanish knight should sound like*/
            }
       
       
        public double punch() {
        double atkPower = (this.getStrength() + 0.1 * this.getSpeed()+ 0.3 * this.getEndurance()) / 2;

        //add a string called last Attack
        return (atkPower);
        }

        public double kick(){
        double atkPower = (this.getStrength() + 0.2 * this.getSpeed()+ 0.5 * this.getEndurance()) / 2;

        return (atkPower);
        }

        public double MartialHit(){
            double atkPower = (this.getStrength() + 0.9 * this.getSpeed() + 0.5 * this.getEndurance());
            return atkPower;
        }

        public double swordSwing(){
            double atkPower = (this.getStrength() + 0.5 * this.getSpeed() + 0.5 * this.getEndurance()) / 2;
            return atkPower;
        }

        public double donkeyJawboneHit(){
            double atkPower = (this.getStrength() + 0.3 * this.getSpeed() + 0.5 * this.getEndurance()) / 2;
            return atkPower;
        }

        public double hiltHit(){
            double atkPower = (this.getStrength() + 0.3 * this.getSpeed() + 0.9 * this.getEndurance()) / 2;
            return atkPower;
        }

       public double spearPierce(){
            double atkPower = (this.getStrength() + 0.7 * this.getSpeed() + 0.99 * this.getEndurance()) / 2;
            return atkPower;
        }

        public override (double,string) attackSelector(string atk){
            double atkPower=0;
            string strEffective;
            double attack;

            if(atk == "PUNCH"){
                atkPower = punch();
                lastAttack = atk;
            }
            else if(atk == "KICK"){
            atkPower = kick();
            lastAttack = atk;
            }

            else if(atk == "DONKEY JAWBONE HIT"){
            atkPower = donkeyJawboneHit();
            lastAttack = atk;
            }
            
            else if(atk == "MARTIAL HIT"){
            atkPower = MartialHit();
            lastAttack = atk;
            }
            
            else if(atk == "SWORD SWING"){
            atkPower = MartialHit();
            lastAttack = atk;
            }

            else if (atk == "HILT HIT"){
                atkPower = hiltHit();
                lastAttack = atk;
            }

            else if ( atk == "SPEAR PIERCE" ){
                atkPower = spearPierce();
                lastAttack = atk;
            } 

                
            (attack, strEffective) = this.attack(atkPower);
            return (attack, strEffective);
        }

        

        public override string[] getAttackStrings(){
            return attackStrings;
        }

    }

}
