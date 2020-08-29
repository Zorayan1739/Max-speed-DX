using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject StagePanel;
    [SerializeField] GameObject BicyclePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void SelectXrHubDescription() 
    {
        menuPanel.SetActive(false);
        StagePanel.SetActive(true);
    }

    public void SelectUnityDescription() 
    {
        StagePanel.SetActive(false);
        BicyclePanel.SetActive(true);
    }
}
