using UnityEngine;

public class HealingItem : Item
{
    public override bool CanPickupFor(GameObject owner)
    {
        return base.CanPickupFor(owner);
    }

    public override void Use(GameObject owner)
    {
        base.Use(owner);

        ShootAbility shootAbility = gameObject.GetComponent<ShootAbility>();

        shootAbility.Shoot(owner);
    }
}
