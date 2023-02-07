using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInput : MonoBehaviour
{
    private float speed = 9.0f;
    private CharacterController charController;
    private float gravity = -9.8f;
    // Start is called before the first frame update
    void Start()
    {
        charController = GetComponent<CharacterController> ();
    }

    // Update is called once per frame
    void Update()
    {
        float horizInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizInput, 0, vertInput);

        movement = Vector3.ClampMagnitude (movement, 1.0f);
       
        movement *= speed;
        movement.y = gravity;
        movement *= Time.deltaTime;
        movement = transform.TransformDirection (movement);
         
        charController.Move (movement);
    }
}
