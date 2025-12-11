using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class caseScript : MonoBehaviour
{
    string kasa ;
    
    public string kasaGirilenSifre;
    public TextMeshProUGUI sifreYazi;
    public GameObject alertYazi;
    public GameObject sifrePanel;
    public GameObject not1;
    public GameObject not1close;
    public GameObject kasaAcButton;
    public GameObject sifrePanelClose;
    public Button notEnv;



    public string firstChar;
    public string secondChar;
    public string thirdChar;
    public string fourthChar;

    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void panelAc(){
        sifrePanel.SetActive(true);
        sifrePanelClose.SetActive(true);
    }
    public void panelKapat(){
        sifrePanel.SetActive(false);
        sifrePanelClose.SetActive(false);

    }
    public void not1Ac(){
        not1.SetActive(true);
        not1close.SetActive(true);
        kasaGirilenSifre = " ";
    }
    public void not1Kapat(){
        not1.SetActive(false);
        not1close.SetActive(false);
    }
    
    void Update()
    {
    sifreYazi.text = kasaGirilenSifre;
    if(kasaGirilenSifre=="1881")
    {
        sifrePanel.SetActive(false);
        not1Ac();
        notEnv.interactable = true;

        Destroy(kasaAcButton);
    }
    else{
         if (kasaGirilenSifre.Length>=4)
            {   
                alertYazi.SetActive(true);
                kasaGirilenSifre = "";
            }
    }
   
    }

    public void buttonbir(){
        kasaGirilenSifre = kasaGirilenSifre + "1";
    }
    public void buttoniki(){
        kasaGirilenSifre = kasaGirilenSifre + "2";
    }
    public void buttonuc(){
        kasaGirilenSifre = kasaGirilenSifre + "3";
    }
    public void buttondort(){
        kasaGirilenSifre = kasaGirilenSifre + "4";
    }
    public void buttonbes(){
        kasaGirilenSifre = kasaGirilenSifre + "5";
    }
    public void buttonalti(){
        kasaGirilenSifre = kasaGirilenSifre + "6";
    }
    public void buttonyedi(){
        kasaGirilenSifre = kasaGirilenSifre + "7";
    }
    public void buttonsekiz(){
        kasaGirilenSifre = kasaGirilenSifre + "8";
    }
    public void buttondokuz(){
        kasaGirilenSifre = kasaGirilenSifre + "9";
    }
    public void buttonsifir(){
        kasaGirilenSifre = kasaGirilenSifre + "0";
    }
    
    
}
