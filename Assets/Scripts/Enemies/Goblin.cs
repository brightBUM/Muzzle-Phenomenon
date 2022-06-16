using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Enemy
{
    [Header("Goblin stats")]
    [SerializeField] float meterincamount = 5f;
    public override void Start()
    {
        base.Start();
    }
    public override void die()
    {
        base.die();
        Debug.Log("inc");
        PerceptionSpawner.instance.IncreasePerMeter(meterincamount);

    }
}
