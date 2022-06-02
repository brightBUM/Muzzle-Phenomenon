using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Vector2 move;
    Vector3 horizontalinput;
    Vector3 Verticalinput;
    [SerializeField] CharacterController control;
    [SerializeField]float movespeed = 5f;
    [SerializeField] float gravity = -30f;
    bool jump = false;
    [SerializeField]bool isgrounded = false;
    [SerializeField]LayerMask groundlayer;
    [SerializeField] Transform groundpos;
    [SerializeField] float groundval = 0.1f;
    [SerializeField] float Jumpforce;
    //[SerializeField] Animator anim;
    public static Movement instance;

    private void Awake()
    {
        if (instance != this && instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isgrounded = Physics.CheckSphere(transform.position, groundval, groundlayer);
        if(isgrounded)
        {
            Verticalinput.y = 0;
        }
        if(isgrounded && jump)
        {
            Verticalinput.y = Mathf.Sqrt(-2 * gravity * Jumpforce);
            jump = false;
        }
        Verticalinput.y += gravity * Time.deltaTime;
        //if (move != Vector2.zero)
        //{
        //    anim.SetBool("move", true);
        //}
        //else
        //{
        //    anim.SetBool("move", false);

        //}
        horizontalinput = transform.right * move.x + transform.forward * move.y;
        control.Move(horizontalinput*movespeed*Time.deltaTime);
        control.Move(Verticalinput * Time.deltaTime);
    }
    public void receiveinput(Vector2 move)
    {
        this.move = move;
    }
    public void onjumppressed()
    {
        jump = true;
    }

}
