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
            parent.AddEnemiesToList(en);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<Enemy>(out Enemy en))
        {
            parent.RemoveEnemiesFromList(en);
            
        }
    }
}
