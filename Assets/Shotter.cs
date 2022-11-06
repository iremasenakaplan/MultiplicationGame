using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotter : MonoBehaviour
{
    [SerializeField]  GameObject bullet;

    public void Shoot(){
        GameObject theBullet = Instantiate(bullet, transform.position+new Vector3(0, 0f, 0f), bullet.transform.rotation);
        theBullet.GetComponent<Rigidbody>().AddForce(-transform.forward* 500f);
    }
}
