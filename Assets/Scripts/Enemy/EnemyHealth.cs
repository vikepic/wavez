﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : HealthManager {

	public void Stun()
    {
        DecrementHealth();
    }
}
