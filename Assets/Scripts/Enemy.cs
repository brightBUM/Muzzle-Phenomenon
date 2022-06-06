using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Enemy : MonoBehaviour,Idamagable
{
    public float maxHealth = 100f;
    [SerializeField] private float currentHealth;
    [SerializeField] float enemySpeed = 4f;
    [SerializeField] float barspeed = 3f;
    [SerializeField] float timebwAttacks = 3f;
    [SerializeField] float attackdistance =2f;
    [SerializeField] float enemyDamage = 20f;
    [SerializeField] float distance;
    [SerializeField] Slider healthbar;
    [SerializeField] Combat playeRef;
    //[SerializeField] Rigidbody rb;
    [SerializeField] NavMeshAgent agent;
    
    public bool attacking = false;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        speedref = agent.speed;
        healthbar = GetComponentInChildren<Slider>();
        playeRef = Movement.instance.GetComponent<Combat>();
        //enemystate = EnemyState.IDLE;
        currentHealth = maxHealth;
        healthbar.maxValue = maxHealth;
    }
    //public enum EnemyState
    //{
    //    IDLE,
        
    //    CHASING,
    //    ATTACKING
    //}
    //public EnemyState enemystate;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        HealthCondition();
        StateCheck();
    }

    public void damage(float amount)
    {

        currentHealth -= amount;
        //rb = GetComponent<Rigidbody>();
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

    private void StateCheck()
    {
        if (playeRef != null)
        {
            distance = Vector3.Distance(transform.position, playeRef.transform.position);
            if (distance > attackdistance)
            {
                ChasePlayer();
            }
            else
            {
                if (!attacking)
                {
                    StartCoroutine(Attacking());
                }

            }
        }
    }
    float speedref;
    public void ChasePlayer()
    {
        agent.speed = speedref;
        if(playeRef!=null)
        {
            agent.SetDestination(playeRef.transform.position);
        }

    }
    //public void Idlestate()
    //{
    //    speedref = agent.speed;
    //    agent.speed = 0f;
    //}
    public void AttackPlayer()
    {

        playeRef.damage(enemyDamage);
    }
    IEnumerator Attacking()
    {
        attacking = true;
        AttackPlayer();
        yield return new WaitForSeconds(timebwAttacks);
        attacking = false;

    }
    public void die()
    {
        Movement.instance.GetComponent<Combat>().enemiesinRange.Remove(this);
        Destroy(this.gameObject, 0.5f);
    }

   
    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.TryGetComponent<Combat>(out Combat cm))
    //    {
    //        playeRef = cm;
    //        //enemystate = EnemyState.CHASING;
    //    }
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.GetComponent<Combat>())
    //    {
    //        playeRef = null;
    //    }
    //}

}

interface Idamagable
{
    public void damage(float amount);
    public void die();
}
