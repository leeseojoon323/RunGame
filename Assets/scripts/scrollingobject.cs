﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollingobject : MonoBehaviour
{

    
        public float speed = 10f;

    void Update()
    {
            transform.Translate(Vector3.left * speed * Time.deltaTime);

        }
    }

