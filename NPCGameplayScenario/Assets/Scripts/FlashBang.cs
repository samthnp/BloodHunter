using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashBang : MonoBehaviour
{
    public float lifeTime;

    private void Start()
    {
        Invoke("DestroyFlashBang", lifeTime);
    }

    private void DestroyFlashBang()
    {
        Destroy(gameObject);
    }
}
