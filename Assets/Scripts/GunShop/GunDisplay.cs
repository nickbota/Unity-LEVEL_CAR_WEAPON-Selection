using UnityEngine;
using UnityEngine.UI;

public class GunDisplay : MonoBehaviour
{
    [Header("Description")]
    [SerializeField] private Text gunName;

    [Header("Stats")]
    [SerializeField] private Transform damageStars;
    [SerializeField] private Transform accuracyStars;
    [SerializeField] private Transform rangeStars;
    [SerializeField] private Transform fireRateStars;

    [Header("Car Model")]
    [SerializeField] private GameObject gunModel;

    public void UpdateGun(Gun _newGun)
    {
        gunName.text = _newGun.gunName;

        for (int i = 0; i < damageStars.childCount; i++)
            damageStars.GetChild(i).gameObject.SetActive(i < _newGun.damage);

        for (int i = 0; i < accuracyStars.childCount; i++)
            accuracyStars.GetChild(i).gameObject.SetActive(i < _newGun.accuracy);

        for (int i = 0; i < rangeStars.childCount; i++)
            rangeStars.GetChild(i).gameObject.SetActive(i < _newGun.range);

        for (int i = 0; i < fireRateStars.childCount; i++)
            fireRateStars.GetChild(i).gameObject.SetActive(i < _newGun.fireRate);

        if (gunModel.transform.childCount > 0)
            Destroy(gunModel.transform.GetChild(0).gameObject);
        Instantiate(_newGun.gunModel, gunModel.transform.position, gunModel.transform.rotation, gunModel.transform);
    }
}