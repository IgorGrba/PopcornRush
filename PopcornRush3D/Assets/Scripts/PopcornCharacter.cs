using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopcornCharacter : MonoBehaviour
   

{
    [Header("Kernel Visual")]
    public GameObject kernelModel;
    public Animator kernelAnimator;
    

    [Header("Popcorn Visual")]
    public GameObject popcornModel;
    public Animator popcornAnimator;

    public void ActivatePopcorn()
    {
        kernelModel.SetActive(false);
        popcornModel.SetActive(true);
        if(popcornModel.activeInHierarchy == false)
        {
            popcornAnimator.SetTrigger("Pop");
        }
        
        
    }

    public void ActivateKernel()
    {
        kernelModel.SetActive(true);
        popcornModel.SetActive(false);
    }

}
