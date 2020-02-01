using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour
{
    public Text clue;
    private int mode;
    // Start is called before the first frame update
    void Start()
    {
        clue = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        mode = NewBehaviourScript.display;
        clue.text = mode.ToString();
    }
}

