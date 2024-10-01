using UnityEngine;

public class ShootAbility : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab;

    public void Shoot(GameObject owner)
    {
        Transform shootPoint = owner.GetComponentInChildren<ShootPoint>().transform;

        Bullet bullet = Instantiate(_bulletPrefab, shootPoint.position, Quaternion.identity, null);

        bullet.Launch(shootPoint.forward);
    }
}
