using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketLoad : MonoBehaviour
{


    public GameObject MarketBtn;
    public GameObject ButtonBuy;
    public GameObject Egal;
    public GameObject Plus;
    public GameObject FlaskOrange;
    public GameObject FlaskRed;
    public GameObject Crystal;


    private void FindObjects()
    {
        MarketBtn = GameObject.Find("MarketBtn");
        ButtonBuy = GameObject.Find("ButtonBuy");
        Egal = GameObject.Find("Egal");
        Plus = GameObject.Find("Plus");
        FlaskRed = GameObject.Find("FlaskRed");
        FlaskOrange = GameObject.Find("FlaskOrange");
        Crystal = GameObject.Find("Crystal");


    }

    private void InitObjects()
    {
        MarketBtn.SetActive(false);

        ButtonBuy.SetActive(false);

        Egal.SetActive(false);

        Plus.SetActive(false);

        FlaskOrange.SetActive(false);

        FlaskRed.SetActive(false);

        Crystal.SetActive(false);

    }


 public void Start()
    {
        FindObjects();
        InitObjects();
    }
   

   
}
