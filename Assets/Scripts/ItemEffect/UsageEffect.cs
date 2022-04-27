using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class UsageEffect : UsableItem.UsageEffect
{
    public override bool Use(CharacterData user)
    {
        return false;
    }
}
