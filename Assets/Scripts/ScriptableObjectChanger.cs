using UnityEngine;

public class ScriptableObjectChanger : MonoBehaviour
{
    [SerializeField] private ScriptableObject[] scriptableObjects;

    [Header ("Display Scripts")]
    [SerializeField] private MapUIDisplay mapDisplay;
    [SerializeField] private CarDisplay carDisplay;
    [SerializeField] private GunDisplay gunDisplay;
    private int currentMapIndex;

    private void Awake()
    {
        ChangeMap(0);
    }

    public void ChangeMap(int _index)
    {
        currentMapIndex += _index;
        if (currentMapIndex < 0) currentMapIndex = scriptableObjects.Length - 1;
        if (currentMapIndex > scriptableObjects.Length - 1) currentMapIndex = 0;
        
        if(mapDisplay != null) mapDisplay.UpdateMap((Map)scriptableObjects[currentMapIndex]);
        if(carDisplay != null) carDisplay.UpdateCar((Car)scriptableObjects[currentMapIndex]);
        if(gunDisplay != null) gunDisplay.UpdateGun((Gun)scriptableObjects[currentMapIndex]);
    }
}