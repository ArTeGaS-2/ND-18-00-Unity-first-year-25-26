using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject cameraInGame;

    [SerializeField] float moveSpeed = 6f;
    [SerializeField] float jumpForce = 6f;
    [SerializeField] float groundCheckDistance = 0.6f;

    Rigidbody rb;
    bool isGrounded;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();   
    } 
    void Update()
    {
        isGrounded = Physics.Raycast(
            transform.position,
            Vector3.down,
            groundCheckDistance);
        if (Input.GetKeyDown(KeyCode.W) ||
            Input.GetKeyDown(KeyCode.UpArrow) ||
            Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                Vector3 velocity = rb.velocity;
                velocity.y = 0f;
                rb.velocity = velocity;
                rb.AddForce(Vector3.up * jumpForce,
                    ForceMode.VelocityChange);
            }
            
        }
    }
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector3 velocity = rb.velocity;
        velocity.x = horizontal * moveSpeed;
        rb.velocity = velocity;

        if (transform.position.y <= -15f)
        {
            SceneManager.LoadScene("RedBall");
        }
    }
    private void LateUpdate()
    {
        cameraInGame.transform.position = new Vector3(
            transform.position.x,
            cameraInGame.transform.position.y,
            transform.position.z - 10f);

        cameraInGame.transform.eulerAngles = Vector3.zero;
    }
}
