using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public GameObject UI;
    public Animator door;

    public void correctAnswer()
    {
        door.Play("Test", 0, 0.0f);
        UI.SetActive(true);
    }

    public void wrongAnswer()
    {
        UI.SetActive(false);
    }
}
