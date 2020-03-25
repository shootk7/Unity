using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstractMove : MonoBehaviour
{
    private float direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = Random.Range(0, 2) * 2 - 1;
        direction *= 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        float posx = this.transform.position.x;
        float posy = this.transform.position.y;
        float posz = this.transform.position.z;
        if (posy <1f || 5f < posy)
        {
            direction *= -1f;
        }
        posy += direction;
        transform.position = new Vector3(posx, posy, posz);
    }
}
