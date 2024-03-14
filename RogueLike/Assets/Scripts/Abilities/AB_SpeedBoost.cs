using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AB_SpeedBoost : Ability
{
	
    internal override void AbilityBuff(float BuffStrenght)
    {
        playerStats.moveSpeed *= BuffStrenght;
    }
}
