﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour {

    bool ded = false;

    public void Kill()
    {
        ded = true;
    }

    void Update () {
        if (ded)
            return;
        Vector2 mousePos = MouseInputController.Instance.GetMouseScreenCoords();
        Vector2 actPos = transform.position;

        float AngleRad = Mathf.Atan2(mousePos.y - actPos.y, mousePos.x - actPos.x);
        float AngleDeg = (180 / Mathf.PI) * AngleRad;

        transform.rotation = Quaternion.Euler(0, 0, AngleDeg);

    }
}
