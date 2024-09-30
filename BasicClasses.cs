
using livingBeings;
using AllObjects;

namespace basicClasses{

      /*
       General Purpose file in which many objects are defined, 
      Chiefly the map and location classes, but also the Entity class
      from which most elements do derive in the program,
      even if its use wasn't determined at the beginning.
      Most of the classes here displayed are yet not fully developed, they might still lack members,
      logic, and coordination. But it was only an exploration of OOP.
      */
      
      /*
      Archivo para uso generales en el que varias clases se definen. 
      Principalmente el mapa y casilla o ubicación, pero también entidad, de la cual la mayoría de elementos del programa derivan
      La mayor parte de las clases no están completamente desarrolladas
      */

   public class Map
   {
      uint sizeX=10;
      uint sizeY=10;
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

         //necesita setters
   }

   public class tile{
      
   }

        public abstract class Entity
        {
         
        }

        
        }
