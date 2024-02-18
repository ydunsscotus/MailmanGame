using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float turnSpeed = 1;
    [SerializeField] float moveSpeed = 20;
    [SerializeField] float slowSpeed = 15;
    [SerializeField] float boostSpeed = 30;


    void Update()
    {
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime; // menjadi kecepatan rotasi 
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -turnAmount); // - untuk membalikkan control 
        transform.Translate(0, moveAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D other){
        moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "SpeedUP"){
            moveSpeed = boostSpeed;
        }
    }

}
