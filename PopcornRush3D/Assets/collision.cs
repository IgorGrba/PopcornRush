using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public GameObject myPrefab;
    // Update is called once per frame
    void Update()
    {
        void OnTriggerEnter(Collider other) {
            Instantiate(myPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
        Debug.Log("Colliderhit");
        }
        
    }
}