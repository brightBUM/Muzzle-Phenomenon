using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
    float mouseX, mouseY;
    [SerializeField] private float verticalSENS = 5f;
    [SerializeField] private float horizontalSENS = 8f;
    [SerializeField] float CamXrotation;
    [SerializeField] float camXclamp = 85f;
    [SerializeField] Transform camref;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CamXrotation -= mouseY*Time.deltaTime;
        CamXrotation = Mathf.Clamp(CamXrotation, -camXclamp, camXclamp);
        camref.localRotation = Quaternion.Euler(CamXrotation,0,0);
        transform.Rotate(Vector3.up * mouseX*Time.deltaTime);
    }
    public void mouseinput(Vector2 mousein)
    {
        mouseX = mousein.x * verticalSENS;
        mouseY = mousein.y * horizontalSENS;
    }
}
