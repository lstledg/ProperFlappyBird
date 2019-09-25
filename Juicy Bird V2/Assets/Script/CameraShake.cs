﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    
    //CameraShake
    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;

        float elapsed = 0.0f;

        while (elapsed <= duration)
        {
            float x = Random.Range(-1.2f, 1.2f) * magnitude;
            float y = Random.Range(-1.2f, 1.2f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalPos.z);

            elapsed += Time.deltaTime;
            print(duration);
            yield return null;
        }
        transform.localPosition = originalPos;
    }



}
