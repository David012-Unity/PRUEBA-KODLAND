using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

 public float sensitivity = 100f;
    public Transform playerBody;

    float xRotation = 0f;
     private Rigidbody rb;
    private bool isGrounded;

    [SerializeField] float speedPlayer;

    float currentSpeed = 10f;
    Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        direction = new Vector3(horizontal, 0f, vertical);
        direction = transform.TransformDirection(direction);
        // transform.Translate(new Vector3(horizontal, 0, vertical) * speedPlayer * Time.deltaTime);






    }
    void FixedUpdate()
    {
        rb.MovePosition(transform.position + direction * currentSpeed * Time.deltaTime);
    }

    void OnCollisionStay(Collision collision)
    {
        // Detectar si está tocando el suelo (puedes mejorar con tags o layers)
        
            isGrounded = true;
        
    }

    void OnCollisionExit(Collision collision)
    {
      
            isGrounded = false;
        

  
    
}
}