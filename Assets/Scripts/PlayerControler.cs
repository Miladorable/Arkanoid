using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControler : MonoBehaviour
{
    private float direction;
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private Rigidbody2D rigidbodyControl;

    public void Movement(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<float>();
    }

    private void Update()
    {
        transform.position += Vector3.right * direction * speed * Time.deltaTime;

    }
}
