using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CutScene : MonoBehaviour
{
    [SerializeField] IntroPanel[] panels;
    [SerializeField] Image uiImage;
    [SerializeField] TextMeshProUGUI uidialogue;
    [SerializeField] float panelWaitTime = 3f;
    [SerializeField] Slider loadingSlider;

    float timer;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        AssignToUI(i);
    }

    // Update is called once per frame
    void Update()
    {
        loadingSlider.value = timer;
        timer += Time.deltaTime;
        if(Input.anyKeyDown && timer>panelWaitTime)
        {
            i++;
            AssignToUI(i);
            timer = 0;
        }
    }
    void AssignToUI(int index)
    {
        if(index<panels.Length)
        {
            uiImage.sprite = panels[index].panelImage;
            uidialogue.text = panels[index].panelDialogue;
        }
        
    }
}
