using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    private Vector2 inputMovement;
    [SerializeField] private float movementSpeed = 20f;

    private void Start()
    {


    }

    private void FixedUpdate()
    {
        Movement();
        Rotation();
    }

    private void Movement()
    {
        Vector3 forward = inputMovement.y * movementSpeed * new Vector3(0,0,1);
        Vector3 lateral = inputMovement.x * movementSpeed * new Vector3(1,0,0);
        transform.position += forward;
        transform.position += lateral;
        
    }

    private void Rotation()
    {
        Vector3 rotation = new Vector3(inputMovement.x, 0.0f, inputMovement.y);
        transform.rotation = Quaternion.LookRotation(rotation);
    }

    public void ReadMovement(InputAction.CallbackContext input)
    {
        inputMovement = input.ReadValue<Vector2>();        
    }
}
