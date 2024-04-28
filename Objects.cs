using System.Drawing;
using System.Reflection.Emit;
using basicClasses;
using livingBeings;
using Microsoft.VisualBasic;

namespace AllObjects{


/*
A class and serie of subclasses whose aim is defining the non-living elements of the program,
to be present in a presumed map, with living beings
*/

class Objects : Entity
        {


         uint size; /*Cm*/
         int weight; /*Kg*/
         int atkBonus; 
         int defBonus;
         bool equiped; 
         bool equipable;
         Entity holder;
         string name;

   enum hardness{
      drySoft,
       Soft,
       Hard,
       RockHard
      }

       protected  Objects(
                uint size,
                int weight,
                int atkBonus,
                int defBonus,
                bool equiped, 
                Entity holder,
                string name)
                {
               this.name = name;
               this.holder = holder;
               this.equiped = equiped;
               this.defBonus = defBonus;
               this.atkBonus = atkBonus;
               this.weight = weight;
               this.size = size;
               
            }


      //Objetos que no son armas
       protected  Objects(
                uint size, 
                int weight,
                Entity holder,
                string name)
                {
               this.name = name;
               this.holder = holder;
               this.equiped = false;
               this.defBonus = 0;
               this.atkBonus = 0;
               this.equipable = false;
               this.weight = weight;
               this.size = size;
               }



      //Objetos estáticos
      protected  Objects(
                uint size, 
                Entity holder,
                string name)
                {
               this.name = name;
               this.holder = holder;
               this.equiped = false;
               this.defBonus = 0;
               this.atkBonus = 0;
               this.equipable = false;
               this.weight = int.MaxValue; 
               this.size = size;
               }

public bool canLift(LivingBeing lifter){
int liftPower = lifter.getStrength();
if (liftPower < this.weight){
return false;
}
return true;
}

}

abstract class Weapon : Object {

}

class Tree : Objects{
string dialog;
string species;

public Tree(
      string species,
      uint size, 
      Entity holder,
      string name
      ) : base(size, holder, name){

         this.species=species;
         this.dialog = "A tree of "+species;
}

public Tree(string species, Entity holder) : base (1, int.MaxValue, holder, "Tree"){
this.species=species;
this.dialog = "It's a "+species;
}

}




/*
Necesita una revisión:

class Bush : Objects{
string dialog;
Color leafColor;
bool hidesSomething;
Entity hidden;
public Bush(Color leafColor, uint size, Entity holder, string name
      ) : base(size, holder, name)
      {
   this.leafColor = leafColor;
   this.dialog = "It's a bush";
      }


public string interact(){
   string dialog="";
 if(this.hidesSomething == false){
 dialog=this.dialog;
  }
 else{
   if(this.hidden is LivingBeing){
      hidden.interact();
   }
 }
 return dialog;
}

}
*/
//Pond, rock, Car, branches, swords, shields, armor, etc to do!


}