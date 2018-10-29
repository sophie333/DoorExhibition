using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class RespawnTrigger : MonoBehaviour {

    [SerializeField]
    private Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController player = other.GetComponent<FirstPersonController>();

        if (player)
        {
            player.GetComponent<Rigidbody>().isKinematic = true;
            player.transform.position = new Vector3(2.7f, 2.3f, -2.7f);
            anim.Play("closeDoor");
        }
    }
}
