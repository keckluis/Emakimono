using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D PlayerRb;

    private Vector2 movmentDirection;
    public float maxSpeed;

    public Controls ActionMap;
    void Awake()
    {
        ActionMap = new Controls();
        PlayerRb = GetComponent<Rigidbody2D>();
 
    }

    private void OnEnable()
    {
        ActionMap.PlayerControls.Enable();
        ActionMap.PlayerControls.Movement.performed += ctx => movmentDirection = ctx.ReadValue<Vector2>();
    }

    private void OnDisable()
    {
        ActionMap.PlayerControls.Disable();
    }

    void Movement(InputAction.CallbackContext ctx)
    {
        Debug.Log("st"); 
        PlayerRb.velocity = ctx.ReadValue<Vector2>();
    }

    void Update()
    {
        PlayerRb.AddForce(movmentDirection * 50);
        if (PlayerRb.velocity.magnitude > maxSpeed)
        {
            PlayerRb.velocity = Vector3.ClampMagnitude(PlayerRb.velocity, maxSpeed);
            //ActionMap.PlayerControls.Movement.performed += ctx => movmentDirection = ctx.ReadValue<Vector2>();
        }
    }

}
