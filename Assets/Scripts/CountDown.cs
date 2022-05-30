using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CountDown : MonoBehaviour
{
    [SerializeField] float scenewaitime = 20f;
    private float currentime;
    [SerializeField] TextMeshProUGUI timer;
    void Start()
    {
        currentime = scenewaitime;
        StartCoroutine(loadmaze(scenewaitime));
    }

    // Update is called once per frame
    void Update()
    {
        currentime -= Time.deltaTime;
        timer.text = currentime.ToString();
    }
    IEnumerator loadmaze(float time)
    {
        //waiting
        yield return new WaitForSeconds(time);
        GameManager.instance.StorePlayerPos();
        SceneManager.LoadScene("Mazes");
    }
}
