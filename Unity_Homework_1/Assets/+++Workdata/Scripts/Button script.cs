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
        panel1Button.onClick.AddListener(Panel2);
        panel2Button.onClick.AddListener(Panel1);
        
        panel2.SetActive(false);
        panel1.SetActive(true);
    }

    void Panel1()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
    }
    
    void Panel2()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }
}
