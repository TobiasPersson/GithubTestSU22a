using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerMovement : MonoBehaviour
{
    public float speed;
    public Vector2 mouseSensitivity;
    Rigidbody rb;
    Transform camPivot;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        camPivot = transform.GetChild(0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horz = Input.GetAxisRaw("Horizontal");
        float vert = Input.GetAxisRaw("Vertical");

        float mouseHorz = Input.GetAxis("Mouse X");
        float mouseVert = Input.GetAxis("Mouse Y");

       // rb.velocity =  Vector3.Scale(transform.forward, new Vector3( horz * speed * Time.deltaTime, rb.velocity.y, vert * speed * Time.deltaTime));

        rb.MovePosition(rb.position + transform.forward * speed * vert * Time.fixedDeltaTime);
        rb.MovePosition(rb.position + transform.right * speed * horz * Time.fixedDeltaTime);

        transform.RotateAround(transform.position, transform.up, mouseHorz * mouseSensitivity.x * Time.deltaTime);
        camPivot.RotateAround(camPivot.position, camPivot.right, -mouseVert * mouseSensitivity.y * Time.deltaTime);
    }
}
