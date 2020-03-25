using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerMove : MonoBehaviour
{
    public GameObject ground2;
    // Start is called before the first frame update
    private float direction;
    void Start()
    {
        direction = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        float posx = this.transform.position.x;
        float posy = this.transform.position.y;
        float posz = this.transform.position.z;
        if (ground2.transform.position.x - posx <= -20f)
        {
            direction = -0.5f;
        }
        if (ground2.transform.position.x - posx >= 20f)
        {
            direction = 0.5f;
        }
        posx += direction;
        transform.position = new Vector3(posx, posy, posz);

    }
}
