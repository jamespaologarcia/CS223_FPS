using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInput : MonoBehaviour
{
    private float speed = 9.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float vertInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Vector3 movement = new Vector3(horizInput, 0, vertInput);
        transform.Translate(movement);
    }
}
