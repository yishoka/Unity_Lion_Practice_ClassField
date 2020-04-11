using UnityEngine;
/// <summary>
/// 怪物屬性
/// </summary>
public class Enemy : MonoBehaviour
{
    /// <summary>
    /// 怪物的血量
    /// </summary>
    [Header("血量"),Tooltip("怪物的血量"),Range(50,500)]
    public int HP;

    /// <summary>
    /// 怪物的魔力
    /// </summary>
    [Header("魔力"),Tooltip("怪物的魔力"),Range(10,100)]
    public int MP = 100;

    /// <summary>
    /// 怪物的移動速度
    /// </summary>
    [Header("能力值"),Range(1,50.5f)]
    public float speed = 10.5f;

    /// <summary>
    /// 怪物的攻擊力
    /// </summary>
    [Range(20,200)]
    public int ATK = 50;

    /// <summary>
    /// 怪物的防禦力
    /// </summary>
    [Range(0,100)]
    public int DEF;

    /// <summary>
    /// 怪物的武器名稱
    /// </summary>
    [Header("裝備")]
    public string Weapon;

    /// <summary>
    /// 怪物的裝備名稱
    /// </summary>
    public string Equip = "皮衣";

    /// <summary>
    /// 怪物是否帶有鑰匙
    /// </summary>
    [Header("其他資料"),Tooltip("怪物是否帶有鑰匙")]
    public bool Key = false;

    /// <summary>
    /// 怪物是否掉落寶物
    /// </summary>
    [Tooltip("怪物是否帶有寶物")]
    public bool Treasure = false;

}
