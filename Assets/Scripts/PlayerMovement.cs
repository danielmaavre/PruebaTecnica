using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class PlayerMovement : MonoBehaviour
{

    Vector2 rawInput;
    String currentGun;
    bool hasGun = false;
    [SerializeField] GameObject parabolicGun;
    [SerializeField] GameObject gravityGun;
    [SerializeField] GameObject boomerangGun;

    [SerializeField] GameObject parabolicBullet;
    [SerializeField] GameObject gravityBullet;
    [SerializeField] GameObject boomerangBullet;
    [SerializeField] Transform gun;

    [SerializeField] float playerSpeed = 5f;

    private void Start() {
        
    }
    void Update()
    {
        PlayerMoves();
    }

    private void PlayerMoves()
    {
        Vector3 delta = new Vector3(rawInput.x,0f,rawInput.y);
        transform.position += delta * Time.deltaTime * playerSpeed;
    }

    void OnMove(InputValue value){
        rawInput = value.Get<Vector2>();      
    }

    void OnFire(InputValue value){
        if(currentGun == "P"){
            Debug.Log("Parabolic Bullet");
            Instantiate(parabolicBullet,gun.transform);
        }else if(currentGun == "G"){
            Debug.Log("Gravity Bullet");
            Instantiate(gravityBullet,gun.transform);
        }else if(currentGun == "B"){
            Debug.Log("Boomerang Bullet");
            Instantiate(boomerangBullet,gun.transform);
        }else{
            Debug.Log("No Gun!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        DestroyChildGun();
        InstantiateGun(other);
    }

    private void InstantiateGun(Collider other)
    {
        if (other.tag == "Parabolic")
        {
            Instantiate(parabolicGun,gun.transform);
            currentGun = "P";
        }
        else if (other.tag == "Gravity")
        {
            Instantiate(gravityGun,gun.transform);
            currentGun = "G";
        }
        else if (other.tag == "Boomerang")
        {
            Instantiate(boomerangGun,gun.transform);
            currentGun = "B";
        }
        hasGun = true;
    }

    private void DestroyChildGun()
    {
        if (hasGun)
        {
            Transform childGun = gun.transform.GetChild(0);
            Destroy(childGun.gameObject);
            hasGun = false;
        }
    }
}
