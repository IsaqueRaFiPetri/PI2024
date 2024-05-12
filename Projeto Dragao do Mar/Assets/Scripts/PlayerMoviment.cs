using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public Rigidbody body;
    public Transform cam;       //camera
    public float speed, maxSpeed, drag;
    public float rotationSpeed;
    bool left, forward, backward, right;

    void Update()
    {
        LimitVelocity();
        HandleInput();
        HandleDrag();
    }

    void FixedUpdate()
    {
        HandleMovement();
        Handlerotation();
    }

    void Handlerotation()
    {
        if ((new Vector2(body.velocity.x, body.velocity.z)).magnitude > .1f)
        {
            Vector3 horizontalDir = new Vector3(body.velocity.x, 0, body.velocity.z);
            Quaternion rotation = Quaternion.LookRotation(horizontalDir, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, rotationSpeed);
        }
    }

    void HandleDrag()
    { 
        body.velocity = new Vector3 (body.velocity.x, 0, body.velocity.z) / (1+drag/100) + new Vector3 (0, body.velocity.y, 0);
    }

    void LimitVelocity()
    {
        Vector3 horizontalVelocity = new Vector3(body.velocity.x, 9, body.velocity.z);
        if(horizontalVelocity.magnitude > maxSpeed)
        {
            Vector3 limitedVelocity = horizontalVelocity.normalized * maxSpeed;
            body.velocity = new Vector3(limitedVelocity.x, body.velocity.y, limitedVelocity.z);
        }
    }

    void HandleMovement()
    {
        Quaternion dir = Quaternion.Euler(0f, cam.rotation.eulerAngles.y, 0f);

        if (left)
        {
            body.AddForce(dir * Vector3.left * speed);
            left = false;
        }
        if (forward)
        {
            body.AddForce(dir * Vector3.forward * speed);
            forward = false;
        }
        if (backward)
        {
            body.AddForce(dir * Vector3.back * speed);
            backward = false;
        }
        if (right)
        {
            body.AddForce(dir * Vector3.right * speed);
            right = false;
        }
    }

    void HandleInput()
    {
        if (Input.GetKey(KeyCode.A))
        {
            left = true;
        }
        if (Input.GetKey(KeyCode.W))
        {
            forward = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            backward = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            right = true;
        }
    }
}
//https://www.youtube.com/watch?v=eJPD2Os9leI