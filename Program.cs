using System;
using System.Collections;
using System.Runtime.Serialization;
using System.Text.Json.Serialization.Metadata;
 using livingBeings;
 using  humanities;

namespace game
{


    /*
    * A small implementation of the LivingBeing sub-classes: human and monster!
    * You can pick a hero, and make it fight against a monster on its own
    * shall the best one win!
    */
    


    public static class game
    {

        //funciones

        public static double damage(double attackerActionScore, double defenderActionScore)
        {
            double damage = 0;


            if (defenderActionScore == -999) /*si defensa es -999*/ { damage = 0;
                Console.WriteLine("It was avoided!");
            }
            else {
                if(attackerActionScore > defenderActionScore)
                {
                damage = attackerActionScore - defenderActionScore;
                }
                else{
                    damage = 0;
                }
            }
            return damage;
        }



        public static void bars(string argument)
        {
            Console.WriteLine();
            for (int i = 0; i < 17; i++) { Console.Write(argument); }
        }


        public static int pickCharacter(string type){

            bool validChoice;
            int chooseVal = 0;
            type = type.ToLower();

                do
                {
                    bars("//");
                    Console.WriteLine("\n\n Pick a character from the rooster: ");
                    if(type == "monster"){
                        for(int i=0; i<Monster.namesByNumericOverload.Length;i++){
                            Console.WriteLine(i+" - "+ Monster.namesByNumericOverload[i]);
                        }
                    }
                    if(type == "human"){                        
                        for(int i=0; i<Human.namesByNumericOverload.Length;i++){
                            Console.WriteLine(i+" - "+Human.namesByNumericOverload[i]);
                        }
                    }
                    bars("--");

                    
                    validChoice = false;
                    try
                    {
                        Console.Write("\n============>"); chooseVal = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("There has been an error, input a value from the rooster");
                    }

                    if(type == "human"){
                        if(chooseVal > Human.namesByNumericOverload.Length-1 || chooseVal<0){
                            Console.WriteLine("Choosen value is not within the allowed range");
                            validChoice = false;

                        }
                        else{
                            validChoice = true;
                        }
                    }
                    if(type == "monster"){
                        if(chooseVal > Monster.namesByNumericOverload.Length-1 || chooseVal<0){
                            Console.WriteLine("Choosen value is not within the allowed range");
                            validChoice = false;
                        }
                        else{
                            validChoice = true;
                        }
                    }
                } while(validChoice == false);

                return chooseVal;
        }


        public static (double, string) chooseAttack(Human attacker, Monster enemy){
            int answer=0;
            double WeightedAtkScore;
            string strEffective;
            do{
                try
                {
                    string listOfAttacksString = "\nChoose an attack: ";
                    for(int i=0; i<attacker.attackStrings.Length; i++){
                        listOfAttacksString += "\n"+ (i+1) + ". " + attacker.attackStrings[i];
                    }
                    Console.Clear();
                    bars("/////");
                    Console.Write("\nYour hp: "+ attacker.gethp()+ "\nEnemy's hp: "+ enemy.gethp()); //this should be fixed
                    bars("  ");
                    Console.Write(listOfAttacksString);
                    bars("|||||");
                    Console.Write("\n========>"); answer = int.Parse(Console.ReadLine());
                    bars("/////");
                    if(answer < 1 && answer > attacker.attackStrings.Length) 
                    {
                        Console.WriteLine("Error, invalid input, press a key to try again _"); Console.ReadKey(); 
                    }
                }
                catch(System.FormatException){
                    Console.WriteLine("Error. Input should be an integer value. Press a key to try again");
                    Console.ReadKey(); 
                }
            } while(answer < 1 && answer > attacker.attackStrings.Length);

            answer--; //Indexes had been increased by 1 for user readibility
            
            (WeightedAtkScore, strEffective) = /*function*/attack(attacker,answer);
            
            string action = "\n"+attacker.getName()+" uses "+attacker.attackStrings[answer]+"!\n"+strEffective;

            return (WeightedAtkScore, action);
        }

