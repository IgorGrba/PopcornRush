using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLine : MonoBehaviour
   
{

    public Rigidbody myRB;
    public Animator myAnim;
    private void OnTriggerEnter(Collider other) {

        if (other.gameObject.CompareTag("CollectedObj"))
        {
            myRB.AddForce(0, 3, 0, ForceMode.Impulse);

            myAnim.SetTrigger("End");
        }

    }




}
