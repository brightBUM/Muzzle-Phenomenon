using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRange : MonoBehaviour
{
    public Combat parent;
    public Enemy enemyRef;
    // Start is called before the first frame update
    void Start()
    {
        parent = GetComponentInParent<Combat>();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.TryGetComponent<Enemy>(out Enemy en))
        {
            enemyRef = en;
            parent.AddEnemiesToList(en);

        }
    }
    private void OnTriggerExit(Collider other)
    {
            //Debug.Log("exited");
        if (other.TryGetComponent<Enemy>(out Enemy en))
        {
            enemyRef = null;
            parent.RemoveEnemiesFromList(en);

        }
        //    Debug.Log("exited");
        //if (other.gameObject.CompareTag("Enemy"))
        //{
        //    var en = other.GetComponent<Goblin>();
        //    parent.RemoveEnemiesFromList(en);
        //}
    }
}
