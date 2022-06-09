using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Enemy : MonoBehaviour,Idamagable
{
    [Header("Enemy Stats")]
    public float maxHealth = 100f;
    [SerializeField] private float currentHealth;
    [SerializeField] float enemySpeed = 4f;
    [SerializeField] float patrolDistance = 4f;

    [Header("Attack Stats")]
    [SerializeField] float enemyDamage = 20f;
    [SerializeField] float barspeed = 3f;
    [SerializeField] float timebwAttacks = 3f;
    [SerializeField] float attackdistance =2f;
    [SerializeField] float distance;
    [SerializeField] protected Slider healthbar;
    [SerializeField] protected Combat playeRef;
    //[SerializeField] Rigidbody rb;
    [SerializeField] protected NavMeshAgent agent;
    Vector3 startpoint;
    public Vector3 newpoint;
    float stoppingdistanceref;
    public bool attacking = false;
    public virtual void Start()
    {
        startpoint = transform.position;
        newpoint = GetNewPoint();
        
        
        enemystate = EnemyState.PATROLLING;
        agent = GetComponent<NavMeshAgent>();
        agent.speed = enemySpeed;
        stoppingdistanceref = agent.stoppingDistance;

        healthbar = GetComponentInChildren<Slider>();
        currentHealth = maxHealth;
        healthbar.maxValue = maxHealth;
    }
    public enum EnemyState
    {
        PATROLLING,
        CHASING,
        ATTACKING
    }
    public EnemyState enemystate;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        HealthCondition();
        switch(enemystate)
        {
            case EnemyState.PATROLLING:
                Patrolling();
                break;
            case EnemyState.CHASING:
                ChasePlayer();
                break;
            case EnemyState.ATTACKING:
                AttackPlayer();
                break;

        }
    }
    void Patrolling()
    {
        agent.stoppingDistance = 0f;
        if(playeRef ==null)
        {
            var distance = Vector3.Distance(transform.position, newpoint);
            if (distance>=0.1f)
            {
                agent.SetDestination(newpoint);
            }
            else
            {
                newpoint = GetNewPoint();
            }


        }
        
    }

    void AttackPlayer()
    {
        if (!attacking)
        {
            StartCoroutine(Attacking());
        }
    }
    Vector3 GetNewPoint()
    {
        var np = startpoint + new Vector3(Random.Range(2, patrolDistance), 0, Random.Range(2, patrolDistance));
        np.y = transform.position.y;
        return np;
    }
    public void damage(float amount)
    {
        currentHealth -= amount;
    }
    public void SetPlayerRef(Combat cm)
    {
        this.playeRef = cm;
        enemystate = EnemyState.CHASING;
    }
    public void RemovePlayerRef()
    {
        this.playeRef = null;
        enemystate = EnemyState.PATROLLING;
    }
    public IEnumerator DamageWithDelay(float amount,float time)
    {
        yield return new WaitForSeconds(time);
        currentHealth -= amount;
    }
    private void HealthCondition()
    {
        healthbar.value = Mathf.Lerp(healthbar.value, currentHealth, Time.deltaTime * barspeed);
        if (healthbar.value <= 0)
        {
            die();
        }
    }

    //private void StateCheck()
    //{
    //    if (playeRef != null)
    //    {
    //        distance = Vector3.Distance(transform.position, playeRef.transform.position);
    //        if (distance > attackdistance)
    //        {
    //            ChasePlayer();
    //        }
    //        else
    //        {
    //            if (!attacking)
    //            {
    //                StartCoroutine(Attacking());
    //            }

    //        }
    //    }
    //    else
    //    {

    //    }
    //}
    public void ChasePlayer()
    {
        agent.stoppingDistance = stoppingdistanceref;
        if(playeRef!=null)
        {
            agent.SetDestination(playeRef.transform.position);
        }
        distance = Vector3.Distance(transform.position, playeRef.transform.position);
        if (distance < attackdistance)
        {
            enemystate = EnemyState.ATTACKING;
        }

    }
    //public void Idlestate()
    //{
    //    speedref = agent.speed;
    //    agent.speed = 0f;
    //}
   
    IEnumerator Attacking()
    {
        attacking = true;
        playeRef.damage(enemyDamage);
        yield return new WaitForSeconds(timebwAttacks);
        attacking = false;

    }
    public void die()
    {
        Movement.instance.GetComponent<Combat>().enemiesinRange.Remove(this);
        Destroy(this.gameObject, 0.5f);
    }
}

interface Idamagable
{
    public void damage(float amount);
    public void die();
}
