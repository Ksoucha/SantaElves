using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensX = 200;
    public float sensY = 200;

    public Transform orientation;

    float xRotation;
    float yRotation;

    public float interactionDistance = 30f;
    new Camera camera;

    // private IInteractable interactable;
    [SerializeField]
    private Player player;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        camera = GetComponent<Camera>();
        if (player == null )
        {
            player = GetComponent<Player>();
        }
    }

    void Update()
    {
        if (PlayerSettings.instance != null)
        {
            sensX = PlayerSettings.instance.mouseSensitivity;
            sensY = PlayerSettings.instance.mouseSensitivity;
        }

        // get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // rotate cam and orientation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }

    private void FixedUpdate()
    {
        RaycastHit hitInfo;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hitInfo, interactionDistance))
        {
            IInteractable interactableObject = hitInfo.collider.gameObject.GetComponent<IInteractable>();
            if (interactableObject != null)
            {
                if (player.interactable == null)
                {
                    player.interactable = interactableObject;
                }
                else if (player.interactable != interactableObject)
                {
                    player.interactable = interactableObject;
                }
            }
            else if (interactableObject == null && player.interactable != null)
            {
                player.interactable = null;
            }
        }
        else
        {
            Debug.DrawLine(camera.transform.position, camera.transform.position + (camera.transform.forward) * interactionDistance, Color.white);
        }
    }
}
