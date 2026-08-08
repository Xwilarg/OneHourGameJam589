using UnityEngine;
using UnityEngine.InputSystem;

namespace OneHourGameJam589.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField]
        private float _speed;

        [SerializeField]
        private Transform _rot;

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
            if (_movX > .5)
            {
                _movX = 1;
                //_rot.rotation = Quaternion.Euler(0f, 0f, 180f);
            }
            else if (_movX < -.5f)
            {
                _movX = -1;
                //_rot.rotation = Quaternion.Euler(0f, 0f, 180f);
            }
            else _movX = 0;
        }

        public void OnDig(InputAction.CallbackContext value)
        {
            if (value.phase == InputActionPhase.Started)
            {
                if (Physics.Raycast(transform.position, Vector3.down, out var info, 1.1f, LayerMask.GetMask("Map")))
                {
                    if (info.collider.TryGetComponent<Block>(out var block)) block.Click();
                }
            }
        }
    }
}
