using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class shooting : MonoBehaviour
{
    public static UnityEvent shotenemy = new UnityEvent();
    [SerializeField] float damage;
    [SerializeField] Transform shootpos;
    [SerializeField] LayerMask enemylayer;
    [SerializeField] Transform maincam;
    [SerializeField] float timebwshots = 2f;
    [SerializeField] AudioSource shootsound;
    
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
        timer += Time.deltaTime;
        //RaycastHit hit;
        //Debug.DrawRay(maincam.position, maincam.forward * 10f, Color.red);
        //if (Physics.Raycast(maincam.position, transform.forward*10f, out hit, 10f, enemylayer))
        //{
        //    if (timer >= timebwshots)
        //    {
        //        shotenemy.Invoke();
        //        timer = 0;
        //    }
        //}
    }

    public void shootbullet()
    {
        if(timer>=timebwshots)
        {
            ////getobjectfrompool
            //var temp = objectpooler.instance.spawnfrompool(shootpos.position);
            ////givedirection
            //var bulletdir = shootpos.transform.forward;
            //temp.GetComponent<bullet>().setdirection(bulletdir);
            //shootsound.Play();
            //timer = 0;
        }
       
        
    }
}
