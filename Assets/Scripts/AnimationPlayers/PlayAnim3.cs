using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnim3 : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private string doorOpen = "DoorAnim3";
    private bool Triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && Triggered == false)
        {
            myDoor.Play(doorOpen, 0, 0.0f);
            Triggered = true;
        }
    }
}
