using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameState gameState;
    [SerializeField] GameObject newGameBut;
    [SerializeField] GameObject continueBut;
    [SerializeField] GameObject exitBut;

    // Start is called before the first frame update
    void Start()
    {
        if(gameState.playCount>0)
        {
            continueBut.GetComponent<Button>().interactable = true;
        }
        else
        {
            continueBut.GetComponent<Button>().interactable = false;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NewGame()
    {
        SceneManager.LoadScene("Intro");
    }
    public void Continue()
    {
        SceneManager.LoadScene("bridge");

    }
    public void Exit()
    {
        Application.Quit();
    }
}
