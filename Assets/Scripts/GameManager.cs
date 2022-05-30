using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
   
    [SerializeField] GameObject playerref;
    [SerializeField] Transform respawnpoint;
    public static GameManager instance;
    public static Vector3 bridge_lastpoint;
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
            DisableTrail();
            DontDestroyOnLoad(this.gameObject);
        }

        //SceneManager.sceneLoaded += OnSceneLoaded;
        
    }
    void Start()
    {
       
    }
    
    public void StorePlayerPos()
    {
        bridge_lastpoint = playerref.transform.position;
    }

    public void RestorePlayerPos()
    {
        playerref.gameObject.SetActive(false);
        playerref.transform.position = bridge_lastpoint+new Vector3(0,5f,0);
        playerref.gameObject.SetActive(true);
    }

    public void EnableTrail()
    {
        playerref.GetComponent<TrailRenderer>().enabled = true;
    }
    public void DisableTrail()
    {
        playerref.GetComponent<TrailRenderer>().enabled = false;
    }

    public void SetnewPlayerPos()
    {
        playerref.gameObject.SetActive(false);
        playerref.transform.position = Mazexit.entrypoint.position;
        playerref.gameObject.SetActive(true);
    }
    
    
    
}  
