using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLine : MonoBehaviour
   
{


    public Animator myAnim;




    private void OnTriggerEnter(Collider other) {

        if (other.gameObject.CompareTag("CollectedObj"))
        {
            myAnim.SetTrigger("End");
        }

    }


}
