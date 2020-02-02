using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleScript : MonoBehaviour
{
    public GameObject cubeSelectScreen;
    public GameObject[] puzzles;
    public GameObject[] colliderObjects;

    private bool[] puzzleSolved;
    private bool[] puzzlesActive;
    private bool cubeOverlayActive;
    private bool victory;


    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            puzzleSolved[i] = false;
            puzzlesActive[i] = false;
            cubeOverlayActive = true;
            victory = false;
        }
    }

    void Update()
    {
        if (!victory)
        {
            for (int i = 0; i < 6; i++)
            {
                if (!puzzleSolved[i])
                {
                    break;
                }
                else if (i == 5)
                {
                    //change to victory screen here
                    victory = true;
                }
            }
        }

        checkCollisions();
    }

    void checkCollisions()
    {
        if (!victory)
        {
            for (int i = 0; i < 6; i++)
            {
                if (puzzlesActive[i])
                {
                    return;
                }
            }
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.CompareTag("Top"))
                    {
                        if(!puzzleSolved[0])
                        {
                            puzzlesActive[0] = true;
                            cubeSelectScreen.SetActive(false);
                            Instantiate(puzzles[0]);
                        }
                    }
                    else if (hit.collider.CompareTag("Bottom"))
                    {
                        if (!puzzleSolved[1])
                        {
                            puzzlesActive[1] = true;
                            cubeSelectScreen.SetActive(false);
                            Instantiate(puzzles[1]);
                        }
                    }
                    else if (hit.collider.CompareTag("Left"))
                    {
                        if (!puzzleSolved[2])
                        {
                            puzzlesActive[2] = true;
                            cubeSelectScreen.SetActive(false);
                            Instantiate(puzzles[2]);
                        }
                    }
                    else if (hit.collider.CompareTag("Right"))
                    {
                        if (!puzzleSolved[3])
                        {
                            puzzlesActive[3] = true;
                            cubeSelectScreen.SetActive(false);
                            Instantiate(puzzles[3]);
                        }
                    }
                    else if (hit.collider.CompareTag("Front"))
                    {
                        if (!puzzleSolved[4])
                        {
                            puzzlesActive[4] = true;
                            cubeSelectScreen.SetActive(false);
                            Instantiate(puzzles[4]);
                        }
                    }
                    else if (hit.collider.CompareTag("Back"))
                    {
                        if (!puzzleSolved[5])
                        {
                            puzzlesActive[5] = true;
                            cubeSelectScreen.SetActive(false);
                            Instantiate(puzzles[5]);
                        }
                    }
                }
            }
        }
    }

}
