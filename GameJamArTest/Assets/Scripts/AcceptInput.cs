using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcceptInput : MonoBehaviour
{
    public InputField mainInputField;
    private string password;
    private bool shake = false;
    private float counter = 0.0f;
    private int answer;
    private const int MAX_CLUES = 4;
    public Text[] clues;
    private string[] cryptic = {"green", "fly", "pineapple", "skin"};
    // Start is called before the first frame update
    void Start()
    {
        answer = Random.Range(0, 4);
        switch(answer)
        {
            case 0:
                password = "mood";
                break;
            case 1:
                password = "same";
                break;
            case 2:
                password = "huge";
                break;
            case 3:
                password = "jesus";
                break;
        }
        for(int i = 0; i < MAX_CLUES; i++)
        {
            if(answer >= MAX_CLUES)
            {
                answer -= MAX_CLUES;
            }
            clues[answer].text = cryptic[i];

            answer++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(shake)
        {
            Shake();
        }
    }
    

    public void LockInput(InputField input)
    {
        string temp = input.text;
        temp = temp.ToLower();
        input.text = "";
        if (temp.Length > 0)
        {
            if(temp == password)
            {
                Victory();
            }
            else
            {
                shake = true;
                counter = 0;
            }
        }
    }

    private void Victory()
    {
        Debug.Log("Victory");
    }

    private void Shake()
    {
        if (counter <= 0)
        {
            var color = mainInputField.colors;
            color.normalColor = Color.red;
            color.highlightedColor = Color.red;
            mainInputField.colors = color;
        }
        else if (counter >= 0.5)
        {
            var color = mainInputField.colors;
            color.normalColor = Color.white;
            color.highlightedColor = Color.white;
            mainInputField.colors = color;
            shake = false;
        }
        counter += 1.0f / 60.0f;
    }
}
