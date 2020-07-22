using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getDmg2 : getDmg
{

    //void Start()
    //{
    //    InvokeRepeating("Move", 2f, 4f);
    //}
    //float timer3 = 3f;
    bool a;
    void Start()
    {
        int b = Random.Range(0, 10);
        if (b >= 5)
            a = false;
        else
            a = true;
        InvokeRepeating("moveshot", 2f, 3f);
    }
    void OnCollisionEnter2D(UnityEngine.Collision2D hit)
    {

        if (hit.gameObject.tag == "shot")
        {

            //   Destroy(player);
            hp.transform.localScale -= new Vector3(0.2F, 0, 0);
            // player.GetComponent<Rigidbody2D>().gravityScale = -2f;

        }

        if (hit.gameObject.tag == "powershot")
        {

            hp.transform.localScale -= new Vector3(0.5F, 0, 0);

        }
        if (hp.transform.localScale.x <= 0f)
        {
            int a = PlayerPrefs.GetInt("money");
            a = a + 40;
            PlayerPrefs.SetInt("money", a);
            PlayerPrefs.Save();
            //   Instantiate(shot, new Vector3(gameObject.transform.position.x - 0.8f, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
            Destroy(pla);
        }

    }

    void Update()
    {
        if(a)
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x + 0.3f, gameObject.transform.position.y, gameObject.transform.position.z), 5f * Time.deltaTime);
        else
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x - 0.3f, gameObject.transform.position.y, gameObject.transform.position.z), 5f * Time.deltaTime);

    }
    void moveshot()
    {
        Instantiate(shot, new Vector3(gameObject.transform.position.x - 0.8f, gameObject.transform.position.y - 0.5f, gameObject.transform.position.z), Quaternion.identity);

        if (a) { a = false; }
        else { a = true; }
    }


}
