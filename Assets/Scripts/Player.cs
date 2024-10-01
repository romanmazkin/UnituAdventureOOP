using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform _itemHolderPoint;
    [SerializeField] private ItemCollector _itemCollector;
    [SerializeField] private Transform _shootPoint;
    private ItemController _itemController;

    public Transform ShootPoint => _shootPoint; 

    private void Awake()
    {
        Inventory inventory = new Inventory(_itemHolderPoint);

        _itemCollector.Initialize(inventory);
        _itemController = new ItemController(inventory, gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (_itemController.CanUseItem())
            {
                _itemController.UseItem();
            }
            else
            {
                Debug.Log("Nothing to use!");
            }
        }
    }
}
