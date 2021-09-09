using UnityEngine;
using UnityEngine.UI;

public class GunDisplay : MonoBehaviour
{
    [Header ("Gun Name")]
    [SerializeField] private Text gunName;

    [Header("Gun Stats")]
    [SerializeField] private Transform damageStars;
    [SerializeField] private Transform accuracyStars;
    [SerializeField] private Transform rangeStars;
    [SerializeField] private Transform fireRateStars;

    [Header("Gun Holder")]
    [SerializeField] private Transform gunHolder;

    public void DisplayGun(Gun _gun)
    {
        gunName.text = _gun.gunName;

        //Damage
        for (int i = 0; i < damageStars.childCount; i++)
            damageStars.GetChild(i).gameObject.SetActive(i < _gun.damage);

        //Accuracy
        for (int i = 0; i < accuracyStars.childCount; i++)
            accuracyStars.GetChild(i).gameObject.SetActive(i < _gun.accuracy);

        //Range
        for (int i = 0; i < rangeStars.childCount; i++)
            rangeStars.GetChild(i).gameObject.SetActive(i < _gun.range);

        //Fire Rate
        for (int i = 0; i < fireRateStars.childCount; i++)
            fireRateStars.GetChild(i).gameObject.SetActive(i < _gun.fireRate);

        if (gunHolder.childCount > 0)
            Destroy(gunHolder.GetChild(0).gameObject);

        Instantiate(_gun.gunModel, gunHolder.position, gunHolder.rotation, gunHolder);
    }
}