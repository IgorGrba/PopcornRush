using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedObjController : MonoBehaviour
{
    PlayerManager playerManager;

    [SerializeField] Transform sphere;
    // Start is called before the first frame update
    void Start()
    {
        playerManager= GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManager>();


        if(GetComponent<Rigidbody>() == null) {
            gameObject.AddComponent<Rigidbody>();

            Rigidbody rb = GetComponent<Rigidbody>();

            rb.useGravity=false;
            rb.constraints= RigidbodyConstraints.FreezeAll;

        }
    }

   private void OnCollisionEnter(Collision other) {
       if(other.gameObject.CompareTag("CollectibleObj")) {
           if(!playerManager.collidedList.Contains(other.gameObject)) {
               other.gameObject.tag ="CollectedObj";
               other.transform.parent= playerManager.collectedPoolTransform;
               playerManager.collidedList.Add(other.gameObject);
               other.gameObject.AddComponent<CollectedObjController>();
           }
       }
       if(other.gameObject.CompareTag("Obstacle")) {
           DestroyTheObject();
       }
   }
   private void OnTriggerEnter(Collider other) {
              if(other.gameObject.CompareTag("CollectibleList")) {
                  print("trigger enter");
           other.transform.GetComponent<CapsuleCollider>().enabled=false;
           other.transform.parent= playerManager.collectedPoolTransform;

           foreach (Transform child in other.transform) {
               if(!playerManager.collidedList.Contains(child.gameObject)) {
                   playerManager.collidedList.Add(child.gameObject);
                   child.gameObject.tag="CollectedObj";
                   child.gameObject.AddComponent<CollectedObjController> ();
           }
           
               
           }
       }

   }
   void DestroyTheObject() {
       playerManager.collidedList.Remove(gameObject);
       Destroy(gameObject);

       Transform partcile= Instantiate(playerManager.partcilePrefab,transform.position,Quaternion.identity);
   }
}
