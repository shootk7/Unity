﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground1Move : MonoBehaviour
{
    private float direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = Random.Range(0, 2) * 2 - 1;
        direction *= 0.05f;
        transform.position = new Vector3(0, 0, 30);
    }

    // Update is called once per frame
    void Update()
    {
        float posx = this.transform.position.x;
        float posy = this.transform.position.y;
        float posz = this.transform.position.z;
        if (posx < -15f || 15f < posx)
        {
            direction *= -1f;
        }
        posx += direction;
        transform.position = new Vector3(posx, posy, posz);

    }
}
