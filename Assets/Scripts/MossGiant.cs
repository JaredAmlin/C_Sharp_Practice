using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MossGiant : Enemy
{
    public override void Attack()
    {
        throw new System.NotImplementedException();
    }

    public override void Heal(int healAmount)
    {
        Health += healAmount;
    }

    public override void Death()
    {
        //instantiate custom particles and audio
        base.Death();
    }
}
