using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Transform forwardRegion;
    [SerializeField] Transform backRegion;
    [SerializeField] float disforward, distanceback;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Calculatedistance();
        //var forwardregionpos = 
    }
    void SetDifficulty()
    {
        disforward = 100 - GameManager.instance.difficulty * 90;
    }
    private void Calculatedistance()
    {
        disforward = Vector3.Distance(Movement.instance.transform.position, forwardRegion.position);
        distanceback = Vector3.Distance(Movement.instance.transform.position, backRegion.position);
    }
}
