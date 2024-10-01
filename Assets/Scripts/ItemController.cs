using UnityEngine;

public class ItemController
{
    private Inventory _inventory;
    private GameObject _owner;

    public ItemController(Inventory inventory, GameObject owner)
    {
        _inventory = inventory;
        _owner = owner;
    }

    public bool CanUseItem() => _inventory.HasItem();

    public void UseItem()
    {
        if (CanUseItem()==false)
        {
            Debug.LogError("Персонаж не может использовать предмет");
            return;
        }

        Item item = _inventory.GetItem();
        item.Use(_owner);
        Object.Destroy(item.gameObject);
    }
}
