using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private float lateralMin = -6f;
    [SerializeField] private float lateralMax = 6f;
    [SerializeField] private Camera mainCamera = null;
    [SerializeField] private PlatformBasic PlatformBasicPrefab = null;
    [SerializeField] private PlatformBreak PlatformBreakPrefab = null;
    [SerializeField] private PlatformIce PlatformIcePrefab = null;
    [SerializeField] private PlatformCloud PlatformCloudPrefab = null;
    [SerializeField] private Transform target = null;

    public int platformNumber = 0;

    void Start()
    {
        transform.position = new Vector3(0f, -4.2f, 0f); 
        mainCamera = Camera.main;
        platformNumber = -4;
    }

    void Update()
    {

        if (transform.position.y - target.transform.position.y <= 10f)
        {
            if (platformNumber >= -3 && platformNumber < 48)
            {
                Instantiate (PlatformBasicPrefab, transform.position, Quaternion.identity);
                transform.position = new Vector3(Random.Range(lateralMin, lateralMax), transform.position.y + 4f, 0f);
            }

            else if (platformNumber >= 48 && platformNumber < 98)
            {
                Instantiate (PlatformBreakPrefab, transform.position, Quaternion.identity);
                transform.position = new Vector3(Random.Range(lateralMin, lateralMax), transform.position.y + 4f, 0f);
            }

            else if (platformNumber >= 98 && platformNumber < 148)
            {
                Instantiate (PlatformIcePrefab, transform.position, Quaternion.identity);
                transform.position = new Vector3(Random.Range(lateralMin, lateralMax), transform.position.y + 4f, 0f);                
            }

            else if (platformNumber >= 148)
            {
                Instantiate (PlatformCloudPrefab, transform.position, Quaternion.identity);
                transform.position = new Vector3(Random.Range(lateralMin, lateralMax), transform.position.y + 4f, 0f);
            }


            platformNumber += 1;
            
        }
        
    }

    void LateUpdate()
    {

    }

    
}
