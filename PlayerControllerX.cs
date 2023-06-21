using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input, Vertical은 위, 아래
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate, forward = 0,0,1
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys, right = x축기준으로 돈다.
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
