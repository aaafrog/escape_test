using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PasswordManager : MonoBehaviour
{
    /*
    [SerializeField] GameObject NoButton1;
    [SerializeField] GameObject NoButton2;
    [SerializeField] GameObject NoButton3;
    [SerializeField] GameObject NoButton4;
    [SerializeField] GameObject NoButton5;
    [SerializeField] GameObject NoButton6;
    [SerializeField] GameObject NoButton7;
    [SerializeField] GameObject NoButton8;
    [SerializeField] GameObject NoButton9;
    */


    [SerializeField] Text PassWordText1;
    [SerializeField] Text PassWordText2;
    [SerializeField] Text PassWordText3;
    [SerializeField] Text PassWordText4;



    private string CORRECT_PASSWORD = "1234";

    private bool firstPush = false; // 連打対策
    private int pressCount = 0;
    private int pressedPassWordNo = 0;
    private string enteredPassWordNo = "";


    public GameObject DoorImage;



    /******************************************** 
    *          パスワードの処理
    ********************************************/


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void onDoorImage()
    {
        Debug.Log("ドアをクリック");
        DoorImage.SetActive(true);
    }



    public void OnPassWordButton(int getSselected)
    {
        if (!firstPush)
        {
            firstPush = true;
            pressCount = pressCount + 1;

            //Debug.Log("pressedPassWordNo = " + getSselected);
            Debug.Log("pressCount = " + pressCount);
            pressedPassWordNo = getSselected;


            if (pressCount < 5)
            {
                enteredPassWordNo = enteredPassWordNo + getSselected.ToString();
                //Debug.Log("enteredPassWordNo = " + enteredPassWordNo);

                /*
                for (int i = 1; i < 5; i++)
                {
                    PassWordText1.GetComponent<Text>().text = getSselected.ToString();
                }
                */
                if (pressCount == 1)
                {
                    PassWordText1.GetComponent<Text>().text = getSselected.ToString();
                }

                if (pressCount == 2)
                {
                    PassWordText2.GetComponent<Text>().text = getSselected.ToString();
                }

                if (pressCount == 3)
                {
                    PassWordText3.GetComponent<Text>().text = getSselected.ToString();
                }

                if (pressCount == 4)
                {
                    PassWordText4.GetComponent<Text>().text = getSselected.ToString();
                }

                if (enteredPassWordNo == "1234")
                {
                    FadeManager.FadeOut(2);
                    Debug.Log("clear");
                }


            }

            if (pressCount == 5)
            {
                PassWordText1.GetComponent<Text>().text = "";
                PassWordText2.GetComponent<Text>().text = "";
                PassWordText3.GetComponent<Text>().text = "";
                PassWordText4.GetComponent<Text>().text = "";
                pressCount = 0;
                enteredPassWordNo = "";
            }



            firstPush = false;
        }

    }
}
