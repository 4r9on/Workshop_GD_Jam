using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public Camera _cam;
    [SerializeField, Range(1,100)]
    private float _rotationSpeed = 1.0f;

    private void Awake()
    {
        _cam = Camera.main;
    }


    void Update()
    {
        var mousePosition = _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        transform.up = Vector3.MoveTowards(transform.up, mousePosition, _rotationSpeed*Time.deltaTime);
    }
}
