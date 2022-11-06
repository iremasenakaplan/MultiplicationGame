using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{   
    public GameObject cannonBallPrefab;
    public Transform firePoint;

    private Camera _cam;
    private bool _pressingMouse = false;

    private Vector3 _initialVelocity;

    void Start()
    {
        _cam = Camera.main;
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        _pressingMouse=true;
        if(Input.GetMouseButtonUp(0))
        {
            _pressingMouse=false;
            _Fire();
        }

        if(_pressingMouse)
        {
          Vector3 mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
          mousePos.z =0;

          transform.LookAt(mousePos);
        }
    }

    private void _Fire()
    {
        GameObject cannonBall = Instantiate(cannonBallPrefab, firePoint.position, Quaternion.identity);
        Rigidbody rb = cannonBall.GetComponent<Rigidbody>();
        rb.AddForce(_initialVelocity, ForceMode.Impulse);
    }
}
