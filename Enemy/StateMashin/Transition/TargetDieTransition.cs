using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDieTransition : Transitions
{
    private void Update()
    {
        if(Target == null)
        {
            NeedTransit = true;
        }
    }
}