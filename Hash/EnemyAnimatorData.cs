using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimatorData : MonoBehaviour
{
    public class Params
    {
        public static readonly int Victory = Animator.StringToHash("Victory");
        public static readonly int Attack = Animator.StringToHash("Attack");

    }
}