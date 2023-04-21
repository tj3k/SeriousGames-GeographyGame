using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator Test = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;
    [SerializeField] GameObject UI;

    /* When player walks onto the green area,
     * A relative UI Window will pop-up,
     * whether it's a QuestionWall or Book Panel assigned to the code. 
     */
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                UI.SetActive(true);
                
                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = true;

                Debug.Log("Opening: Question UI");
            }
        }
    }

    // When the player walks outside the green area, the UI Windows turns invisible.
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UI.SetActive(false);

            Cursor.visible = false;
            
            Debug.Log("Closing: Question UI");
        }
    }
}
