using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Mazeloader : MonoBehaviour
{
    [SerializeField] float scenewaitime = 20f;
    private float currentime;
    [SerializeField] TextMeshProUGUI timer;
    [SerializeField] GameObject playerref;

    [SerializeField] Transform bridge_entrypoint;
    [SerializeField] Transform maze_entrypoint;
    [SerializeField] Transform maze_exitpoint;
    // Start is called before the first frame update
    
    void Start()
    {
        currentime = scenewaitime;
        StartCoroutine(loadmaze(scenewaitime));
    }
    IEnumerator loadmaze(float time)
    {
        //waiting
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Mazes");

    }
    // Update is called once per frame
    void Update()
    {
        currentime -= Time.deltaTime;
        timer.text = currentime.ToString();
    }
}  
