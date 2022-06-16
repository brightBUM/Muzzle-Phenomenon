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
    [SerializeField] Slider healthBar;
    [SerializeField] GameObject deathCanvas;
    [SerializeField] PlayerAudio playerAudio;
    [SerializeField] bool pressed = false;    
    [SerializeField] public List<Enemy> enemiesinRange;
    // Start is called before the first frame update
    //float timer;
    void Start()
    {
        playerAudio = GetComponent<PlayerAudio>();
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
            playerAudio.PunchSfx();
            anim.SetTrigger("punch");
            if(enemiesinRange.Count>0)
            {
                playerAudio.PunchSfx();
                foreach (Enemy enmy in enemiesinRange)
                {
                    //StartCoroutine(enmy.DamageWithDelay(punchDamage, 1.2f));
                    enmy.damage(punchDamage);
                }
            }
            else
            {
                playerAudio.ArmSwing();
            }
            
            
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
        if (!pressed)
        {
            StartCoroutine(Timebetattacks());
            anim.SetTrigger("punch");
            foreach (Enemy enmy in enemiesinRange)
            {
                enmy?.damage(kickDamage);
            }

        }

    }
    public void AddEnemiesToList(Enemy en)
    {
        enemiesinRange.Add(en);
    }
    public void RemoveEnemiesFromList(Enemy en)
    {
        enemiesinRange.Remove(en);
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
