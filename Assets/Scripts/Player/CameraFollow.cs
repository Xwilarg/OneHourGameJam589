using UnityEngine;

namespace OneHourGameJam589.Player
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField]
        private Transform _follow;

        private void Update()
        {
            transform.position = new Vector3(_follow.position.x, _follow.position.y, transform.position.z);
        }
    }
}
