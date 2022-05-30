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
        playerref.transform.position = bridge_lastpoint;
    }

    public void SetnewPlayerPos()
    {
        playerref.gameObject.SetActive(false);
        playerref.transform.position = Mazexit.entrypoint.position;
        playerref.gameObject.SetActive(true);
    }
    
    //IEnumerator delay()
    //{
    //    yield return new WaitForSeconds(1f);
    //    respawnpoint = GameObject.FindGameObjectWithTag("Respawn");
    //    playerref.gameObject.SetActive(false);
    //    playerref.transform.position = respawnpoint.transform.position;
    //    playerref.gameObject.SetActive(true);
    //}

    //void OnSceneLoaded(Scene scene,LoadSceneMode mode)
    //{
    //    if(bridge_lastpoint!=Vector3.zero)
    //    {
    //        playerref.gameObject.SetActive(false);
    //        playerref.transform.position = bridge_lastpoint;
    //        playerref.gameObject.SetActive(true);
    //    }
    //}
    
}  
