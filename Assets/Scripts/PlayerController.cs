using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;

    private Rigidbody rb;
    private float horizInput;
    private float vertInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        horizInput = Input.GetAxis("Horizontal");
        vertInput = Input.GetAxis("Vertical");
    }
    private void FixedUpLadate()
    {
        Vector3 movement = new Vector3(horizInput, 0, vertInput)  * Time.deltaTime * speed * 100;
        rb.velocity = movement;

    }

}