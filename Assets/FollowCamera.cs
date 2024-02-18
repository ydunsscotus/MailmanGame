using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    //this thing position should be same as car position

    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-5);
    }
}
