using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    private Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController player = other.GetComponent<FirstPersonController>();

        if(player)
        {
            anim.Play("openDoor");
        }
    }
}
