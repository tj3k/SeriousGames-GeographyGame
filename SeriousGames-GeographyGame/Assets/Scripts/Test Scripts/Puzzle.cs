using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public GameObject UI;
    public GameObject interactionBlock;
    public Animator door;

    // On Correct Answer
    public void CorrectAnswer()
    {
        Debug.Log("Answer: Correct");
        
        //Plays "DoorOpen.anim" animation
        door.SetBool("answer", true);
        
        /* Makes UI invisible atm.
         Note: We could instead have this show a "Correct" screen instead...
         ...which would disable itself after a couple of seconds via coroutine.
        */
        UI.SetActive(false);
        
        // Disables cursor
        Cursor.visible = false;
        Destroy(interactionBlock);
    }
    
    public void WrongAnswer()
    {
        // Keeps UI visible
        UI.SetActive(true);
        
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        Debug.Log("Answer: Incorrect");
    }
    
    // Function purely for closing UI and not destroying interact object.
    // Made for Book Rooms
    public void CloseUI()
    {
        Debug.Log("Closing: Book UI");
        
        UI.SetActive(false);
        
        // Disables cursor
        Cursor.visible = false;
    }
}
