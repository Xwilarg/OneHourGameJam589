using UnityEngine;

namespace OneHourGameJam589.Manager
{
    public class MapManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject _blockPrefab, _rockPrefab, _grassPrefab;

        private const int Size = 10;

        private void Awake()
        {
            for (int y = -1; y > -20; y-=2)
            {
                for (int i = -Size; i <= Size; i += 2)
                {
                    if (Mathf.Abs(i) == Size || Random.Range(0, 10) == 0)
                    {
                        Instantiate(_rockPrefab, new Vector3(i, y, 0f), _blockPrefab.transform.rotation);
                    }
                    else if (y == -1)
                    {
                        Instantiate(_grassPrefab, new Vector3(i, y, 0f), _blockPrefab.transform.rotation);
                    }
                    else
                    {
                        Instantiate(_blockPrefab, new Vector3(i, y, 0f), _blockPrefab.transform.rotation);
                    }
                }
            }
            for (int y = 5; y > -1; y-=2)
            {
                Instantiate(_rockPrefab, new Vector3(-Size, y, 0f), _blockPrefab.transform.rotation);
                Instantiate(_rockPrefab, new Vector3(Size, y, 0f), _blockPrefab.transform.rotation);
            }
        }
    }
}
