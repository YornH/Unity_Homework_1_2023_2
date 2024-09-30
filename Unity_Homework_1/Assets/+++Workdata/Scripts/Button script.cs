using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttonscript : MonoBehaviour
{
    [SerializeField] private Button panel1Button;
    [SerializeField] private Button panel2Button;

    [SerializeField] private GameObject panel1;
    [SerializeField] private GameObject panel2;
    void Start()
    {
        //tells the buttons what methods to execute when starting the gmae
        panel1Button.onClick.AddListener(Panel2);
        panel2Button.onClick.AddListener(Panel1);
        
        
        //activates panel 1 and deactivates panel2
        panel2.SetActive(false);
        panel1.SetActive(true);
    }

    
    //this method activates Panel 1 and deactivates Panel 2
    void Panel1()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
    }
    
    
    //this method activates Panel 2 and deactivates Panel 1
    void Panel2()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }
}
