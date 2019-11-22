using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace parte1
{
    public class CharControler : MonoBehaviour
    {
        Transform tr;
        Rigidbody rg;
        Animator anim;

        public Transform CameraShoulder;
        public Transform CameraHolder;
        private Transform cam;

        private float rotY;
        private float rotX;

        public float speed = 6;
        public float rotationSpeed = 25;
        public float minAngle = -70;
        public float maxAngle = 90;
        public float cameraSpeed = 24;


        // Start is called before the first frame update
        void Start()
        {
            tr = this.transform;
            rg = GetComponent<Rigidbody>();
            anim = GetComponentInChildren<Animator>();
            cam = Camera.main.transform;



        }

        // Update is called once per frame
        void Update()
        {

            playerControl();
            CameraControl();
            AnimControl();

        }


        //control de jugador
        private void playerControl()
        {

            Vector3 sp = rg.velocity;

            float deltaX = Input.GetAxis("Horizontal");
            float deltaZ = Input.GetAxis("Vertical");
            float deltaT = Time.deltaTime;

            Vector3 side = speed * deltaX * deltaT * tr.right;
            Vector3 forward = speed * deltaZ * deltaT * tr.forward;

            Vector3 endSpeed = side + forward;

            rg.velocity = endSpeed;

        }

        //control de la camara
        private void CameraControl()
        {
            //giro de la camara con el movimiento del raton
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");
            float deltaT = Time.deltaTime;


            rotY += mouseX * deltaT * rotationSpeed;
            float xrot = mouseX * deltaT * deltaT * rotationSpeed;

            tr.Rotate(0, xrot, 0);
            rotY = Mathf.Clamp(rotY, minAngle, maxAngle);

            Quaternion localRotation = Quaternion.Euler(-rotY, 0, 0);
            CameraShoulder.localRotation = localRotation;
            cam.position = Vector3.Lerp(cam.position, CameraHolder.position, cameraSpeed * deltaT);
            cam.rotation = Quaternion.Lerp(cam.rotation, CameraHolder.rotation, cameraSpeed * deltaT);
        }

        //control de animaciones
        private void AnimControl()
        {
           
        }



    }

}
