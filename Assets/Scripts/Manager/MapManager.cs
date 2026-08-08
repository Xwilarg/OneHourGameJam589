using UnityEngine;

namespace OneHourGameJam589.Manager
{
    public class MapManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject _blockPrefab;

        private const int Size = 10;

        private void Awake()
        {
            for (int y = -1; y > -Size; y--)
            {
                for (int i = -Size; i <= Size; i++)
                {
                    Instantiate(_blockPrefab, new Vector3(i, y, 0f), Quaternion.identity);
                }
            }
            for (int y = 5; y > -1; y--)
            {
                Instantiate(_blockPrefab, new Vector3(-Size, y, 0f), Quaternion.identity);
                Instantiate(_blockPrefab, new Vector3(Size, y, 0f), Quaternion.identity);
            }
        }
    }
}
