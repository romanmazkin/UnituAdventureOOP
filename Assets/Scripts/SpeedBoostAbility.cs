using UnityEngine;

public class SpeedBoostAbility : MonoBehaviour
{
    [SerializeField] private float _boostValue = 2f;

    public void Boost(GameObject owner)
    {
        Mover mover = owner.GetComponent<Mover>();

        mover.Speed += _boostValue;

        Debug.Log("Speed equals: " + mover.Speed);
    }
}
