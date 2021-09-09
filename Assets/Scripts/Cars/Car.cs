using UnityEngine;

[CreateAssetMenu(fileName = "New Car", menuName = "Scriptable Objects/Car")]
public class Car : ScriptableObject
{
    [Header("Description")]
    public string carName;
    public string carDescription;

    [Header("Stats")]
    public int carPrice;
    public float speed;
    public float acceleration;
    public float handling;

    [Header("3D Model")]
    public GameObject carModel;
}