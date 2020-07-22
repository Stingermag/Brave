using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class srart : MonoBehaviour
{
    public Text name;
    public Text name2;
    public Text name3;
    public Text newname;
    public Text count;
    public Text count2;
    public Text count3;
    public Text newrec;
    // Start is called before the first frame update
    void Start()
    {
       
        PlayerPrefs.SetString("level", "2");
        newrec.text = "" + PlayerPrefs.GetInt("money");
    //    PlayerPrefs.SetInt("money", 0);
        PlayerPrefs.SetInt("kd3", 0);
        PlayerPrefs.SetInt("kd2", 0);
        PlayerPrefs.SetInt("kd1", 0);


        newname.text = "" + PlayerPrefs.GetString("namepla");
       // newrec.text = "" + PlayerPrefs.GetInt("money");



        name.text = "" + PlayerPrefs.GetString("recname");
        name2.text = "" + PlayerPrefs.GetString("recname2");
        name3.text = "" + PlayerPrefs.GetString("recname3");
        count.text = "" + PlayerPrefs.GetInt("record");
        count2.text = "" + PlayerPrefs.GetInt("record2");
        count3.text = "" + PlayerPrefs.GetInt("record3");



       


        if (PlayerPrefs.GetInt("winpos") == 1)
            name.color = Color.red;
        else if (PlayerPrefs.GetInt("winpos") == 2)
            name2.color = Color.red;
        else if(PlayerPrefs.GetInt("winpos") == 3)
            name3.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
