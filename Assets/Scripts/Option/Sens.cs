using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Option
{
    public class Sens : MonoBehaviour
    {

        public static int sensitivity;
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
        private int accelerationFrame;
        [SerializeField]
        private float firstX;
        
        private int rightFrame = 0;
        private int leftFrame = 0;
        void Start()
        {
            if(PlayerPrefs.HasKey("感度"))
                sensitivity = PlayerPrefs.GetInt("感度");
            else
                sensitivity = initialValue;
            Vector2 pos = transform.position;
            pos.x = firstX + (sensitivity - lowerLimit) * distance;
            transform.position = pos;
        }

        void Update()
        {
            int countb = focusChanger.focus;
            Vector2 pos = transform.position;
            if (countb == 1)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    if (sensitivity < upperLimit)
                    {
                        sensitivity += 1;
                        pos.x += distance;
                    }
                }

                if (Input.GetKey(KeyCode.RightArrow))
                {
                    rightFrame++;
                    if(rightFrame > accelerationFrame)
                    {
                        if (sensitivity < upperLimit)
                        {
                            sensitivity += 1;
                            pos.x += distance;
                        }
                    }
                }
                else{
                    rightFrame = 0;
                }
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    if (sensitivity > lowerLimit)
                    {
                        sensitivity -= 1;
                        pos.x -= distance;
                    }
                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    leftFrame++;
                    if(leftFrame > accelerationFrame)
                    {
                        if (sensitivity > lowerLimit)
                        {
                            sensitivity -= 1;
                            pos.x -= distance;
                        }
                    }
                }
                else{
                    leftFrame = 0;
                }
            }
            transform.position = pos;
        }

        public static int getSensitivity()
        {
            return sensitivity;
        }
    }
}