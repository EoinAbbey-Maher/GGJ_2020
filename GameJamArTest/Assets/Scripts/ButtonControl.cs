using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ButtonControl : MonoBehaviour
{
    public float counter = 0.0f;
    private bool isPressed;
    private int color;
    private int timeLimit;

    // Start is called before the first frame update
    void Start()
    {
        color = Random.Range(1,7);
        switch(color)
        {
            case 1:
                var color = GetComponent<Button>().colors;
                color.normalColor = Color.red;
                GetComponent<Button>().colors = color;
                timeLimit = 5;
                break;
            case 2:
                var color1 = GetComponent<Button>().colors;
                color1.normalColor = Color.blue;
                GetComponent<Button>().colors = color1;
                timeLimit = 3;
                break;
            case 3:
                var color2 = GetComponent<Button>().colors;
                color2.normalColor = Color.yellow;
                GetComponent<Button>().colors = color2;
                timeLimit = 8;
                break;
            case 4:
                var color3 = GetComponent<Button>().colors;
                color3.normalColor = Color.green;
                GetComponent<Button>().colors = color3;
                timeLimit = 2;
                break;
            case 5:
                var color4 = GetComponent<Button>().colors;
                color4.normalColor = Color.magenta;
                GetComponent<Button>().colors = color4;
                timeLimit = 6;
                break;
            case 6:
                var color5 = GetComponent<Button>().colors;
                color5.normalColor = Color.cyan;
                GetComponent<Button>().colors = color5;
                timeLimit = 4;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isPressed = true;
        }
        else if (Input.GetMouseButton(0))
        {
            counter = counter + (1.0f / 60.0f);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isPressed = false;
        }
        if (!isPressed)
        {
            if (counter > timeLimit && counter < (timeLimit + 1))
            {
                Victory();
            }
            counter = 0;
        }
    }

    void Victory()
    {
        Debug.Log("works");
    }
}
