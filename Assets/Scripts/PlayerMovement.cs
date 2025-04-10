using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float speed = 50f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(-moveX, 0, -moveZ) * speed * Time.deltaTime);

    }
}

// public class PlayerMovement : MonoBehaviour
// {
//     [SerializeField] private float moveSpeed = 5f;
//     public Rigidbody2D body; 
//     private Vector3 moveInput;
    
//     public Animator animator;


//     void Start()
//     {
//         body = GetComponent<Rigidbody2D>();
//         animator = GetComponent<Animator>();
//     }

//     void Update() {
//         ProcessInputs();
//         Animate();
//     }

//     void FixedUpdate()
//     {
//         Move();
//     }

//     void ProcessInputs(){

//         float moveX = Input.GetAxisRaw("Horizontal");
//         float moveZ = Input.GetAxisRaw("Vertical");

//         moveInput = new Vector3(moveX,0,moveZ).normalized;
//     }

//     void Move(){

//         body.velocity= new Vector3(moveInput.x * moveSpeed ,0, moveInput.z * moveSpeed);
//     }

//     void Animate(){
//         animator.SetFloat("AnimMoveX", moveInput.x);
//         animator.SetFloat("AnimMoveY", moveInput.z);
//     }
//     // // Update is called once per frame
//     // void Update()
//     // {

        
//     //     body.velocity = moveInput * moveSpeed;
//     // }

//     // public void Move(InputAction.CallbackContext context)
//     // {
//     //     moveInput =context.ReadValue<Vector2>();  

//     // }
     
// }
