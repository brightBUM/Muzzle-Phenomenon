using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combat : MonoBehaviour,Idamagable
{
    public float maxHealth = 100f;
    public float punchDamage = 30f;
    public float kickDamage = 50f;
    [SerializeField] private float currentHealth;
    [SerializeField] float attackCoolDownTime = 2f;
    [SerializeField] Animator anim;
    [SerializeField] Enemy enemyinrange;
    [SerializeField] Slider healthBar;
    [SerializeField] GameObject deathCanvas;
    float timer;
    [SerializeField] bool pressed = false;    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = Mathf.Lerp(healthBar.value, currentHealth, Time.deltaTime * 3f);
        if (currentHealth <= 0)
        {
            die();
        }
    }

    public void punch()
    {
        if(!pressed)
        {
            StartCoroutine(Timebetattacks());
            anim.SetTrigger("punch");
            enemyinrange?.damage(punchDamage);
        }
        
    }
    IEnumerator Timebetattacks()
    {
        pressed = true;
        yield return new WaitForSeconds(attackCoolDownTime);
        pressed = false;
    }
    public void kick()
    {
        //anim.SetTrigger("kick");
        enemyinrange?.damage(kickDamage);

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<Enemy>(out Enemy en))
        {
            enemyinrange = en;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.GetComponent<Enemy>())
        {
            enemyinrange = null;
        }
    }
    public void damage(float amount)
    {
        currentHealth -= amount;
    }
    public void die()
    {
        deathCanvas.SetActive(true);
        
    }
}
