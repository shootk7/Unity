using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject ground1;
    public const int Max_Jump_num = 2;
    private int jumpCount;
    private float jumpPower = 10f;
    private float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        jumpCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, speed/(jumpCount+1));
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -speed / (jumpCount + 1));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(speed/ (jumpCount + 1), 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-speed / (jumpCount + 1), 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < Max_Jump_num)
        {
            jumpCount += 1;
            rb.AddForce(0, jumpPower/jumpCount, 0, ForceMode.Impulse);
        }

        if (transform.position.y < -20)
        {
            float posx = ground1.transform.position.x;
        
            transform.position = new Vector3(posx, 1, 0);
            rb.velocity = Vector3.zero;
        }

    }

    void OnCollisionStay(Collision hit)
	{
        if (hit.gameObject.tag == "Enemy")
        {
            float posx = ground1.transform.position.x;

            transform.position = new Vector3(posx, 1, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        jumpCount = 0;
    }
}
