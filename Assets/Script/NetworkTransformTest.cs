using HelloWorld;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class NetworkTransformTest : NetworkBehaviour
{
    void Update()
    {
        if (IsServer)
        {
            float theta = Time.frameCount / 10.0f;
            transform.position = new Vector3((float)Math.Cos(theta), 0.0f, (float)Math.Sin(theta));
            GetComponent<HelloWorldPlayer>().Position.Value = transform.position;
        }
    }
}
