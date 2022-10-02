using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    [SerializeField] public Camera mainCamera = null;
    
    void Start()
    {
        mainCamera = Camera.main;
        
    }

    // Update is called once per frame
    void Update()
    {
        var halfHeight = mainCamera.orthographicSize;
        // calculos de bounds
        var borderBottom = mainCamera.transform.position.y - halfHeight;

        if (transform.position.y < (borderBottom - 3))
        {
            Destroy(gameObject);
        }
    }

}
