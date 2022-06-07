using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juggernaut : Enemy
{
    public float range;
    // Start is called before the first frame update
    void Start()
    {
        var mrange = GetComponentInChildren<SphereCollider>();
        mrange.radius = range;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
