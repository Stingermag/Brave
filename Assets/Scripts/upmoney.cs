using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upmoney : MonoBehaviour
{
    // Start is called before the first frame update
    public Text TextPr;
    public Text TextName;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int DayNomber = PlayerPrefs.GetInt("money");


        TextPr.text = "У вас "+ DayNomber;
        TextName.text = " " + PlayerPrefs.GetString("namepla");
    } 
}
