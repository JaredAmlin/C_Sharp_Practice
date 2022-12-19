using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour, IDamagable<int>, IHealable
{
    public int Health { get; set; }

    public int speed;
    public int health;
    public int gems;

    public void Damage(int damageAmount)
    {
        Health -= damageAmount;
    }

    public abstract void Attack();

    public abstract void Heal(int healAmount);

    public virtual void Death()
    {
        Destroy(this.gameObject);
    }
}

//public class MossGiant: Enemy
//{
//    public override void Attack()
//    {
//        throw new System.NotImplementedException();
//    }

//    public override void Heal(int healAmount)
//    {
//        Health += healAmount;
//    }

//    public override void Death()
//    {
//        //instantiate custom particles and audio
//        base.Death(); 
//    }
//}
