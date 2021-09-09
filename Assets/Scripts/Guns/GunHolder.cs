using UnityEngine;

public class GunHolder : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x,
            transform.eulerAngles.y + Time.deltaTime * speed, transform.eulerAngles.z);
    }
}