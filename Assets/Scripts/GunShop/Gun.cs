using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "Scriptable Objects/Gun")]
public class Gun : ScriptableObject
{
    public string gunName;
    public int damage;
    public int accuracy;
    public int range;
    public int fireRate;
    public GameObject gunModel;
}