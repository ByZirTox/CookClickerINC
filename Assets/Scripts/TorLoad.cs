using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorLoad : MonoBehaviour
{

    public GameObject SwitchHome;
    public GameObject RunComputer;
    public GameObject TorLogo;
    public GameObject TorLoadLogo;
    public GameObject Point1;
    public GameObject Point2;
    public GameObject Point3;
  
  
private void FindObjects()
{
    SwitchHome = GameObject.Find("SwitchHome");
    RunComputer = GameObject.Find("RunComputer");
    TorLogo = GameObject.Find("TorLogo");
    TorLoadLogo = GameObject.Find("TorLoadLogo");
    Point1 = GameObject.Find("Point1");
    Point2 = GameObject.Find("Point2");
    Point3 = GameObject.Find("Point3");
    
}


    void Start()
    {

        FindObjects();    
       
         TorLogo.SetActive(false);
        
        TorLoadLogo.SetActive(false);
        
        Point1.SetActive(false);
        
        Point2.SetActive(false);
        
        Point3.SetActive(false);
        
      
    }

     
     IEnumerator LoadComputerCoroutine() {

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
        TorLoadLogo.SetActive(false);
        Point1.SetActive(false);
        Point2.SetActive(false);
        Point3.SetActive(false);
      }

public void LoadComputer(){
    StartCoroutine(LoadComputerCoroutine());
}

}

