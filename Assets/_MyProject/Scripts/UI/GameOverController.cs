using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    [SerializeField] private Camera mainCamera = null;
    [SerializeField] private Transform target = null;
    [SerializeField] private GameObject panel = null;
    [SerializeField] private GameObject panelBG = null;
    [SerializeField] private GameObject botonJugar = null;
    [SerializeField] private GameObject botonVolverA = null;
    [SerializeField] private GameObject botonVolverB = null;
   
    void Start()
    {
       panel.SetActive(false);
       panelBG.SetActive(false);
       botonJugar.SetActive(false);
       botonVolverA.SetActive(false);
       botonVolverB.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        var halfHeight = mainCamera.orthographicSize;
        var borderBottom = mainCamera.transform.position.y - halfHeight;
        
        if (target.transform.position.y <= (borderBottom - 3))
        {
            panel.SetActive(true);
            panelBG.SetActive(true);
            botonJugar.SetActive(true);
            botonVolverA.SetActive(true);
            botonVolverB.SetActive(false);
        }
        
    }
}
