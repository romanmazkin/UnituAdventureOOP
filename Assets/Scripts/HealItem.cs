using UnityEngine;

public class HealItem : Item
{
    public override bool CanPickupFor(GameObject owner)
    {
        return base.CanPickupFor(owner);
    }

    public override void Use(GameObject owner)
    {
        base.Use(owner);

        HealAbility healAbility = gameObject.GetComponent<HealAbility>();

        healAbility.Heal(owner);
    }
}
