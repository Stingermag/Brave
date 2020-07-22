using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enshotmove : MonoBehaviour
{
    public float speed;
    private float thrust = 10f;
    public GameObject shot;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x - speed, gameObject.transform.position.y, gameObject.transform.position.z), thrust * Time.deltaTime);


    }
    void OnCollisionEnter2D(UnityEngine.Collision2D hit)
    {

        if (hit.gameObject.tag == "player")
        {

            Destroy(shot);
            //   hp.transform.localScale -= new Vector3(0.3F, 0, 0);

            // player.GetComponent<Rigidbody2D>().gravityScale = -2f;

        }
        if (hit.gameObject.tag == "prep")
        {

            Destroy(shot);
            //   hp.transform.localScale -= new Vector3(0.3F, 0, 0);

            // player.GetComponent<Rigidbody2D>().gravityScale = -2f;

        }
    }
}
