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
        var bullet = Instantiate(litCutPrefab, divleft.position, divleft.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = divleft.up * force;

        /*GameObject litcut1 = Instantiate(litCutPrefab, divleft.position, divleft.rotation);
        Rigidbody2D rb = litcut1.GetComponent<Rigidbody2D>();
        rb.AddForce(divleft.forward*force, ForceMode2D.Impulse);

        GameObject litcut2 = Instantiate(litCutPrefab, divright.position, divright.rotation);
        Rigidbody2D rb2 = litcut2.GetComponent<Rigidbody2D>();
        rb2.AddForce(divright.forward * force, ForceMode2D.Impulse);*/

        Destroy(this.gameObject);
    }
}
