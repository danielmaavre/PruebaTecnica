using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Boomerang : MonoBehaviour
{

Rigidbody bulletRB;
[SerializeField] float bulletSpeed = 50f;
[SerializeField] float returnTime = 2f;
GameObject player;


    private void Start() {
        player = GameObject.Find("Player");
        bulletRB = GetComponent<Rigidbody>();
        bulletRB.velocity = transform.forward * bulletSpeed;
        Invoke("BoomerangReturns",returnTime);
    }

    private void BoomerangReturns()
    {
        Debug.Log("Returns!!!");
        Vector3 returnDirection = (player.transform.position - transform.position).normalized;
        bulletRB.velocity = returnDirection * bulletSpeed;
    }

    private void Update() {
       
    }
}
