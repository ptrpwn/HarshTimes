﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFollowMouse : MonoBehaviour
{
    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = Input.mousePosition;
    }
}
