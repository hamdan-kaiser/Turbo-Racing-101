using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfLapTrigger : MonoBehaviour
{
    public GameObject CompleteTrigger;
    public GameObject HalfCompleteTrigger;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CompleteTrigger.SetActive(true);
            HalfCompleteTrigger.SetActive(false);
        }
        
    }

}
