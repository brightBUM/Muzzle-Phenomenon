using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grunt : Enemy
{
    [SerializeField] float currentDistance;
    [SerializeField] float rangedAttackDistance;
    [SerializeField] float timebwRangedattack;
    [SerializeField] GameObject throwableRef;
    //[SerializeField] Movement playerRef;
    // Start is called before the first frame update
    bool throwing = false;
    protected override void Start()
    {
        base.Start();
        throwableRef.SetActive(false);
        
    }
    protected override void Patrolling()
    {
        base.Patrolling();
        if(playeRef!=null)
        {
            var mypos = new Vector2(transform.position.x, transform.position.z);
            var playerpos = new Vector2(playeRef.transform.position.x, playeRef.transform.position.z);
            currentDistance = Vector2.Distance(mypos,playerpos );
            if (currentDistance < rangedAttackDistance)
            {
                enemystate = EnemyState.CHASING;
            }
        }
        
    }
    protected override void ChasePlayer()
    {
        // chase player method is now RangedAttack() for Grunt
        if (!throwing)
        {
            StartCoroutine(RangedAttack(timebwRangedattack));
        }

    }
    IEnumerator RangedAttack(float time)
    {
        throwing = true;

        yield return new WaitForSeconds(time);



        throwing = false;
    }

    public void AimAndThrow()
    {

    }
}
