using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handgrab : MonoBehaviour
{
    [SerializeField] private Animator myAnim;
    public Rigidbody myRB;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CollectedObj"))
        {
            myAnim.SetBool("handGrab", true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("CollectedObj"))
        {
            myAnim.SetBool("handGrab", false);
        }
    }
}
