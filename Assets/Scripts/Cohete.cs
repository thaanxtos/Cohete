using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class Cohete : MonoBehaviour
{
    Rigidbody rb;
    PlayerInput input;
    public int fuerzaAccel;
    public int grav;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        input = GetComponent<PlayerInput>();
    }


    void Update()
    {
        InputAction moveUp = input.actions["Jump"];

        if (moveUp.IsPressed())
        {
            OnMoveUp();
        }
        else
        {
            rb.AddForce(grav * Time.deltaTime * Vector3.down);
        }
    }

    void OnMoveUp()
    {
        rb.AddForce(transform.up * (fuerzaAccel - grav) * Time.deltaTime);
    }

}
