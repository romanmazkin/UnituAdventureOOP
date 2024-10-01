using UnityEngine;

public class Inventory : MonoBehaviour
{
    private Item _item;

    [SerializeField] private Transform _itemHolderPoint;

    public Inventory(Transform itemHolderPoint)
    {
        _itemHolderPoint = itemHolderPoint;
    }

    public bool HasItem() => _item != null;

    public Item GetItem()
    {

        if (HasItem() == false)
        {
            Debug.LogError("У персонажа нет предмета");
            return null;
        }

        _item.transform.SetParent(null);
        Item selectedItem = _item;
        _item = null;
        return selectedItem;
    }

    public void PutItem(Item item)
    {
        if (HasItem() == true)
        {
            Debug.LogError("У персонажа уже есть предмет");
        }

        _item = item;
        _item.transform.SetParent(_itemHolderPoint);
        _item.transform.localPosition = Vector3.zero;
    }
}
