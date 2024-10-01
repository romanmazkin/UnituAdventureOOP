using UnityEngine;

public class HealAbility : MonoBehaviour
{
    [SerializeField] private float _healValue = 10f;

    public void Heal(GameObject owner)
    {
        Health health = owner.GetComponent<Health>();

        health.CurrentHealth += _healValue;

        Debug.Log("Health equals: " + health.CurrentHealth);
    }
}
