using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // speed variable of 8
    [SerializeField]
    private float _speed = 8f;

    // Update is called once per frame
    void Update()
    {
        // move laser up
        transform.Translate(Vector3.up * _speed * Time.deltaTime);

        // if the laser position on Y is > 8
        // kill the laser
    }
}
