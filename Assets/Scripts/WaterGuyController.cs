﻿using UnityEngine;
using System.Collections;

public class WaterGuyController : MonoBehaviour
{
    Rigidbody2D _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
}
