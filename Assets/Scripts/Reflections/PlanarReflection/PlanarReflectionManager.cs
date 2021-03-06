﻿using System;
using UnityEngine;

namespace Reflections.PlanarReflection
{
    public class PlanarReflectionManager : MonoBehaviour
    {
        public float reflectionRange = 300f;
        public LayerMask layerMask;
        
        private Camera reflectionCam;
        private Camera cam;

        public GameObject reflectionPlane;

        private void Start()
        {
            GameObject reflectionCameraGo = new GameObject("ReflectionCamera");
            reflectionCam = reflectionCameraGo.AddComponent<Camera>();
            reflectionCam.enabled = false;
            
            cam = Camera.main;
        }

        private void Update()
        {
            RenderReflection();
        }

        void RenderReflection()
        {
            reflectionCam.CopyFrom(cam);

            Vector3 reflectionPlaneNormal;
            Ray ray = new Ray(transform.position, reflectionPlane.transform.position - transform.position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, reflectionRange, layerMask))
            {
                reflectionPlaneNormal = hit.normal;
            }
            else
            {
                Debug.LogError("COULDN'T FIND SURFACE TO REFLECT ON");
            }
            
            //TODO: figure out where to put Vector3.Reflect
            Vector3 cameraDirectionWS = cam.transform.forward;
            Vector3 cameraUpWS = cam.transform.up;
            Vector3 cameraPos = cam.transform.position;
            
            //Transform the vectors to the floor's space
            Vector3 cameraDirectionPlaneSpace = reflectionPlane.transform.InverseTransformDirection(cameraDirectionWS);
            Vector3 cameraUpPlaneSpace = reflectionPlane.transform.InverseTransformDirection(cameraUpWS);
            Vector3 cameraPositionPlaneSpace = reflectionPlane.transform.InverseTransformDirection(cameraPos);
            
            //Mirror the vectors
            cameraDirectionPlaneSpace.y *= -1.0f;
            cameraUpPlaneSpace.y *= -1.0f;
            cameraPositionPlaneSpace.y *= 1.0f;
            
            //Transform vectors back to world space
            cameraDirectionWS = reflectionPlane.transform.TransformDirection(cameraDirectionPlaneSpace);
            cameraUpWS = reflectionPlane.transform.TransformDirection(cameraUpPlaneSpace);
            cameraPos = reflectionPlane.transform.TransformPoint(cameraPositionPlaneSpace);
            
            //Set Reflection camera position and rotation
            reflectionCam.transform.position = cameraPos;
            reflectionCam.transform.LookAt(cameraPos + cameraDirectionWS, cameraUpWS);
            
        }
        
    }
}