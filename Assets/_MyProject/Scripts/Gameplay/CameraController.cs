using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   public Transform target;
   public Vector3 posOffset;
   public float smooth;
   public float targetVertical;
   private Vector3 NewCamPosition;
   Vector2 velocity;

   void Update()
   {
    targetVertical = target.position.y;
    NewCamPosition = new Vector3(0f, targetVertical, 0f);
   }

  
   private void LateUpdate()
    {        
        if (transform.position.y < target.position.y)
        {
            transform.position = Vector3.Lerp(transform.position, NewCamPosition + posOffset, smooth*Time.deltaTime);
        }
           
    }
       
   
}
