using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIMen : MonoBehaviour
{

    public InputField name;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NewGame()
    {
        PlayerPrefs.SetString("namepla", name.text);
        PlayerPrefs.SetInt("level", 1);
        PlayerPrefs.SetInt("money", 0);
        SceneManager.LoadScene(2);
    }



    public void Exit()
    {
        Application.Quit();
    }



}
