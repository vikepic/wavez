﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour {

	void Update () {

        Vector2 playerPos = PlayerController.Instance.PlayerPos;
        Vector2 actPos = transform.position;

        float AngleRad = Mathf.Atan2(playerPos.y - actPos.y, playerPos.x - actPos.x);
        float AngleDeg = (180 / Mathf.PI) * AngleRad;

        transform.rotation = Quaternion.Euler(AngleDeg + 180, -90, 0);

    }
}
