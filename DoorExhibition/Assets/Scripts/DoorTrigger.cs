using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using TMPro;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    private Animator anim;

    [SerializeField]
    private AudioSource s_rattlingDoor;

    [SerializeField]
    private AudioSource s_squeakingDoor;

    [SerializeField]
    private GameObject t_openDoorText;

    private bool opened = false;
    private bool triedOpen = false;

    private void OnTriggerStay(Collider other)
    {
        FirstPersonController player = other.GetComponent<FirstPersonController>();

        if(player && !opened)
        {
            t_openDoorText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E) && !opened)
            {
                s_rattlingDoor.Play();
                anim.Play("a_doorRattle");
                triedOpen = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        FirstPersonController player = other.GetComponent<FirstPersonController>();

        if (player)
        {
            t_openDoorText.SetActive(false);

            if (!opened && triedOpen)
            {
                opened = true;
                s_squeakingDoor.Play();
                anim.Play("a_doorOpen");
            }
        }
    }
}
