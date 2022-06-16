using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip armSwingClip;
    [SerializeField] AudioClip punchClip;
    //[SerializeField] AudioClip[] punchClips;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PunchSfx()
    {
        audioSource.clip = punchClip;
        PlaySource();
    }
    public void ArmSwing()
    {
        audioSource.clip = armSwingClip;
        PlaySource();
    }
    void PlaySource()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
