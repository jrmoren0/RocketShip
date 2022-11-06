using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{

    public float thrust;
    public float turningThrust =1000f;

    private Rigidbody rocketBody;

    float mouseX;

    // Start is called before the first frame update
    void Start()
    {
        thrust = 1000f;
        turningThrust = 1000f;
        rocketBody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

        mouseX = Input.GetAxis("Mouse X");
        Debug.Log(transform.right);

        if (Input.GetKey(KeyCode.W))
        {
            rocketBody.AddForce(transform.forward * thrust * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rocketBody.AddForce(transform.forward * thrust * Time.deltaTime * -1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rocketBody.AddForce(transform.right * thrust * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rocketBody.AddForce(transform.right * thrust * Time.deltaTime * -1);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            rocketBody.AddForce(transform.up * thrust * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            rocketBody.AddForce(transform.up * thrust * Time.deltaTime * -1);
        }
        

        if (Input.GetMouseButton(1))
        {
            rocketBody.AddRelativeTorque(mouseX * transform.up * turningThrust * Time.deltaTime);

            Debug.Log(mouseX);
        }

        
    }
}
