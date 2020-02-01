using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    private const int TOTAL_BUTTONS = 6;
    public Button[] buttons;
    private int counter = 0;
    private bool correct = true;
    private int mode;
    public static int display;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        mode = Random.Range(1, 4);
        display = mode;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void HandleClicks(int t_num)
    {
        bool deactivated = false;
        switch (t_num)
        {
            case 1:
                ProcessModes(t_num);
                if (counter >= 5)
                {
                    deactivated = true;
                    counter = 0;
                }
                else
                {
                    counter++;
                }
                break;
            case 2:
                ProcessModes(t_num);
                if (counter > 4)
                {
                    deactivated = true;
                    counter = 0;
                }
                else
                {
                    counter++;
                }
                break;
            case 3:
                ProcessModes(t_num);
                if (counter > 4)
                {
                    deactivated = true;
                    counter = 0;
                }
                else
                {
                    counter++;
                }
                break;
            case 4:
                ProcessModes(t_num);
                if (counter > 4)
                {
                    deactivated = true;
                    counter = 0;
                }
                else
                {
                    counter++;
                }
                break;
            case 5:
                ProcessModes(t_num);
                if (counter > 4)
                {
                    deactivated = true;
                    counter = 0;
                }
                else
                {
                    counter++;
                }
                break;
            case 6:
                ProcessModes(t_num);
                if (counter > 4)
                {
                    deactivated = true;
                    counter = 0;
                }
                else
                {
                    counter++;
                }
                break;
        }
        buttons[t_num - 1].interactable = false;
        if (deactivated == true)
        {
            for (int i = 0; i < TOTAL_BUTTONS; i++)
            {
                buttons[i].interactable = true;
            }
            correct = true;
        }
    }
    public void Victory()
    {
        Debug.Log("victory");
    }
    public void ProcessModes(int t_num)
    {
        switch (mode)
        {
            case 1:
            switch (t_num)
            {
                case 1:
                    if(counter != 4)
                    {
                        correct = false;
                    }
                    break;
                case 2:
                    if (counter != 1)
                    {
                        correct = false;
                    }
                    break;
                case 3:
                    if (counter != 0)
                    {
                        correct = false;
                    }
                    break;
                case 4:
                    if (counter == 5 && correct)
                    {
                        Victory();
                    }
                    break;
                case 5:
                    if (counter != 2)
                    {
                        correct = false;
                    }
                    break;
                case 6:
                    if (counter != 3)
                    {
                        correct = false;
                    }
                    break;
            }
                break;
            case 2:
                switch (t_num)
                {
                    case 1:
                        if (counter != 3)
                        {
                            correct = false;
                        }
                        break;
                    case 2:
                        if (counter != 4)
                        {
                            correct = false;
                        }
                        break;
                    case 3:
                        if (counter == 5 && correct)
                        {
                            Victory();
                        }
                        break;
                    case 4:
                        if (counter != 1)
                        {
                            correct = false;
                        }
                        break;
                    case 5:
                        if (counter != 0)
                        {
                            correct = false;
                        }
                        break;
                    case 6:
                        if (counter != 2)
                        {
                            correct = false;
                        }
                        break;
                }
                break;
            case 3:
                switch (t_num)
                {
                    case 1:
                        if (counter != 0)
                        {
                            correct = false;
                        }
                        break;
                    case 2:
                        if (counter != 1)
                        {
                            correct = false;
                        }
                        break;
                    case 3:
                        if (counter != 3)
                        {
                            correct = false;
                        }
                        break;
                    case 4:
                        if (counter != 4)
                        {
                            correct = false;
                        }
                        break;
                    case 5:
                        if (counter == 5 && correct)
                        {
                            Victory();
                        }
                        break;
                    case 6:
                        if (counter != 2)
                        {
                            correct = false;
                        }
                        break;
                }
                break;
            default:
                break;
        }
    }

    public void xAxis(int angle)
    {
        gameObject.transform.Rotate(angle, 0, 0);
    }

    public void yAxis(int angle)
    {
        gameObject.transform.Rotate(0, angle, 0);
    }

    public void zAxis(int angle)
    {
        gameObject.transform.Rotate(0, 0, angle);
    }
}
