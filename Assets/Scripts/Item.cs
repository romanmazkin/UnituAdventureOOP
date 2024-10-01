using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] private ParticleSystem _useEffectPrefab;

    public virtual bool CanPickupFor(GameObject owner)
    {
        return owner.GetComponentInChildren<ItemHolderSlot>().transform != null;
    }

    public virtual void Use(GameObject owner)
    {
        Instantiate(_useEffectPrefab, owner.transform.position, Quaternion.identity, null);
    }
}
