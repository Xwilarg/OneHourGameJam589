using TMPro;
using UnityEngine;

namespace OneHourGameJam589.Player
{
    public class Block : MonoBehaviour
    {
        private TMP_Text _text;

        private int _count = 10;

        private void Awake()
        {
            _text = GetComponentInChildren<TMP_Text>();
        }

        public void Click()
        {
            _count--;
            if (_count == 0) Destroy(gameObject);
            else _text.text = _count.ToString();
        }
    }
}
