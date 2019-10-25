using UnityEngine;

public class BaseWarrior : BaseClassScript
{
    public BaseWarrior(){
        ClassName = "BaseWarrior";
        Health = 10;
        Strength = 5;
        Intelligent = 2;
        Damage = Strength * 5;
        Shoot = false;
    }
}
