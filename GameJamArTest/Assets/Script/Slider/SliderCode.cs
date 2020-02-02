using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class SliderCode : MonoBehaviour
{

    public float SliderValue;

    public Slider[] currentSlider;

    private const int TOTAL_SLIDERS = 5;
    public Slider[] slider;
    public bool[] isTop;
    int counter;

    void Start()
    {
        isTop = new bool[TOTAL_SLIDERS];
        currentSlider = new Slider[TOTAL_SLIDERS];
        for(int i = 0; i < TOTAL_SLIDERS; i++)
        {
            currentSlider[i] = this.gameObject.GetComponent<Slider>();
            isTop[i] = false;
        }
        counter = 0;
        SliderValue = this.gameObject.GetComponent<Slider>().value;
    }

    // Update is called once per frame
    void Update()
    {
        SliderValue = this.gameObject.GetComponent<Slider>().value;

        for(int  i = 0; i < TOTAL_SLIDERS; i++)
        {

            if(counter == 0)
            {
                if (currentSlider[0].GetComponent<SliderCode>().isTop[0])
                {
                    counter++;
                }
            }

            if(counter == 1)
            {
                if (currentSlider[3].GetComponent<SliderCode>().isTop[3])
                {
                    counter++;
                }
            }

            if(counter == 2)
            {
                if (currentSlider[2].GetComponent<SliderCode>().isTop[2])
                {
                    counter++;
                }
            }

            if(counter == 3)
            {
                if (currentSlider[4].GetComponent<SliderCode>().isTop[4])
                {
                    counter++;
                }
            }
        }
    }
}
