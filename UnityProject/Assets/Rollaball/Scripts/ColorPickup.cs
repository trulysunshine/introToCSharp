using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPickup : BasePickup
{
    public Material rewardMaterial;

    protected override void ApplyPickup(Player Target)
    {
        Target.colorMaterials.Add(rewardMaterial);
    }
    
}
