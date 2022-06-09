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

            Debug.Log("entered");
        //other.TryGetComponent<Enemy>(out Enemy en)
        //if (other.gameObject.CompareTag("Enemy"))
        //{
        //    var en = other.GetComponent<Goblin>();
        //    parent.AddEnemiesToList(en);
        //}
        if (other.TryGetComponent<Goblin>(out Goblin en))
        {
            parent.AddEnemiesToList(en);

        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<Goblin>(out Goblin en))
        {
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
