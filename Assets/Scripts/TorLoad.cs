using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TorLoad : MonoBehaviour
{
    // Variables liées au chargement de l'ordinateur
    public GameObject SwitchHome;
    public GameObject RunComputer;
    public GameObject TorLogo;
    public GameObject TorLoadLogo;
    public GameObject Point1;
    public GameObject Point2;
    public GameObject Point3;
    public GameObject Exit;
    public GameObject BourseBtn;
    public GameObject MarketBtn;
    public GameObject BitcoinBtn;

    // Variables liées au marché
    public GameObject ButtonBuy;
    public GameObject Egal;
    public GameObject Plus;
    public GameObject FlaskOrange;
    public GameObject FlaskRed;
    public GameObject Crystal;
    private Image MarketBtnImage;



    // Variables liées a la bourse

    private Image BourseBtnImage;



    // Variables liées au bitcoin

    private Image BitcoinBtnImage;



    private void FindObjects()
    {
        // Trouver les objets liés au chargement de l'ordinateur
        SwitchHome = GameObject.Find("SwitchHome");
        RunComputer = GameObject.Find("RunComputer");
        TorLogo = GameObject.Find("TorLogo");
        TorLoadLogo = GameObject.Find("TorLoadLogo");
        Point1 = GameObject.Find("Point1");
        Point2 = GameObject.Find("Point2");
        Point3 = GameObject.Find("Point3");
        Exit = GameObject.Find("Exit");


        // Trouver les application du pc
        MarketBtn = GameObject.Find("MarketBtn");
        BourseBtn = GameObject.Find("BourseBtn");
        BitcoinBtn = GameObject.Find("BitcoinBtn");


        // Trouver les objets liés au marché
        ButtonBuy = GameObject.Find("ButtonBuy");
        Egal = GameObject.Find("Egal");
        Plus = GameObject.Find("Plus");
        FlaskRed = GameObject.Find("FlaskRed");
        FlaskOrange = GameObject.Find("FlaskOrange");
        Crystal = GameObject.Find("Crystal");
    }

    private void InitObjects()
    {
        // Initialiser les objets liés au chargement de l'ordinateur
        TorLogo.SetActive(false);
        TorLoadLogo.SetActive(false);
        Point1.SetActive(false);
        Point2.SetActive(false);
        Point3.SetActive(false);
        Exit.SetActive(false);
        BourseBtn.SetActive(false);
        MarketBtn.SetActive(false);
        BitcoinBtn.SetActive(false);

        // Initialiser les objets liés au marché

        ButtonBuy.SetActive(false);
        Egal.SetActive(false);
        Plus.SetActive(false);
        FlaskOrange.SetActive(false);
        FlaskRed.SetActive(false);
        Crystal.SetActive(false);
    }

    void Start()
    {
        BourseBtnImage = BourseBtn.GetComponent<Image>();
        MarketBtnImage = MarketBtn.GetComponent<Image>();
        BitcoinBtnImage = BitcoinBtn.GetComponent<Image>();
        FindObjects();
        InitObjects();
    }

    IEnumerator LoadComputerCoroutine()
    {
        // Animation de chargement de l'ordinateur
        RunComputer.SetActive(false);
        SwitchHome.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        TorLoadLogo.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Point1.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Point2.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Point3.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        TorLogo.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        TorLoadLogo.SetActive(false);
        Point1.SetActive(false);
        Point2.SetActive(false);
        Point3.SetActive(false);
        Exit.SetActive(true);
        BourseBtn.SetActive(true);
        MarketBtn.SetActive(true);
        BitcoinBtn.SetActive(true);
    }

    public void LoadComputer()
    {
        StartCoroutine(LoadComputerCoroutine());
    }

    public void ShowBourseBtn()
    {
        BourseBtnImage.enabled = true;
    }

    // Pour désactiver l'image  de MarketBtn
    public void HideBourseBtn()
    {
        BourseBtnImage.enabled = false;
    }

    public void ShowMarketBtn()
    {
        MarketBtnImage.enabled = true;
    }

    // Pour désactiver l'image  de MarketBtn
    public void HideMarketBtn()
    {
        MarketBtnImage.enabled = false;
    }



    public void ShowBitcoinBtn()
    {
        BitcoinBtnImage.enabled = true;
    }

    // Pour désactiver l'image  de MarketBtn
    public void HideBitcoinBtn()
    {
        BitcoinBtnImage.enabled = false;
    }


    public void MarketPress()
    {
        HideBourseBtn();
        HideMarketBtn();
        HideBitcoinBtn();
        ButtonBuy.SetActive(true);

        Egal.SetActive(true);

        Plus.SetActive(true);

        FlaskOrange.SetActive(true);

        FlaskRed.SetActive(true);

        Crystal.SetActive(true);

    }

    public void ReturnMarketPress()
    {
        ButtonBuy.SetActive(false);

        Egal.SetActive(false);

        Plus.SetActive(false);

        FlaskOrange.SetActive(false);

        FlaskRed.SetActive(false);

        Crystal.SetActive(false);

        ShowBourseBtn();
        ShowMarketBtn();
        ShowBitcoinBtn();
    }




}

