using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class moving : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private float thrust = 5f;
    private float speed = 5f;
    private float healthpoint = 0.35f;

    private AudioSource audioS;

    private bool MoveRight = false;
    private bool MoveLeft = false;


    public Vector3 mousePos;
    public Vector3 mousePosClick;
    public GameObject shot;
    public GameObject hp;
    public GameObject powershot;
    public GameObject lazer;
    int timer3 = 3;
    int timer2 = 3;
    int timer1 = 3;
    float timerat = 1f;

    public Text TextKd3;
    public Text TextKd2;
    public Text TextKd1;



    public string qwe;


    public GameObject runleft;
    public GameObject staing;
    public GameObject light;


    void Start()
    {
        rb2D = gameObject.AddComponent<Rigidbody2D>();
        hp.transform.localScale = new Vector3(healthpoint, 1f, 1f);
        InvokeRepeating("Kyldayn3", 0f, 1f);
        InvokeRepeating("Kyldayn2", 0f, 1f);
        InvokeRepeating("Kyldayn1", 0f, 1f);
        InvokeRepeating("attak", 0f, 0.2f);

     //   anim = GetComponent<Animation>();
     //   anim.Stop();

               audioS = GetComponent<AudioSource>(); 

        //  transform.position = new Vector3(-7f, -1.5f, -8f);
    }

    void Update()
    {

        qwe = PlayerPrefs.GetString("level");

        if (gameObject.transform.position.x >= 63f)
        {
            if (Application.loadedLevel == 4)
            {
                if (PlayerPrefs.GetInt("record") < PlayerPrefs.GetInt("money"))
                {
                    PlayerPrefs.SetInt("record3", PlayerPrefs.GetInt("record2"));
                    PlayerPrefs.SetString("recname3", PlayerPrefs.GetString("recname2"));

                    PlayerPrefs.SetInt("record2", PlayerPrefs.GetInt("record"));
                    PlayerPrefs.SetString("recname2", PlayerPrefs.GetString("recname"));

                    PlayerPrefs.SetInt("record", PlayerPrefs.GetInt("money"));
                    PlayerPrefs.SetString("recname", PlayerPrefs.GetString("namepla"));

                    PlayerPrefs.SetInt("winpos",1);
                }
                else
                if (PlayerPrefs.GetInt("record2") < PlayerPrefs.GetInt("money"))
                {
                    PlayerPrefs.SetInt("record3", PlayerPrefs.GetInt("record2"));
                    PlayerPrefs.SetString("recname3", PlayerPrefs.GetString("recname2"));                  

                    PlayerPrefs.SetInt("record2", PlayerPrefs.GetInt("money"));
                    PlayerPrefs.SetString("recname2", PlayerPrefs.GetString("namepla"));
                    PlayerPrefs.SetInt("winpos", 2);
                }
                else
                if (PlayerPrefs.GetInt("record3") < PlayerPrefs.GetInt("money"))
                {
                    PlayerPrefs.SetInt("record3", PlayerPrefs.GetInt("money"));
                    PlayerPrefs.SetString("recname3", PlayerPrefs.GetString("namepla"));
                    PlayerPrefs.SetInt("winpos", 3);
                }
                else
                  PlayerPrefs.SetInt("winpos", 0);
                Application.LoadLevel(0);

            }
            else
            {
                Application.LoadLevel(Application.loadedLevel+1);

            }


           
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

         if (Input.GetKeyDown("d"))
         {

         runleft.SetActive(true);
         staing.SetActive(false);

         MoveRight = true;
         }
         else
        if (Input.GetKeyDown("a"))
        {
            runleft.SetActive(true);
            staing.SetActive(false);
            MoveLeft = true;
        }
        if (Input.GetKeyUp("d"))
         {

         runleft.SetActive(false);
         staing.SetActive(true);
         MoveRight = false;
         
         }
        else
       
         
         if (Input.GetKeyUp("a"))
         {
         runleft.SetActive(false);
         staing.SetActive(true);
         MoveLeft = false;


         }
        


       


        if (MoveRight)
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x + speed, gameObject.transform.position.y, gameObject.transform.position.z), thrust * Time.deltaTime);

        if (MoveLeft)
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x - speed, gameObject.transform.position.y, gameObject.transform.position.z), thrust * Time.deltaTime);



        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//изменяется все время == позиция мыши



       
        
        if (Input.GetKeyDown("space") && Input.GetKeyDown("s"))
        {
            Instantiate(shot, new Vector3(gameObject.transform.position.x + 0.8f, gameObject.transform.position.y - 0.8f, gameObject.transform.position.z), Quaternion.identity);
        }       
        if (Input.GetKeyDown("space") && (PlayerPrefs.GetFloat("kdat") == 0))
        {
            Instantiate(shot, new Vector3(gameObject.transform.position.x + 0.8f, gameObject.transform.position.y , gameObject.transform.position.z), Quaternion.identity);
            if(PlayerPrefs.GetInt("speed") == 1)
            {
                timerat = 0f;
            }
            else
            timerat = 3f;
            audioS.Play();
        }
        if (Input.GetKeyDown("1") && (PlayerPrefs.GetInt("kd1") == 0))
        {
            if ((PlayerPrefs.GetInt("lazer") == 1))
            {
                Instantiate(shot, new Vector3(gameObject.transform.position.x + 1f, gameObject.transform.position.y + 0.5f, gameObject.transform.position.z), Quaternion.identity);
                Instantiate(shot, new Vector3(gameObject.transform.position.x + 0.8f, gameObject.transform.position.y - 0.5f, gameObject.transform.position.z), Quaternion.identity);
                Instantiate(shot, new Vector3(gameObject.transform.position.x + 0.6f, gameObject.transform.position.y + 1.5f, gameObject.transform.position.z), Quaternion.identity);
                Instantiate(shot, new Vector3(gameObject.transform.position.x + 1.2f, gameObject.transform.position.y + 1f, gameObject.transform.position.z), Quaternion.identity);
                Instantiate(shot, new Vector3(gameObject.transform.position.x + 0.4f, gameObject.transform.position.y + 1.3f, gameObject.transform.position.z), Quaternion.identity);
                timer1 = 20;


            }
            else if ((PlayerPrefs.GetInt("upshot") == 1))
            {
                Instantiate(powershot, new Vector3(gameObject.transform.position.x + 0.8f, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);

                timer1 = 10;

            }

            

        }
        if (Input.GetKeyDown("2") && (PlayerPrefs.GetInt("uphp") == 1) && (PlayerPrefs.GetInt("kd2") == 0))
        {
            hp.transform.localScale = new Vector3(0.35F, 1f, 1f);
            light.SetActive(true);
            timer2 = 12;
        }
        if (Input.GetKeyDown("3") && (PlayerPrefs.GetInt("babl") == 1) && (PlayerPrefs.GetInt("kd3") == 0))
        {
            PlayerPrefs.SetInt("bablact", 1);
            
            timer3 = 14;

        }
        
       

    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 100f, gameObject.transform.position.z), thrust * Time.deltaTime);

        }
    }

    void Kyldayn3()
    {
        if ((timer3 -= 1) > 0)
        {
            TextKd3.text = "" + timer3;
            PlayerPrefs.SetInt("kd3", timer3);
   //         TextKd.text = timer;
        }
        else
        {
           
            TextKd3.text = "Готово";
            PlayerPrefs.SetInt("kd3", 0);
           
        }
    }
    void Kyldayn2()
    {
        

        if ((timer2 -= 1) > 0)
        {
            TextKd2.text = "" + timer2;
            PlayerPrefs.SetInt("kd2", timer2);
            //         TextKd.text = timer;
        }
        else
        {
            
            TextKd2.text = "Готово";
            PlayerPrefs.SetInt("kd2", 0);
           
        }
        if (timer2 == 11) light.SetActive(false);
    }
    void attak()
    {
        if ((timerat -= 1f) > 0)
        {
       
            PlayerPrefs.SetFloat("kdat", timerat);
            //         TextKd.text = timer;
        }
        else
        {
            
            PlayerPrefs.SetFloat("kdat", 0);

        }
    }
    void Kyldayn1()
    {
        if ((timer1 -= 1) > 0)
        {
            TextKd1.text = "" + timer1;
            PlayerPrefs.SetInt("kd1", timer1);
            //         TextKd.text = timer;
        }
        else
        {
            TextKd1.text = "Готово";
            PlayerPrefs.SetInt("kd1", 0);

        }
    }






}
