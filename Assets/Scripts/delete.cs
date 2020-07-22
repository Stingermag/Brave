using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class delete : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;

    public GameObject hp;

    void OnCollisionEnter2D(UnityEngine.Collision2D hit)
    {
      


            if (hit.gameObject.tag == "123")
            {

                if (PlayerPrefs.GetInt("bablact") == 1)
                {
                 //   hp.transform.localScale -= new Vector3(0.1F, 0, 0);
                    PlayerPrefs.SetInt("bablact", 0);

                }
                else
                {
                    hp.transform.localScale -= new Vector3(0.1F, 0, 0);
                }

            }

            if (hit.gameObject.tag == "fire")
            {
                if (PlayerPrefs.GetInt("bablact") == 1)
                {
                 //   hp.transform.localScale -= new Vector3(0.5F, 0, 0);
                    PlayerPrefs.SetInt("bablact", 0);
                }
                else
                {
                    hp.transform.localScale -= new Vector3(0.5F, 0, 0);
                }
            }

            if (hit.gameObject.tag == "powershoten")
            {
                if (PlayerPrefs.GetInt("bablact") == 1)
                {
                    //   hp.transform.localScale -= new Vector3(0.5F, 0, 0);
               //     PlayerPrefs.SetInt("bablact", 0);
                }
                else
                {
                    hp.transform.localScale -= new Vector3(0.5F, 0, 0);
                }
            }

            if (hp.transform.localScale.x <= 0f)
            {

            //    Instantiate(enemy);


                 //if(PlayerPrefs.GetInt("record") < PlayerPrefs.GetInt("money"))
                 //{
                 //    PlayerPrefs.SetInt("record", PlayerPrefs.GetInt("money"));
                 //    PlayerPrefs.SetString("recname", PlayerPrefs.GetString("namepla"));
                 //    PlayerPrefs.Save();

                 //}

                if (PlayerPrefs.GetInt("money") - 50 <= 0)
                {
                    PlayerPrefs.SetInt("money", 0);
                }
                else
                {
                    PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 50);
                }
                Application.LoadLevel(Application.loadedLevel);

            }
    }
}

