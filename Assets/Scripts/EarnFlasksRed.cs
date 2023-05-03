using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EarnFlasksRed : MonoBehaviour
{
    private int flasksRed;
    [SerializeField] private int flasksRedMultiplier;
    [SerializeField] private TMP_Text flasksRedText;
    [SerializeField] private RectTransform _buttonPosition;

    void Start()
    {

        if (PlayerPrefs.HasKey("flasksRed"))
        {
            flasksRed = PlayerPrefs.GetInt("flasksRed");
            flasksRedText.text = flasksRed.ToString();
        }
        
           
        
    }

   public void EarnFlasks()
{
  
        flasksRed += flasksRedMultiplier;
    PlayerPrefs.SetInt("flasksRed", flasksRed);
    flasksRedText.text = flasksRed.ToString();
}

}
