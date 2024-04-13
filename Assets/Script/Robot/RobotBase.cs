using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RobotBase : MonoBehaviour
{
    [SerializeField, Tooltip("機体のコスト")] protected float _cost;
    [SerializeField, Tooltip("チーム")] protected int _team;

    /// <summary>射撃 </summary>
    protected abstract void Shooting();
    /// <summary>格闘 </summary>
    protected abstract void Attack();
    /// <summary>サブ射撃 </summary>
    protected abstract void SubShooting();
    /// <summary>特殊射撃 </summary>
    protected abstract void SpecialShooting();
    /// <summary>特殊格闘 </summary>
    protected abstract void SpecialAttack();
    /// <summary>覚醒 </summary>
    protected abstract void Awaking();
    /// <summary>覚醒技 </summary>
    protected abstract void AwakingAttack();
}
