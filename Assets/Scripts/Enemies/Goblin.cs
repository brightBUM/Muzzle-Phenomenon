using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Enemy
{
    [Header("Goblin stats")]
    [SerializeField] float meterincamount = 5f;
    protected override void Start()
    {
        base.Start();
    }
    public override void die()
    {

        base.die();
        var permeter = PerceptionSpawner.instance;
        permeter.IncreasePerMeter(meterincamount);
        permeter.currentEnemyCount--;

    }
}
