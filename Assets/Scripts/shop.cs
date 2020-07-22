using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    public Button lvl1;
    public Button lvl2;
    public Button lvl3;
    public Button lvl4;
    public Button lvl5;



    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("upshot") == 1)
        {
            lvl1.interactable = false;
            lvl4.interactable = true;
            lvl5.interactable = true;
        }
        if (PlayerPrefs.GetInt("upshot") == 0)
        {
           
            lvl4.interactable = false;
            lvl5.interactable = false;
        }

        if (PlayerPrefs.GetInt("uphp") == 1)
        {
            lvl2.interactable = false;
        }
        if (PlayerPrefs.GetInt("babl") == 1)
        {
            lvl3.interactable = false;
        }
        if (PlayerPrefs.GetInt("lazer") == 1)
        {
            lvl4.interactable = false;
        }
        if (PlayerPrefs.GetInt("speed") == 1)
        {
            lvl5.interactable = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NewGame()
    {
        Application.LoadLevel(PlayerPrefs.GetInt("level"));
    }

    public void upshot()
    {
        if (PlayerPrefs.GetInt("money") >= 150)
        {
            PlayerPrefs.SetInt("upshot", 1);
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 150);
            PlayerPrefs.Save();
            lvl1.interactable = false;

            lvl5.interactable = true;
            lvl4.interactable = true;

        }
    }

    public void uphp()
    {
        if (PlayerPrefs.GetInt("money") >= 50)
        {
            PlayerPrefs.SetInt("uphp", 1);
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 50);
            PlayerPrefs.Save();
            lvl2.interactable = false;
        }
    }
    public void babl()
    {
        if (PlayerPrefs.GetInt("money") >= 150)
        {
            PlayerPrefs.SetInt("babl", 1);
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 100);
            PlayerPrefs.Save();
            lvl3.interactable = false;
        }
    }
    public void lazer()
    {
        if (PlayerPrefs.GetInt("money") >= 300 && PlayerPrefs.GetInt("speed") != 1 && PlayerPrefs.GetInt("upshot") == 1)
        {
            PlayerPrefs.SetInt("lazer", 1);
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 300);
            PlayerPrefs.Save();
            lvl4.interactable = false;
            lvl5.interactable = false;
        }
    }
    public void speed()
    {
        if (PlayerPrefs.GetInt("money") >= 300 && PlayerPrefs.GetInt("lazer") != 1 && PlayerPrefs.GetInt("upshot") == 1)
        {
            PlayerPrefs.SetInt("speed", 1);
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 300);
            PlayerPrefs.Save();
            lvl5.interactable = false;
            lvl4.interactable = false;
        }
    }
    public void Relog()
    {
        PlayerPrefs.SetInt("babl", 0);
        PlayerPrefs.SetInt("uphp", 0);
        PlayerPrefs.SetInt("upshot", 0);
        PlayerPrefs.SetInt("money", 0);
        PlayerPrefs.SetInt("record", 0);
        PlayerPrefs.SetInt("lazer", 0);
        PlayerPrefs.SetInt("speed", 0);

        PlayerPrefs.SetString("recname", "");
        PlayerPrefs.SetString("recname2", "");
        PlayerPrefs.SetString("recname3", "");
        PlayerPrefs.SetInt("record", 0);
        PlayerPrefs.SetInt("record2", 0);
        PlayerPrefs.SetInt("record3", 0);

        Application.LoadLevel(0);

    }

}
