using UnityEngine;
using UnityEngine.UI;

namespace Option
{
    public class TextChanger : MonoBehaviour
    {
        [SerializeField]
        Text timeText;

        [SerializeField]
        Text sensitivityText;

        public int time;
        public int sensitivity;

        void Update()
        {
            int time = Time.getTime();
            timeText.text = time.ToString() + "分";
            int sensitivity = Sens.getSensitivity();
            sensitivityText.text = sensitivity.ToString();
        }
    }
}