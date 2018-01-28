﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameCameraManager : MonoBehaviour {

    public GameObject playerToFollow;

    public float mipMapBias;

    public Vector2 cameraBoundsMin, cameraBoundsMax;

    void Start () {
        
    }
    
    void Update () {
        GetComponent<Camera>().targetTexture.mipMapBias = mipMapBias;

        if (playerToFollow != null) {
            transform.position = new Vector3(
                Mathf.Clamp(playerToFollow.transform.position.x, cameraBoundsMin.x, cameraBoundsMax.x),
                Mathf.Clamp(playerToFollow.transform.position.y, cameraBoundsMin.y, cameraBoundsMax.y), transform.position.z);
        }
    }

    internal void SetPixelEffectIntensity(float intensity) {
        mipMapBias = intensity;
    }
}
