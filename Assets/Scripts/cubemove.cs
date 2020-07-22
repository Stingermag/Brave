using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemove : MonoBehaviour
{
    cubemove(float a)
    {
        thrust = a;
    }

    public GameObject player;

    bool left = false;
    bool right = false;
    bool up = false;
    bool down = false;
    private float thrust;
    public float qwe;
    // Start is called before the first frame update
    void Start()
    {
        right = true;

        thrust = 7;
    }

    // Update is called once per frame
    void Update()
    {

        qwe = player.transform.position.y;
        if (player.transform.position.y >= 3f)
        {
            right = false;
            up = false;
            left = false;
            down = true;
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.1f, gameObject.transform.position.z), thrust * Time.deltaTime);


        }
        if (player.transform.position.y <= -3f)
        {
            right = false;
            up = true;
            left = false;
            down = false;
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.1f, gameObject.transform.position.z), thrust * Time.deltaTime);


        }
        //if (player.transform.position.y <= -3f)
        //{
        //    right = false;
        //    up = false;
        //    left = true;
        //    down = false;
        //    gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.1f, gameObject.transform.position.z), thrust * Time.deltaTime);


        //}
        //if (player.transform.position.y >= 3f)
        //{
        //    right = true;
        //    up = false;
        //    left = false;
        //    down = false;
        //    gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.1f, gameObject.transform.position.z), thrust * Time.deltaTime);


        //}


        //if (left)
        //{
        //    gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x - 5f, gameObject.transform.position.y, gameObject.transform.position.z), thrust * Time.deltaTime);

        //}
        //if (right)
        //{
        //    gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x + 5f, gameObject.transform.position.y, gameObject.transform.position.z), thrust * Time.deltaTime);

        //}
        if (up)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 5f, gameObject.transform.position.z), thrust * Time.deltaTime);

        }
        if (down)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 5f, gameObject.transform.position.z), thrust * Time.deltaTime);

        }
    }
}

