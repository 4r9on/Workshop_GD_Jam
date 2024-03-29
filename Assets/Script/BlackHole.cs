using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rbCut;
    [SerializeField]
    private float vel;

    private void OnTriggerStay2D(Collider other)
    {
        if (other.CompareTag("Cut"))
        {
            rbCut.velocity = new Vector3(0, vel); 
        }
    }
}
