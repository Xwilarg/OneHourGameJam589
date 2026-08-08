using UnityEngine;

namespace OneHourGameJam589.Manager
{
    public class MapManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject _blockPrefab, _rockPrefab;

        private const int Size = 10;

        private void Awake()
        {
            for (int y = -1; y > -Size; y-=2)
            {
                for (int i = -Size; i <= Size; i += 2)
                {
                    Instantiate(Mathf.Abs(i) == Size || Random.Range(0, 10) == 0 ? _rockPrefab : _blockPrefab, new Vector3(i, y, 0f), _blockPrefab.transform.rotation);
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
