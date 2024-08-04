using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class PlayerMover1 : MonoBehaviour
{
    [SerializeField] private float _speedX = 5f;
    [SerializeField] private float _speedY = 10f;
    [SerializeField] private GameObject _ground;

    private Rigidbody2D _rigidbody2D;
    private CircleCollider2D _circleCollider2D;
    private bool _isJumped;
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _circleCollider2D = GetComponent<CircleCollider2D>();

        //_rigidbody2D.velocity = new Vector2(_speedX, _speedY);
    }

    private void OnCollisionStay2D(Collision2D _ground)
    {
        _isJumped = false;
    }

    private void OnCollisionExit2D(Collision2D _ground)
    {
        _isJumped = true;
    }

    private void FixedUpdate()
    {
        if (!_isJumped && Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, _speedY);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody2D.velocity = new Vector2(-_speedX, _rigidbody2D.velocity.y);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody2D.velocity = new Vector2(_speedX, _rigidbody2D.velocity.y);
        }
    }

}