using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Double : MonoBehaviour
{
    public GameObject litCutPrefab;
    public Transform divleft;
    public Transform divright;

    public float force;

    Touch touch;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Div();
        }
    }

    void Div()
    {
        GameObject litcut1 = Instantiate(litCutPrefab, divleft.position, divleft.rotation);
        Rigidbody rb = litcut1.GetComponent<Rigidbody>();
        rb.AddForce(divleft.forward*force, ForceMode.Impulse);

        GameObject litcut2 = Instantiate(litCutPrefab, divright.position, divright.rotation);
        Rigidbody rb2 = litcut2.GetComponent<Rigidbody>();
        rb2.AddForce(divright.forward * force, ForceMode.Impulse);

        Destroy(this.gameObject);
    }
}
