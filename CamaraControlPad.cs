#region Librerias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;
#endregion

namespace MoonPincho
{
	public class CamaraControlPad : MonoBehaviour 
	{
        public XboxController controllerInput;
        private const float Y_ANGLE_MIN = 0.0f;
        private const float Y_ANGLE_MAX = 20.0f;

        public Transform lookAt;
        public Transform camTransform;

        private Camera cam;

        private float distance = 10.0f;
        private float currentX = 0.0f;
        private float currentY = 0.0f;
        private float sensitivyX = 4.0f;
        private float sensitivyY = 1.0f;
        private static bool didQueryNumOfCtrlrs = false;

        private void Start()
        {
            camTransform = transform;
            cam = Camera.main;

            if (!didQueryNumOfCtrlrs)
            {
                didQueryNumOfCtrlrs = true;

                int queriedNumberOfCtrlrs = XCI.GetNumPluggedCtrlrs();
                if (queriedNumberOfCtrlrs == 1)
                {
                    Debug.Log("Only " + queriedNumberOfCtrlrs + " Xbox controller plugged in.");
                }
                else if (queriedNumberOfCtrlrs == 0)
                {
                    Debug.Log("No Xbox controllers plugged in!");
                }
                else
                {
                    Debug.Log(queriedNumberOfCtrlrs + " Xbox controllers plugged in.");
                }

                XCI.DEBUG_LogControllerNames();
            }
        }

        private void Update()
        {
            //currentX += Input.GetAxis("Mouse X");
            //currentY += Input.GetAxis("Mouse Y");

            currentX += XCI.GetAxis(XboxAxis.RightStickX, controllerInput);
            currentY += XCI.GetAxis(XboxAxis.RightStickY, controllerInput);

            currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
        }

        private void LateUpdate()
        {
            Vector3 dir = new Vector3(0, 0, -distance);
            Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
            camTransform.position = lookAt.position + rotation * dir;
            camTransform.LookAt(lookAt.position);
        }

    }
}