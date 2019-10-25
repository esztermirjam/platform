using UnityEngine;

public class BaseClassScript : MonoBehaviour
{
    private string className;
    private int health;
    private int stregth;
    private int damage;
    private int intelligent;
    private bool shoot;

    public string ClassName {
        get { return className;}
        set { className = value;}
    }
    public int Health {
        get { return health;}
        set { health = value;}
    }
    public int Strength {
        get { return stregth;}
        set { stregth = value;}
    }
    public int Damage {
        get { return damage;}
        set { damage = value;}
    }
    public int Intelligent {
        get { return intelligent;}
        set { intelligent = value;}
    }
    public bool Shoot {
        get { return shoot;}
        set { shoot = value;}
    }
}
