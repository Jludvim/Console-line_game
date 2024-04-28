using basicClasses;

namespace livingBeings{

public abstract class LivingBeing : Entity
{
            protected double Hp;
            protected int Strength;
            protected int Speed;
            protected int Agility;
            protected int Intelligence;
            protected int Endurance;
            public String name="";

            //funciones de asignación/obtención de valores:
            public double gethp() { return this.Hp; }
            public int getStrength() { return this.Strength; }
            public int getSpeed() { return this.Speed; }
            public int getAgility() { return this.Agility; }
            public int getInteligence() { return this.Intelligence; }
            public int getEndurance() { return Endurance; }
            public String getName(){ return name; }

            public void sethp(double hp) { 
                this.Hp = hp; 
                if (hp < 0)  { this.Hp = 0; }
                }
            public void setStrength(int strength) { this.Strength = strength; }
            public void setSpeed(int speed) { this.Speed = speed; }
            public void setAgility(int agility) { this.Agility = agility; }
            public void setIntelligence(int intelligence) { this.Intelligence = intelligence; }
            public void setEndurance(int endurance) { this.Endurance = endurance; }



            //función de ataque
            public (double, string) attack()
            {
            

                /*
                 * funcionalidades:
                 * calcular el ataque del personaje en base sus valores de status
                 * definir un valor aleatorio utilizando la función rand (1-3)
                 * pesar el valor inicial en base al valor aleatorio (suerte)
                 */

                string strEffective;
                double attack = this.Strength + 0.1 * this.Speed + 0.3 * this.Endurance;
                int num;
                Random rand = new Random();
                num = rand.Next(1, 3);


                 /* sobre cálculo de ataque:
                 *1: siendo el valor aleatorio menor que 2, el ataque devuelto será mayor
                 *2: devolverá los valores correspondientes a su status
                 *3: la efectividad de la acción se reduce
                 */
                attack = attack * (2 / num); 
            strEffective = actionString(num, true); 
               
                return (attack, strEffective);
            }

public string actionString(int num, bool attacking){
        string strEffective="";
              
        if(attacking == true){
            if (num == 1)
            {
                strEffective = "Was a great attack";
            }

            else if (num == 2)
            {
                strEffective = "normal attack";
            }

            else if (num == 3)
            {
                strEffective = "an inefficient attack";
            }
        }

                
        else{ /*If attacking isn't true, we are defending*/
                if(num == -999) {
                    strEffective ="It was avoided!";
                }
                else{
                        if (num == 1)
                        {
                            strEffective = "A firm defense";
                        }

                        else if (num == 2)
                        {
                            strEffective = "Decent defense";
                        }

                        else if (num == 3)
                        {
                            strEffective = "Poorly defended";
                        }
                    }
            }
         return strEffective;
        }
            

            

            
            //función de defensa
            public (double, string) defend()
            {

                /*
                * funcionalidades:
                * 1. calcular defensa del personaje en base sus valores de status
                * 2. definir un valor aleatorio utilizando la función rand (1-3)
                * 3. definir un segundo valor aleatorio para un escenario improbable de esquivar
                * 4. pesar el valor inicial (1-3) en base al valor aleatorio (suerte)
                */
          
                Random rand = new Random();
                double defend;
               string strEffective;
               bool isAttacking=false;
                int val = rand.Next(1, 10);
                int val2 = rand.Next(1, 100);

                if (val+this.Agility > val2)
                {

                    /*
                     *@dev de esquivar, defensa es -999, valor seleccionado arbitrariamente para comunicar la acción 
                     */
                    defend = -999;
                    //Console.WriteLine("The attack was avoided!");
                    strEffective=actionString(-999, isAttacking);
                    return (defend, strEffective);
                }

                val = rand.Next(1, 3);
                defend = this.Endurance * 0.5 + (1 / 3) * Strength + 0.1 * this.Speed;
                defend = defend * (2 / val);
                strEffective=actionString(val, isAttacking);

                return (defend, strEffective);
                }


            /*Devuelve un boolean acertando si la instancia de livbeing tiene hp restante*/
            public bool stillAlive()
            {
                bool alive;

                if (this.Hp > 0){
                    alive = true;
                }
                else
                {
                    alive = false;
                }
                return alive;
            }

            public abstract void sound();
    }
}