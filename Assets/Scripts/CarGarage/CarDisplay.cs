using UnityEngine;
using UnityEngine.UI;

public class CarDisplay : MonoBehaviour
{
    [Header("Description")]
    [SerializeField] private Text carName;
    [SerializeField] private Text carDescription;
    [SerializeField] private Text carPrice;

    [Header("Stats")]
    [SerializeField] private Image speed;
    [SerializeField] private Image acceleration;
    [SerializeField] private Image handling;

    [Header("Car Model")]
    [SerializeField] private GameObject carModel;

    public void UpdateCar(Car _newCar)
    {
        carName.text = _newCar.carName;
        carDescription.text = _newCar.carDescription;
        carPrice.text = _newCar.carPrice + "$";

        speed.fillAmount = (float)_newCar.speed / 100;
        handling.fillAmount = (float)_newCar.handling / 100;
        acceleration.fillAmount = (float)_newCar.acceleration / 100;

        if (carModel.transform.childCount > 0)
            Destroy(carModel.transform.GetChild(0).gameObject);
        Instantiate(_newCar.carModel, carModel.transform.position, carModel.transform.rotation, carModel.transform);
    }
}