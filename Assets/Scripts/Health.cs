using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _healthValue = 100f;

    public float CurrentHealth { get; set; }

    private void Awake()
    {
        CurrentHealth = _healthValue;
    }
}
