using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    private const float _SpeedCoefficient = 200;
    
    [SerializeField] private float _speedX = 1;

    private Rigidbody2D _rigidbody2D;
    private float _direction;
    private string _horizontal = "Horizontal";

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _direction = Input.GetAxis(_horizontal);
        Debug.Log(_direction);
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(_speedX * _direction * _SpeedCoefficient * Time.fixedDeltaTime, _rigidbody2D.velocity.y);
    }

}