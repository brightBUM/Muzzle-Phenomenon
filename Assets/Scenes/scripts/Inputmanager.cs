using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputmanager : MonoBehaviour
{
    [SerializeField] Movement movement;
    [SerializeField] mouselook mouselook;
    [SerializeField] shooting shooting;
    PlayerControls playercontrol;
    Vector2 move;
    Vector2 mouseval;
    // Start is called before the first frame update
    private void Awake()
    {
        playercontrol = new PlayerControls();
        playercontrol.Land.Hmovement.performed += ctq => move = ctq.ReadValue<Vector2>();
        playercontrol.Land.Jump.performed += _ => movement.onjumppressed();
        playercontrol.Land.Xmouse.performed += ctq => mouseval.x = ctq.ReadValue<float>();
        playercontrol.Land.Ymouse.performed += ctq => mouseval.y = ctq.ReadValue<float>();
        playercontrol.Land.Shoot.performed += _ => shooting.shootbullet();
        
    }
    private void OnEnable()
    {
        playercontrol.Enable();
    }
    private void OnDisable()
    {
        playercontrol.Disable();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.receiveinput(move);
        mouselook.mouseinput(mouseval);
    }
}
