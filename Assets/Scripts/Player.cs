using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;
    public float groundDrag;

    public float jumpForce;
    public float jumpCooldown;
    public float airMultiplier;
    bool readyToJump;

    [Header("Keybinds")]
    public KeyCode jumpKey = KeyCode.Space;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;

    public Transform orientation;

    private float horizontalInput;
    private float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    //Footsteps
    public AudioSource footstepSound;
    private float footstepTimer = 0f;
    private float cooldownFootsteps = 0.8f;

    // UI
    public DialogueUI DialogueUI => dialogueUI;
    public GameObject GameControlUI;
    [SerializeField]
    private float TimeBeforeDisablingGameControlUI = 15f;
    [SerializeField] private DialogueUI dialogueUI;

    // Objects to interact
    public IInteractable interactable { get; set; }

    // Objects that player can hold
    public GameObject battery;
    public GameObject ball;
    public GameObject wrench;
    public GameObject candy;
    public GameObject brokenToy;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

        readyToJump = true;

        Invoke("DisableGameControlsUI", TimeBeforeDisablingGameControlUI);
    }

    private void Update()
    {
        if (dialogueUI)
        {
            if (dialogueUI.isOpen) return;
        }

        // ground check
        RaycastHit hit;
        grounded = Physics.Raycast(transform.position, Vector3.down, out hit, playerHeight * 0.5f + 0.3f, whatIsGround);
        if (hit.collider)
        {
            Debug.Log(hit.collider.gameObject.name);
        }
        //grounded = rb.velocity.y == 0.0f;

        if (dialogueUI.isOpen)
        {
            return;
        }

        MyInput();
        SpeedControl();

        // handle drag
        if (grounded)
        {
            rb.drag = groundDrag;
        }
        else
        {
            rb.drag = 0;
        }

        // dialogue
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (interactable != null)
            {
                interactable.Interact(this);
            }
        }
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        if(Input.GetKey(jumpKey) && readyToJump && grounded)
        {
            readyToJump = false;

            Jump();

            Invoke(nameof(ResetJump), jumpCooldown);
        }
    }

    private void MovePlayer()
    {
        // calculate movement direction
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        if (grounded)
        {
            Debug.Log("Grounded");
            if (verticalInput != 0 || horizontalInput != 0)
            {
                Debug.Log("Move");
                rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
                
                footstepTimer -= Time.deltaTime;
                if (footstepTimer <= 0f)
                {
                    Debug.Log("footsteps");
                    footstepSound.Play();
                    footstepTimer = cooldownFootsteps;
                }
            }
        }
        else if (!grounded)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
        }
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        // limit velocity
        if (flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }

    private void Jump()
    {
        // reset y velocity
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        Debug.Log("Jump");
    }

    private void ResetJump()
    {
        readyToJump = true;
    }

    private void DisableGameControlsUI()
    {
        GameControlUI.SetActive(false);
    }
}

