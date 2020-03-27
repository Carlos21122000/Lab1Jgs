﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oscile : MonoBehaviour
{
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = startPos + new Vector3(0, Mathf.Sin(Time.time), 0);
    }
}
