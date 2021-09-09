using UnityEngine;

public class ScriptableObjectChanger : MonoBehaviour
{
    [Header ("Scriptable Objects")]
    [SerializeField] private ScriptableObject[] scriptableObjects;

    [Header("Display Scripts")]
    [SerializeField] private MapDisplay mapDisplay;
    [SerializeField] private CarDisplay carDisplay;
    [SerializeField] private GunDisplay gunDisplay;
    private int currentIndex;

    private void Awake()
    {
        ChangeScriptableObject(0);
    }
    public void ChangeScriptableObject(int _change)
    {
        currentIndex += _change;
        if (currentIndex < 0) currentIndex = scriptableObjects.Length - 1;
        else if (currentIndex > scriptableObjects.Length - 1) currentIndex = 0;

        if(mapDisplay != null) mapDisplay.DisplayMap((Map)scriptableObjects[currentIndex]);
        if(carDisplay != null) carDisplay.DisplayCar((Car)scriptableObjects[currentIndex]);
        if(gunDisplay != null) gunDisplay.DisplayGun((Gun)scriptableObjects[currentIndex]);
    }
}