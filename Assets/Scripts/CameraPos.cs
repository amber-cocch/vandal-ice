﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z - 1);
    }

    
}
