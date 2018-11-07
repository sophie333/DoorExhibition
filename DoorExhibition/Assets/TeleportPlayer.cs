using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class TeleportPlayer : MonoBehaviour {
    /*
    [SerializeField]
    private Image panel;

    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController player = other.GetComponent<FirstPersonController>();

        if (player)
        {
            panel.CrossFadeAlpha(255.0f, 3.0f, false);
            yield return WaitWhile(panel.canvasRenderer.GetAlpha() != 255.0f);
            //StartCoroutine(AlphaFade(255.0f));
            /*
            player.GetComponent<FirstPersonController>().enabled = false;
            player.transform.position = new Vector3(-1.2f, 0.8f, 0.0f);
            player.transform.eulerAngles = new Vector3(0.0f, 180.0f, 0.0f);*/
            //StartCoroutine(AlphaFade(0.0f));
           // player.GetComponent<FirstPersonController>().enabled = true;
      //  }
   // }

  //  private IEnumerator AlphaFade(float fadeValue)
   // {

       // panel.CrossFadeAlpha(fadeValue, 3.0f, )
      //  yield return null;
        /*
        for (float t = panel.canvasRenderer.GetAlpha(); t < fadeValue;)
        {
            t += Time.deltaTime;
            panel.canvasRenderer.SetAlpha(t);
            yield return null;
        }
    }
*/
}
