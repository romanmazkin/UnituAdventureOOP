using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _startSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private Animator _animator;

    public float Speed { get; set; }

    private const string HorizontalAxisName = "Horizontal";
    private const string VerticalAxisName = "Vertical";
    private CharacterController _characterController;
    private float _deadZone = 0.1f;
    private Vector3 _noInput = new Vector3(0, 0, 0);

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();

        Speed = _startSpeed;
    }

    private void Update()
    {

        _animator.SetBool("IsRunning", false);

        Vector3 input = new Vector3(Input.GetAxisRaw(HorizontalAxisName), 0, Input.GetAxisRaw(VerticalAxisName));

        if (input.x != _noInput.x || input.z != _noInput.z)
        {
            _animator.SetBool("IsRunning", true);
            _characterController.Move(input.normalized * Speed * Time.deltaTime);
        }

        if (input.magnitude <= _deadZone)
            return;

        Quaternion lookRotation = Quaternion.LookRotation(input.normalized);
        float step = _rotationSpeed * Time.deltaTime;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, step);
    }
}
