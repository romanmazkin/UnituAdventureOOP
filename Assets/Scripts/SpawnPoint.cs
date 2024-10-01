using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private Item _pickup;

    public bool IsEmpty
    {
        get 
        { 
            if (_pickup == null)
                return true;

            if(_pickup.gameObject == null)
                return true;

            return false;
        }
    }

    public Vector3 Position => transform.position;

    public void Occypy(Item pickup)
    {
        _pickup = pickup;
    }
}
