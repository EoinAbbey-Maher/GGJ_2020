using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle : MonoBehaviour
{
    public Slider[] sliders;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkForPattern()
    {
        for (int i = 0; i < 5; i++)
        {
            if (sliders[i].GetComponent<SliderCode>().SliderValue >= 0.95)
            {
                sliders[i].GetComponent<SliderCode>().isTop[i] = true;
            }
        }
    }
}
