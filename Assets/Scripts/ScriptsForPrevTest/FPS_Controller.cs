using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Controller : MonoBehaviour
{
    [SerializeField]
    private float _speed = 2f;
    private float _mouseSensation = 50f;
    private float _minCameraView = -70f, _maxCameraView = 80f;

    private CharacterController _characterController;
    public Camera _camera;
    private float xRotation = 0f;

    public UI_Management uiManagement;

    
    void Start()
    {
        _characterController = GetComponent<CharacterController>();

        if (_characterController == null)
        {
            Debug.Log("error");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        //get wasd
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = transform.forward * vertical + transform.right * horizontal;
        _characterController.Move(movement * Time.deltaTime * _speed);

        //get mouse
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensation * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensation * Time.deltaTime;

        xRotation -= mouseY;
        //clamp
        xRotation = Mathf.Clamp(xRotation, _minCameraView, _maxCameraView);

        _camera.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        transform.Rotate(Vector3.up * mouseX);


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "collider")
        {
            uiManagement._isMindPlaceCondition = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "collider")
        {
            uiManagement._isMindPlaceCondition = false;
        }
    }

}
