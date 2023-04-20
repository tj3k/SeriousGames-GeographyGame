using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public GameObject UI;
    public Animator door;

    // On Correct Answer
    public void correctAnswer()
    {
        //Plays "DoorOpen.anim" animation
        // door.Play("DoorOpen", 0, 0.0f);
        door.SetBool("Unlocked", true);
        
        /* Makes UI invisible atm.
         Note: We could instead have this show a "Correct" screen instead...
         ...which would disable itself after a couple of seconds via coroutine.
        */
        UI.SetActive(false);
        
        // Disables cursor
        Cursor.visible = false;
        Debug.Log("Answer: Correct");
    }

    public void wrongAnswer()
    {
        // Keeps UI visible
        UI.SetActive(true);
        
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        Debug.Log("Answer: Incorrect");
    }
}
