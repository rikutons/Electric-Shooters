using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Option
{
    public class Time : MonoBehaviour
    {

        public static int time;
        [SerializeField]
        private int initialValue;
        [SerializeField]
        private int upperLimit;
        [SerializeField]
        private int lowerLimit;
        [SerializeField]
        private FocusChanger focusChanger;
        [SerializeField]
        private float distance;
        [SerializeField]
        private float firstX;

        void Start()
        {
            if(PlayerPrefs.HasKey("制限時間"))
                time = PlayerPrefs.GetInt("制限時間");
            else
                time = initialValue;
            Vector2 pos = transform.position;
            pos.x = firstX + (time - lowerLimit) * distance;
            transform.position = pos;
        }

        void Update()
        {
            Vector2 pos = transform.position;
            int focus = focusChanger.focus;
            if (focus == 0)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    if (time < upperLimit)
                    {
                        time += 1;
                        pos.x += distance;
                    }
                }

                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    if (time > lowerLimit)
                    {
                        time -= 1;
                        pos.x -= distance;
                    }
                }
            }
            transform.position = pos;
        }

        public static int getTime()
        {
            return time;
        }
    }
}