        public static (double, string) attack(LivingBeing attacker, int movementChosen){
            
            double attack;
            string strEffective;
            string movement="";

            string[] attackStrings = attacker.getAttackStrings();

                movement = attackStrings[movementChosen];

            (attack, strEffective) = attacker.attackSelector(movement);

            return (attack, strEffective);


        }

        public static void fight(Human user, Monster enemy){
            double manAction, beastAction, damage;
            string atkEffective, defEffective;
            
            do{  
                    manAction = 0;
                    beastAction = 0; 
                    damage = 0;

                        if (user.stillAlive() == true) //Given that attacks happens in turns, enemy should still be alive
                        {
                            Console.WriteLine(user.name + " attacks " + enemy.name);
                            (manAction, atkEffective) = chooseAttack(user, enemy);
                            (beastAction, defEffective) = enemy.defend();
                            damage = game.damage(manAction, beastAction);

                            enemy.sethp(enemy.gethp() - damage);

                            Console.WriteLine(atkEffective);
                            Console.WriteLine(defEffective);

                            Console.WriteLine(user.name + "'s HP: " + user.gethp());
                            Console.WriteLine(enemy.name + "'s HP: " + enemy.gethp());
                            Console.WriteLine("Damage dealt: " + damage);
                        }

                        Console.Write("\nPress enter to continue...\n"); Console.ReadKey();
                        Console.WriteLine("");

                        if (enemy.stillAlive() == true)
                        {
                            Console.WriteLine(enemy.name + " attacks " + user.name);
                            (beastAction, atkEffective) = enemy.basic_attack();
                            (manAction, defEffective) = user.defend();
                            damage = game.damage(beastAction, manAction);
                            user.sethp(user.gethp() - damage);

                            Console.WriteLine(atkEffective);
                            Console.WriteLine(defEffective);
                            Console.WriteLine(user.name + "'s HP: " + user.gethp());
                            Console.WriteLine(enemy.name + "'s HP: " + enemy.gethp());
                            Console.WriteLine("Damage dealt: " + damage);

                            Console.Write("\nPress enter to continue...\n"); Console.ReadKey();
                            Console.WriteLine("");
                        }
                        if (user.gethp() <= 0 || enemy.gethp() <= 0)
                        {
                            Console.WriteLine("The battle is over.");
                            if (user.gethp() <= 0)
                            {
                                Console.WriteLine(user.name + " can't continue, beast wins!");
                                enemy.sound();
                            }
                            else if (enemy.gethp() <= 0)
                            {
                                Console.WriteLine(enemy.name + " can't continue, man wins!");
                                user.sound();
                            }
                            Console.WriteLine("Battle finished.");


                            Console.Write("Press a key to exit");
                            Console.ReadKey();
                        }
                } while (user.gethp() > 0 && enemy.gethp() > 0);
        }



        public static int getRandomValueWithinRange(int a, int b){
            int num;
                Random rand = new Random();
                num = rand.Next(a, b);

            return num;
        }

        /**
         * @dev Una implementación sencilla utilizando solamente las clases monstruo y persona
         * 
         */

        public static void Main(String[] args)
        {

               
            Console.WriteLine("Welcome");
            Console.WriteLine("Here, two contendants will fight \n");
            Console.WriteLine("Press enter to continue..."); Console.ReadKey();


            String s="";
            do
            {
                Console.Clear();
                bars("//");
                int chooseVal;

                chooseVal = pickCharacter("human");
                Human man;
                man = new Human(chooseVal);

                chooseVal = pickCharacter("monster");
                Monster beast;
                beast = new Monster(chooseVal);
                Console.Clear();

                Console.Clear();
                Console.Write("Press a key to start"); Console.ReadKey();
                Console.WriteLine("");

                fight(man, beast);

                do
                {
                    bars("|--|");
                    Console.WriteLine("\nDo you wish to continue? ('s' to accept, 'n' to exit)");
                    Console.Write("=======>"); s = Console.ReadLine();
                    s = s.ToLower();
                } while (s != "s" && s != "n");


                //Do-while game loop
            } while (s == "s");

            if (s == "n")
            {
                Console.WriteLine("Hasta pronto");
                Console.ReadLine();
            }
        }
    }
}
