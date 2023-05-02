using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBurger : MonoBehaviour
{

public GameObject ButtonFlaksOrange;
public GameObject ButtonFlaksRed;

    public GameObject Burger;
    public GameObject BackGroundMenu;
    public GameObject FlasksOrange;
    public GameObject FlasksRed;
    public GameObject ExitMenu;



    void start()
    {

        ButtonFlaksOrange = GameObject.FindWithTag("Button - FlasksOrange");
        ButtonFlaksRed = GameObject.FindWithTag("Button - FlasksRed");
        Burger = GameObject.FindWithTag("Burger");
        BackGroundMenu = GameObject.FindWithTag("BackGroundMenu");
        FlasksRed = GameObject.FindWithTag("FlasksRed");
        FlasksOrange = GameObject.FindWithTag("FlasksOrange");
        ExitMenu = GameObject.FindWithTag("ExitMenu");
    }

    public void isVisibleMenu()
    {

        Burger.SetActive(false);
        BackGroundMenu.SetActive(true);
        FlasksRed.SetActive(true);
        FlasksOrange.SetActive(true);
        ExitMenu.SetActive(true);


    }

        public void isNotVisibleMenu()
        {

            Burger.SetActive(true);
            BackGroundMenu.SetActive(false);
            FlasksRed.SetActive(false);
            FlasksOrange.SetActive(false);
            ExitMenu.SetActive(false);


        }

public void isVisibleFlasksOrange() {
ButtonFlaksOrange.SetActive(true);
ButtonFlaksRed.SetActive(false);
}

public void isVisibleFlasksRed() {


ButtonFlaksOrange.SetActive(false);
ButtonFlaksRed.SetActive(true);
}
    }
