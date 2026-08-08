using UnityEngine;
using UnityEngine.InputSystem;

namespace OneHourGameJam589.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField]
        private float _speed;

        private float _movX;
        private Rigidbody _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            _rb.linearVelocity = new Vector3(_movX * _speed, _rb.linearVelocity.y, 0f);
        }

        public void OnMovement(InputAction.CallbackContext value)
        {
            _movX = value.ReadValue<Vector2>().x;
            if (_movX > .5) _movX = 1;
            else if (_movX < -.5f) _movX = -1;
            else _movX = 0;
        }
    }
}
