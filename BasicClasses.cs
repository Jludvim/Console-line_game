
using livingBeings;
using AllObjects;

namespace basicClasses{

      /*

      General Purpose file in which many objects are defined, 
      Chiefly the map and location classes, but also the Entity class
      from which most elements do derive in the program,
      even if its use wasn't determined at the beginning. (See readme.md)
      Most of the classes here displayed are yet not fully developed, they might still lack members,
      logic, and coordination. Yet if looked at, a fair idea of the direction it is aimed at could be formed
         
      Surely enough, this does lack some basic work
      */

   public class Map
   {
         /*it could be more sensible to set the map size in the constructor
         *  It would need a bit of refactoring of procceding any further
         */
      uint x=10;
      uint y=10;
      private Location[,] locations = new Location[10,10];
      uint time;


      Map(){
         locations[0,0].setGround(Location.grounds.grass);
      }

   }

public class Location{
   List<LivingBeing> Livbeings = new List<LivingBeing>();
   List<Objects> objects = new List<Objects>();
   List<Objects> nonMovableObjects = new List<Objects>();
   public enum grounds{
         grass, //0
         soil, //1
         concrete,//2
         rock //3
         }
   grounds ground;
   public void setGround(grounds groundValue){
         ground=groundValue;
      }

         //needs setters
   }

   public class tile{
      
   }

        public abstract class Entity
        {
         
        }

        
        }