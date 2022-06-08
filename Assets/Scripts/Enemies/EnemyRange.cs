using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRange : MonoBehaviour
{
    public Combat playerRef;
    public Enemy enemy;
    private void Start()
    {
        enemy = GetComponentInParent<Enemy>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Combat>(out Combat cm))
        {
            playerRef = cm;
            enemy.SetPlayerRef(cm);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Combat>())
        {
            playerRef = null;
            enemy.RemovePlayerRef();
        }
    }
}
