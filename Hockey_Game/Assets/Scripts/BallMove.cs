using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        int power = Random.Range(0, 2);
        power *= 20;
        power -= 10;

        rb.AddForce(power, 0, 0, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
