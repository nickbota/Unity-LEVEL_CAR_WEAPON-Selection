using UnityEngine;
using UnityEngine.UI;

public class CarDisplay : MonoBehaviour
{
    [Header("Car Description")]
    [SerializeField] private Text carName;
    [SerializeField] private Text carDescription;
    [SerializeField] private Text carPrice;

    [Header("Car Stats")]
    [SerializeField] private Image carSpeed;
    [SerializeField] private Image carAcceleration;
    [SerializeField] private Image carHandling;

    [Header("Car Model")]
    [SerializeField] private Transform carHolder;

    public void DisplayCar(Car _car)
    {
        carName.text = _car.carName;
        carDescription.text = _car.carDescription;
        carPrice.text = _car.carPrice + "$";

        carSpeed.fillAmount = _car.speed / 100;
        carHandling.fillAmount = _car.handling / 100;
        carAcceleration.fillAmount = _car.acceleration / 100;

        if (carHolder.childCount > 0)
            Destroy(carHolder.GetChild(0).gameObject);

        Instantiate(_car.carModel, carHolder.position, carHolder.rotation, carHolder);
    }
}