using System;
using System.Collections;
using System.Runtime.Serialization;
using System.Text.Json.Serialization.Metadata;
 using livingBeings;
 using  humanities;
 using OtherCreatures;

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

        public static double damage(double attackerAct, double defenderAct)
        {
            double damage = 0;


            if (defenderAct == -999) /*si defensa es -999*/ { damage = 0;
                Console.WriteLine("It was avoided!");
            }
            else {
                damage = attackerAct - defenderAct; }
            return damage;
        }



        /*Only visually relevant*/
        public static void bars()
        {
            for (int i = 0; i < 17; i++) { Console.Write("//"); }
            
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
                bars();


                int chooseVal = 0;
                bool validChoice = false;



                Monster beast;
                /*Iteración que busca conseguir un valor para definir el adversario*/
                do
                {
                    Console.WriteLine("\n\n Pick a monster from the rooster: ");
                    Console.WriteLine("-Normal Monster (1) \n-Goblin (2) \n-Troll (3) \n-Wolf (4) \n-Minotaur (5)");
                    for (int i = 0; i < 10; i++) { Console.Write("-"); }


                    try
                    {
                        Console.WriteLine("\n============>"); chooseVal = int.Parse(Console.ReadLine());
                        validChoice = true;
                    
                    }
                    catch (Exception)
                    {

                        validChoice = false;
                        Console.WriteLine("There has been an error, input a value from the rooster");
                    }


                    if (chooseVal < 1 || chooseVal > 5) { validChoice = false; }
                    else { validChoice = true; }
                    /*Valores aceptados: Normal monster 1, Goblin 2, troll 3, wolf 4, minotaur 5*/


                } while (validChoice == false);

                beast = new Monster(chooseVal);


       


                Console.Clear();

                Human man;
                do
                {
                    bars();
                    Console.WriteLine("\n\n Pick a person from the rooster: ");
                    Console.WriteLine("-Aldean (1) \n-Hunter (2) \n-Every-day fighter (3) \n-Real Fighter (4) \n-Swordman (5)" +
                        "\n-Hobbit (6) \n-Heracles (7) \n-Samson (9)");
                    for (int i = 0; i < 10; i++) { Console.Write("-"); }

                    chooseVal = 0;
                    validChoice = false;
                    try
                    {
                        Console.WriteLine("\n============>"); chooseVal = int.Parse(Console.ReadLine());
                        validChoice = true;
                    }
                    catch (Exception)
                    {
                        validChoice = false;
                        Console.WriteLine("There has been an error, input a value from the rooster");
                    }


                    if (chooseVal<1 || chooseVal>9) { validChoice = false; }
                    else { validChoice = true; }
                    /*valores aceptados:
                    * aldean 1, hunter 2, everyday fighter 3, real fighter 4, Swordman 5,
                    * hobbit 6, heracles 7, Samson 9*/

                } while (validChoice == false);

                man = new Human(chooseVal);

                Console.Clear();
                Console.WriteLine("Press enter to start"); Console.ReadKey();
                Console.WriteLine("");

                do
                {
                    double manAct,
                        beastAct,
                        damage;
                        string atkEffective, defEffective;
                   
                    if (man.stillAlive() == true)
                    {
                        Console.WriteLine(man.name + " attacks " + beast.monstername);
                        (manAct, atkEffective) = man.attack();
                        (beastAct, defEffective) = beast.defend();
                        damage = game.damage(manAct,beastAct);

                        beast.sethp(beast.gethp() - damage);

                        Console.WriteLine(atkEffective);
                        Console.WriteLine(defEffective);
                        Console.WriteLine(man.name + "'s HP: " + man.gethp());
                        Console.WriteLine(beast.monstername + "'s HP: " + beast.gethp());
                        Console.WriteLine("Damage dealt: " + damage);
                    }

                    Console.Write("\nPress enter to continue...\n"); Console.ReadKey();
                    Console.WriteLine("");

                    if (beast.stillAlive() == true)
                    {
                        Console.WriteLine(beast.monstername + " attacks " + man.name);
                        (beastAct, atkEffective) = beast.attack();
                        (manAct, defEffective) = man.defend();
                        damage = game.damage(beastAct, manAct);
                        man.sethp(man.gethp() - damage);

                        Console.WriteLine(atkEffective);
                        Console.WriteLine(defEffective);
                        Console.WriteLine(man.name + "'s HP: " + man.gethp());
                        Console.WriteLine(beast.monstername + "'s HP: " + beast.gethp());
                        Console.WriteLine("Damage dealt: " + damage);

                        Console.Write("\nPress enter to continue...\n"); Console.ReadKey();
                        Console.WriteLine("");
                    }
                    if (man.gethp() <= 0 || beast.gethp() <= 0)
                    {
                        Console.WriteLine("The battle is over.");
                        if (man.gethp() <= 0)
                        {
                            Console.WriteLine(man.name + " can't continue, beast wins!");
                            beast.sound();
                        }
                        else if (beast.gethp() <= 0)
                        {
                            Console.WriteLine(beast.monstername + " can't continue, man wins!");
                            man.sound();
                        }
                        Console.WriteLine("Battle finished.");


                        Console.Write("Press a key to exit");
                        Console.ReadKey();
                    }
                } while (man.gethp() > 0 && beast.gethp() > 0);

                do
                {
                    Console.WriteLine("Do you wish to continue? ('s' to accept, 'n' to exit)");
                    Console.Write("=======>"); s = Console.ReadLine();
                } while (s != "s" && s != "n");

            } while (s == "s");

            if (s == "n")
            {
                Console.WriteLine("Hasta pronto");
                Console.ReadLine();
            }
        }
    }

}
