using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

// using Cursor = UnityEngine.UIElements.Cursor;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator Test = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;
    [SerializeField] GameObject UI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                // gameObject.SetActive(false);
                UI.SetActive(true);
                
                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = true;

                Debug.Log("Opening: Question UI");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // gameObject.SetActive(true);
            UI.SetActive(false);

            Cursor.visible = false;
            
            Debug.Log("Closing: Question UI");
        }
    }
}
