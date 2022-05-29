using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mazexit : MonoBehaviour
{
    [SerializeField] Mazeloader mz;
    // Start is called before the first frame update
    void Start()
    {
        mz = FindObjectOfType<Mazeloader>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.transform.position =  mz.bridge_lastpoint.position;
            SceneManager.LoadScene("bridge");
        }
    }
}
