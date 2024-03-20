using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw: MonoBehaviour
{
    int speed = 1;

    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

}
