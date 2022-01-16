using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_move : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed = 6f;
    [SerializeField] private float jumpforce = 7f;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(verticalInput * speed, rb.velocity.y, horizontalInput * speed);

        if (IsGrounded() && Input.GetButtonDown("Jump"))
        {
            Jump();
        
        }

       
        
     
        bool IsGrounded()
        {
           return  Physics.CheckSphere(groundCheck.position, .1f, ground);
        
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyHead"))
        {

            Destroy(collision.transform.parent.gameObject);
            Jump();


        }
    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpforce, rb.velocity.z);
    }
    void reload()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    void Die()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Player_move>().enabled = false;
        Invoke(nameof(reload), 1f);
    }
}
