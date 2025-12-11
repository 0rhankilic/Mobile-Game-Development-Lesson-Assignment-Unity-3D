using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private FixedJoystick joystick;
    [SerializeField] private FixedJoystick Camjoystick;
    
    [SerializeField] private Button jumpButton;    
    [SerializeField] private Button crouchButton;  
    [SerializeField] private Button runButton;     

    public Camera playerCamera;
    public static float walkSpeed = 6f;
    public float defaultWalkSpeed = 6f;  
    public float runSpeed = 9f;
    public float defaultRunSpeed = 9f;   
    public float jumpPower = 5f;
    public float gravity = 20f;
    public float lookSpeed = 2f;
    public float lookXLimit = 45f;
    public float defaultHeight = 2f;
    public float crouchHeight = -0.5f;
    public float crouchSpeed = 0f;

    private Vector3 moveDirection = Vector3.zero;
    private float rotationX = 0;
    private CharacterController characterController;
    
    private bool shouldJump = false;
    public static bool isCrouching = false;
    private bool isRunning = false;

    private bool canMove = true;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        
        defaultWalkSpeed = walkSpeed;
        defaultRunSpeed = runSpeed;
        
        if (jumpButton != null)
        {
            EventTrigger jumpTrigger = jumpButton.gameObject.AddComponent<EventTrigger>();
            
            EventTrigger.Entry pointerDown = new EventTrigger.Entry();
            pointerDown.eventID = EventTriggerType.PointerDown;
            pointerDown.callback.AddListener((data) => { shouldJump = true; });
            jumpTrigger.triggers.Add(pointerDown);
            
            EventTrigger.Entry pointerUp = new EventTrigger.Entry();
            pointerUp.eventID = EventTriggerType.PointerUp;
            pointerUp.callback.AddListener((data) => { shouldJump = false; });
            jumpTrigger.triggers.Add(pointerUp);
        }
        
        if (crouchButton != null)
        {
            EventTrigger crouchTrigger = crouchButton.gameObject.AddComponent<EventTrigger>();
            
            EventTrigger.Entry pointerDown = new EventTrigger.Entry();
            pointerDown.eventID = EventTriggerType.PointerDown;
            pointerDown.callback.AddListener((data) => { OnCrouchButtonDown(); });
            crouchTrigger.triggers.Add(pointerDown);
            
            EventTrigger.Entry pointerUp = new EventTrigger.Entry();
            pointerUp.eventID = EventTriggerType.PointerUp;
            pointerUp.callback.AddListener((data) => { OnCrouchButtonUp(); });
            crouchTrigger.triggers.Add(pointerUp);
        }
        
        if (runButton != null)
        {
            EventTrigger runTrigger = runButton.gameObject.AddComponent<EventTrigger>();
            
            EventTrigger.Entry pointerDown = new EventTrigger.Entry();
            pointerDown.eventID = EventTriggerType.PointerDown;
            pointerDown.callback.AddListener((data) => { OnRunButtonDown(); });
            runTrigger.triggers.Add(pointerDown);
            
            EventTrigger.Entry pointerUp = new EventTrigger.Entry();
            pointerUp.eventID = EventTriggerType.PointerUp;
            pointerUp.callback.AddListener((data) => { OnRunButtonUp(); });
            runTrigger.triggers.Add(pointerUp);
        }
    }
    
    public void OnCrouchButtonDown()
    {
        isCrouching = true;
    }
    
    public void OnCrouchButtonUp()
    {
        isCrouching = false;
    }
    
    public void OnRunButtonDown()
    {
        isRunning = true;
    }
    
    public void OnRunButtonUp()
    {
        isRunning = false;
    }

    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        bool runningInput = isRunning || Input.GetKey(KeyCode.LeftShift);
        float curSpeedX = canMove ? (runningInput ? runSpeed : walkSpeed) * joystick.Vertical : 0;
        float curSpeedY = canMove ? (runningInput ? runSpeed : walkSpeed) * joystick.Horizontal : 0;
        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);

        if (shouldJump && canMove && characterController.isGrounded)
        {
            moveDirection.y = jumpPower;
        }
        else if (Input.GetButton("Jump") && canMove && characterController.isGrounded)
        {
            moveDirection.y = jumpPower;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }

        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        if ((isCrouching || Input.GetKey(KeyCode.R)) && canMove)
        {
            characterController.height = crouchHeight;
            float crouchMovementSpeed = defaultWalkSpeed * 0.5f; 
            if (crouchSpeed <= 0)
            {
                walkSpeed = crouchMovementSpeed;
                runSpeed = crouchMovementSpeed;
            }
            else
            {
                walkSpeed = crouchSpeed;
                runSpeed = crouchSpeed;
            }
        }
        else
        {
            characterController.height = defaultHeight;
            walkSpeed = defaultWalkSpeed;
            runSpeed = defaultRunSpeed;
        }

        characterController.Move(moveDirection * Time.deltaTime);

        if (canMove)
        {
            rotationX += -Camjoystick.Vertical * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Camjoystick.Horizontal * lookSpeed, 0);
            
        }
    }
}