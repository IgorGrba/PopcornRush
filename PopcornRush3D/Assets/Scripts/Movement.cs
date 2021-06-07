﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;
    [SerializeField] float movementSpeed;
    [SerializeField] float controlSpeed;
    [SerializeField] Animator myAnim;

    //Touch Settings
    [SerializeField] bool isTouching;
    float touchPosX;
    Vector3 direction;

    void Start()
    {

    }


    void Update()
    {
        GetInput();
    }

    private void FixedUpdate() {
        if(playerManager.playerState==PlayerManager.PlayerState.Move) {
            myAnim.SetBool("isRunning", true);
            transform.position += Vector3.forward * movementSpeed * Time.fixedDeltaTime;
        }

        ///TRY TO FIGURE IT OUT
        // if(playerManager.playerState==PlayerManager.PlayerState.Stop)
        // {
        //     myAnim.SetBool("isRunning", false);
        // }
        
        
        if(isTouching) {
            touchPosX += Input.GetAxis("Mouse X") * controlSpeed *Time.fixedDeltaTime;
        }
        

        transform.position = new Vector3(touchPosX, transform.position.y, transform.position.z);
    }

    void GetInput() {
        if(Input.GetMouseButton(0)) {
            isTouching=true;
        }
        else {
            isTouching=false;
        }
    }
}