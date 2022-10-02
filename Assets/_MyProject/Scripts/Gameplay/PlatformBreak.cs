using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBreak : MonoBehaviour
{
     [SerializeField] public Camera mainCamera = null;
     [SerializeField] public DiddyController target = null;
     private bool isDiddyControllerAssigned = false;
     Collider collider;
     private float fallDelay = 1f;

    
    private DiddyController FindDiddyController()
    {
        return FindObjectOfType<DiddyController>();
    }
    
    void Start()
    {
        mainCamera = Camera.main;
        collider = GetComponent<Collider>();
        target = target == null ? FindDiddyController() : target;
        isDiddyControllerAssigned = target != null;

                
    }

    private void onCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Diddy"))
        {
            StartCoroutine(Break());
        }
    }

    private IEnumerator Break()
    {
        yield return new WaitForSeconds(fallDelay);
        collider.enabled = !collider.enabled;
    }

    // Update is called once per frame
    void Update()
    {
        var halfHeight = mainCamera.orthographicSize;
        // calculos de bounds
        var borderBottom = mainCamera.transform.position.y - halfHeight;

        if (transform.position.y < (borderBottom - 0.5f))
        {
            Destroy(gameObject);
        }
    }
}
