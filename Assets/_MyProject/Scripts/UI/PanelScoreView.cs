using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PanelScoreView : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isPlatformSpawnerAssigned = false;
    [SerializeField] private PlatformSpawner platformSpawner = null;
    [Space(20)] [SerializeField] private TextMeshProUGUI labelScore = null;
    [SerializeField] private Transform panelScore = null;


    private PlatformSpawner FindPlatformSpawner()
    {
        return FindObjectOfType<PlatformSpawner>();
    }
    void Start()
    {
        platformSpawner = platformSpawner == null ? FindPlatformSpawner() : platformSpawner;
        isPlatformSpawnerAssigned = platformSpawner != null;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPlatformSpawnerAssigned) return;

        if (platformSpawner.platformNumber > 0)
        {
            labelScore.text = (platformSpawner.platformNumber * 10).ToString("D4");
        }
        
    }

    private void OnGUI ()
    {
        

        
    }
}
