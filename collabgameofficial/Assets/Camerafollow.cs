using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public bool bossfight = false;
    public float followspeed = 2f;
    public Transform target;
    // Update is called once per frame
    void Update()
    {
        if(bossfight == false){

        
        Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position,newPos, followspeed*Time.deltaTime);
        }
    }
}
