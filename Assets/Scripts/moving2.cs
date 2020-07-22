using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moving2 : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private float thrust = 5f;
    private float speed = 5f;
    private float healthpoint = 0.35f;

    private bool MoveRight = false;
    private bool MoveLeft = false;
    public Vector3 mousePos;
    public Vector3 mousePosClick;
    public GameObject shot;
    public GameObject hp;
    public GameObject powershot;





    void Start()
    {
        rb2D = gameObject.AddComponent<Rigidbody2D>();
        hp.transform.localScale = new Vector3(healthpoint, 1f, 1f);
        //  transform.position = new Vector3(-7f, -1.5f, -8f);
    }

    void Update()
    {




        //if (gameObject.transform.position.x <= -7f)
        //    gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(7f, gameObject.transform.position.y, gameObject.transform.position.z), thrust * Time.deltaTime);


        if (gameObject.transform.position.x >= 63f)
        {
            Application.LoadLevel("level" + PlayerPrefs.GetString("level"));

            string sillyMeme = PlayerPrefs.GetString("level");

            int a;
            // attempt to parse the value using the TryParse functionality of the integer type
            int.TryParse(sillyMeme, out a);





            a++;

            PlayerPrefs.SetString("level", a.ToString());


        }
        if (gameObject.transform.position.y <= -35f)
        {
            SceneManager.LoadScene(0);
        }


        if (Input.GetMouseButtonDown(0))
        {
            if (mousePos.x <= 0f) MoveLeft = true;
            if (mousePos.x >= 0f) MoveRight = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            MoveRight = false;
            MoveLeft = false;

        }





        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveRight = true;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            MoveRight = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveLeft = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            MoveLeft = false;






        if (MoveRight)
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x + speed, gameObject.transform.position.y, gameObject.transform.position.z), thrust * Time.deltaTime);

        if (MoveLeft)
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x - speed, gameObject.transform.position.y, gameObject.transform.position.z), thrust * Time.deltaTime);



        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//изменяется все время == позиция мыши





        if (Input.GetKeyDown(KeyCode.Keypad3) && Input.GetKeyDown(KeyCode.DownArrow))
        {
            Instantiate(shot, new Vector3(gameObject.transform.position.x + 0.8f, gameObject.transform.position.y - 0.8f, gameObject.transform.position.z), Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            Instantiate(shot, new Vector3(gameObject.transform.position.x + 0.8f, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Keypad6) && (PlayerPrefs.GetInt("upshot") == 1))
        {
            Instantiate(powershot, new Vector3(gameObject.transform.position.x + 0.8f, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Keypad9) && (PlayerPrefs.GetInt("uphp") == 1))
        {
            hp.transform.localScale = new Vector3(0.35F, 1f, 1f);
        }
        if (Input.GetKeyDown(KeyCode.Keypad8) && (PlayerPrefs.GetInt("babl") == 1))
        {
            PlayerPrefs.SetInt("bablact", 1);
        }
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 100f, gameObject.transform.position.z), thrust * Time.deltaTime);

        }
    }






}
