using UnityEngine;

public class SpeedBoostItem : Item
{
    public override bool CanPickupFor(GameObject owner)
    {
        return base.CanPickupFor(owner);
    }

    public override void Use(GameObject owner)
    {
        base.Use(owner);

        SpeedBoostAbility speedBoostAbility = gameObject.GetComponent<SpeedBoostAbility>();

        speedBoostAbility.Boost(owner);
    }
}
