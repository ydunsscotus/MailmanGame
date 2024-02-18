using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverySystem : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] float DestroyDelay = 0.5f;
    
    bool hasPackage;
    SpriteRenderer spriteRenderer;

    void Start (){
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // void Start() {
    //     Debug.Log(hasPackage);
    // }
    void OnCollisionEnter2D(Collision2D other){
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && hasPackage==false){
            Debug.Log("Package picked up");
            hasPackage = true; 
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, DestroyDelay);
        }
        if (other.tag == "delivered1" && hasPackage){
            Debug.Log("Packaged delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
        
    }

    
}
