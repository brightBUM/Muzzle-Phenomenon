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
    [SerializeField] GameObject respawnpoint;
    public static Mazeloader instance;
    public Transform bridge_lastpoint;
    //[SerializeField] Transform maze_entrypoint;
    // Start is called before the first frame update

    private void Awake()
    {
        if(instance !=this && instance !=null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            playerref = FindObjectOfType<Movement>().gameObject;
            DontDestroyOnLoad(this.gameObject);
            DontDestroyOnLoad(playerref);
        }
        
    }
    void Start()
    {
        currentime = scenewaitime;
        StartCoroutine(loadmaze(scenewaitime));
    }
    IEnumerator loadmaze(float time)
    {
        //waiting
        yield return new WaitForSeconds(time);
        bridge_lastpoint = playerref.transform;
        
        SceneManager.LoadScene("Mazes");
        StartCoroutine(delay());
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(1f);
        respawnpoint = GameObject.FindGameObjectWithTag("Respawn");
        playerref.gameObject.SetActive(false);
        playerref.transform.position = respawnpoint.transform.position;
        playerref.gameObject.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        currentime -= Time.deltaTime;
        timer.text = currentime.ToString();
    }
}  
