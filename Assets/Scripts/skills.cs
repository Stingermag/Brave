using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skills : MonoBehaviour
{
    public GameObject slill1;
    public GameObject slill2;
    public GameObject slill3;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("upshot") == 1)
        {
            slill1.SetActive(true);
        }
        if (PlayerPrefs.GetInt("upshot") == 0)
        {
            slill1.SetActive(false);
        }


        if (PlayerPrefs.GetInt("uphp") == 1)
        {
            slill2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("uphp") == 0)
        {
            slill2.SetActive(false);
        }

       
    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerPrefs.GetInt("bablact") == 0 && PlayerPrefs.GetInt("babl") == 1)
        {
            slill3.SetActive(true);
        }
        if (PlayerPrefs.GetInt("bablact") == 1 && PlayerPrefs.GetInt("babl") == 1)
        {
            slill3.SetActive(false);
        }
    }
    public void shop()
    {
        PlayerPrefs.SetInt("level", Application.loadedLevel);
        Application.LoadLevel("shop");
    }
   
}
