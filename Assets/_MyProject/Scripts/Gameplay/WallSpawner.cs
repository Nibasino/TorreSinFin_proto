using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    [SerializeField] private Camera mainCamera = null;
    [SerializeField] private WallController WallPrefab = null;
    [SerializeField] private Transform target = null;

    void Start()
    {
        transform.position = new Vector3(0f, 6.85f, 0f); 
        mainCamera = Camera.main;
    }

    void Update()
    {

        if (transform.position.y - target.transform.position.y <= 6f)
        {
            Instantiate (WallPrefab, transform.position, Quaternion.identity);
            transform.position += new Vector3(0f, 2.15f, 0f);
        }
        
    }
}
