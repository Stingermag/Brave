using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgold : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject money;

    void OnCollisionEnter2D(UnityEngine.Collision2D hit)
    {

        if (hit.gameObject.tag == "gold")
        {
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 50);
            Destroy(money);
        }

      
    }
}
