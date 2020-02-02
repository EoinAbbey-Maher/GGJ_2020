using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour
{
    public Text clue;
    private int mode;

    void Start()
    {
        clue = GetComponent<Text>();
    }

    void Update()
    {
        mode = ButtonPuzzle.display;
        clue.text = mode.ToString();
    }
}

