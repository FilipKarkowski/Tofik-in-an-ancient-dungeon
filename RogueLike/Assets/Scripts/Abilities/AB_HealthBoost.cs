using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AB_HealthBoost : Ability
{
    internal override void AbilityBuff(float BuffStrenght)
    {
        playerStats.maximumPlayerHealth += BuffStrenght;
    }
}
