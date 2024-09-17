using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolicBullet : MonoBehaviour
{
    Rigidbody bulletRB;
    [SerializeField] float initialSpeed = 50f;
    [SerializeField] float shotAngle = 45f;
    [SerializeField] Vector3 shotDirection;

    void Start()
    {
        Debug.Log("Parabolic Shot");
        bulletRB = GetComponent<Rigidbody>();

        float radianAngle = shotAngle * Mathf.Deg2Rad;

        Vector3 initialSpeedVector = new Vector3(
            0f, //initialSpeed * Mathf.Cos(radianAngle),
            initialSpeed * Mathf.Sin(radianAngle),
            initialSpeed * Mathf.Cos(radianAngle)
        );

        bulletRB.velocity = initialSpeedVector;
    }

    private void Update() {
        if(transform.position.y < 0){
            Destroy(gameObject);
        }
    }

}
