using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusChanger : MonoBehaviour
{

    private float firsty;
    [SerializeField]
    private RectTransform rectTransform;
    [SerializeField]
    private int buttonCount;
    [SerializeField]
    private float yDistance;
    public int focus;

    void Start()
    {
        firsty = rectTransform.anchoredPosition.y; 
        UpdatePosition();
    }

    void UpdatePosition(){
        Vector2 pos = rectTransform.anchoredPosition;
        pos.y = firsty - yDistance * focus;
        rectTransform.anchoredPosition = pos;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            focus -= 1;

        if (Input.GetKeyDown(KeyCode.DownArrow))
            focus += 1;

        focus = (focus + buttonCount) % buttonCount;
        UpdatePosition();
    }
}
