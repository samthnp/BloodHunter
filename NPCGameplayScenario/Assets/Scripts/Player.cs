using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Transform dropTransform;
    public GameObject flashBangMesh;

    private void Update()
    {
        var mouse = Mouse.current;
        if (mouse == null)
            return;

        if (mouse.leftButton.wasPressedThisFrame)
        {
            DropFlashBang();
        }
    }

    public void DropFlashBang()
    {
        Instantiate(flashBangMesh, dropTransform.position, Quaternion.identity);
    }
}
