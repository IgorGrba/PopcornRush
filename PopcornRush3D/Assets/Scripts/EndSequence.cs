using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSequence : MonoBehaviour
{
    [SerializeField] private Animator myAnim;
    public Rigidbody myRB;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CollectedObj"))
        {
            myRB.freezeRotation = true;
            myAnim.SetBool("End", true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("CollectedObj"))
        {
            myAnim.SetBool("End", false);
        }
    }
}
