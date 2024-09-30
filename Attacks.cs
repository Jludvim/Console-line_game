using System.Reflection.Metadata.Ecma335;

public static class Movements{

//Maybe take the attack stat that we get here (which needs to be fixed, to see whether the mod 2 is 0 or 1, and if 
//it is one, rest 1), and then pass that value to the actual attack function. More arguments could be added
//To finally condition the result of an attack more precisely.

 // this.Strength + 0.1 * this.Speed + 0.3 * this.Endurance


public enum attacks{
    NormalPunch, Kick, Parry
}

public static double normalPunch(int strength, int speed, int endurance) {
double atkPower = (strength + 0.1 * speed+ 0.3 * endurance) / 2;

return atkPower;
}

public static double kick(int strength, int speed, int endurance){
double atkPower = (strength + 0.2 * speed + 0.5 * endurance) / 2;

return atkPower;
}

public static double parry(int strength, int speed){
int parryPower = (strength + speed) / 2;
return parryPower;
}


}