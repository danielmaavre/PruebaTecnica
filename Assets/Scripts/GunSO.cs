using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( menuName ="Gun", fileName ="New Gun")]
public class GunSO : ScriptableObject
{
    [SerializeField] int bulletSpeed = 5;
    [SerializeField] float bulletAngle = 45f;
    [SerializeField] Vector3 originPoint;
    [SerializeField] Vector3 shotDirection;
    [SerializeField] GameObject bulletType;

}
