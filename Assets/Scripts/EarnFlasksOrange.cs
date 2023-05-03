using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EarnFlasksOrange : MonoBehaviour
{
    private int flasksOrange;
    [SerializeField] private int flasksOrangeMultiplier;
    [SerializeField] private TMP_Text flasksOrangeText;
    [SerializeField] private RectTransform _buttonPosition;

    void Start()
    {

        if (PlayerPrefs.HasKey("flasksOrange"))
        {
            flasksOrange = PlayerPrefs.GetInt("flasksOrange");
            flasksOrangeText.text = flasksOrange.ToString();
        }
        
           
        
    }

   public void EarnFlasks()
{
      
   flasksOrange += flasksOrangeMultiplier;
    PlayerPrefs.SetInt("flasksOrange", flasksOrange);
    flasksOrangeText.text = flasksOrange.ToString();
}

}
