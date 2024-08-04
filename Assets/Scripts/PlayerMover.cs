using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    private const float _SpeedCoefficient = 50;
    
    [SerializeField] private float _speedX = 1;

    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(_speedX * _SpeedCoefficient * Time.fixedDeltaTime, _rigidbody2D.velocity.y);
    }

}