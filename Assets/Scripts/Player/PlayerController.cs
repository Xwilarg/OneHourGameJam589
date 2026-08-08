using UnityEngine;
using UnityEngine.InputSystem;

namespace OneHourGameJam589.Player
{
    public class PlayerController : MonoBehaviour
    {
        private float _movX;

        public void OnMovement(InputAction.CallbackContext value)
        {
            _movX = value.ReadValue<Vector2>().x;
            if (_movX > .5) _movX = 1;
            else if (_movX < -.5f) _movX = -1;
            else _movX = 0;
        }
    }
}
