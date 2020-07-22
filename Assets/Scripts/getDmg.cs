using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getDmg : MonoBehaviour
{
    RectTransform rectTransform;
    public GameObject hp;
    public GameObject pla;


    public GameObject shot;



    public int repeat_time; /* Время в секундах */
    private float curr_time;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RunTimer", 2f, 4f);
    }


    void OnCollisionEnter2D(UnityEngine.Collision2D hit)
    {

        if (hit.gameObject.tag == "shot")
        {

            //   Destroy(player);
            hp.transform.localScale -= new Vector3(0.3F, 0, 0);
            // player.GetComponent<Rigidbody2D>().gravityScale = -2f;

        }
    
        if (hit.gameObject.tag == "powershot")
        {

            hp.transform.localScale -= new Vector3(1F, 0, 0);

        }
        if (hp.transform.localScale.x <= 0f)
        {
            int a = PlayerPrefs.GetInt("money");
            a = a + 30;
            PlayerPrefs.SetInt("money", a);
            PlayerPrefs.Save();
            //   Instantiate(shot, new Vector3(gameObject.transform.position.x - 0.8f, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
            Destroy(pla);
        }

    }
    void Update()
    {
       
    }
    void RunTimer()
    {
        Instantiate(shot, new Vector3(gameObject.transform.position.x - 0.8f, gameObject.transform.position.y - 0.5f, gameObject.transform.position.z), Quaternion.identity);

    }
}