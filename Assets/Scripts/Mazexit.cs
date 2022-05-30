using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mazexit : MonoBehaviour
{
    [SerializeField] Transform _entrypoint;
    public static Transform entrypoint;
    [SerializeField] Animator anim;
    // Start is called before the first frame update
    private void Awake()
    {
        entrypoint = _entrypoint;

    }
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnMazeSceneLoaded;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            anim.SetTrigger("Fadein");
            StartCoroutine(transitiondelay(1));
            //other.transform.position =  mz.bridge_lastpoint.position;
        }
    }
    IEnumerator transitiondelay(float time)
    {
        yield return new WaitForSeconds(time);
        GameManager.instance.RestorePlayerPos();
        SceneManager.LoadScene("bridge");

    }
    public void OnMazeSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        GameManager.instance.SetnewPlayerPos();
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnMazeSceneLoaded;
    }
}
