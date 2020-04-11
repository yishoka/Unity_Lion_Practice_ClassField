using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Enemy Slime1;
    public Enemy Slime2;

    public void Start()
    {
        print("史萊姆1號的魔力是：" + Slime1.MP);
        print("史萊姆2號的裝備是：" + Slime2.Equip);

        Slime1.HP = 100;
        Slime2.HP = 300;
        Slime1.DEF = 50;
        Slime1.Weapon = "木棍";
        Slime2.Weapon = "短刀";
        Slime1.Key = true;
        Slime2.Treasure = true;
    }

}
