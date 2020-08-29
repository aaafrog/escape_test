using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{

    /******************************************** 
    *          アイテムボックスの処理
    ********************************************/
    //ゲームオブジェクト 
    public GameObject CageImage;
    public GameObject KeyImage;
    public GameObject NoteImage;
    public GameObject DoorImage;
    public GameObject[] ItemImages;

    //アイテムリスト
    public enum Item
    {
        key1,
        Key2,
        Key3,
        Key4,
    }

    public Item item;

    void KeyImageAction(bool isShow)
    {
        KeyImage.SetActive(isShow);
    }
    void CageImageAction(bool isShow)
    {
        CageImage.SetActive(isShow);
    }
    void DoorImageAction(bool isShow)
    {
        DoorImage.SetActive(isShow);
    }
    void NoteImageAction(bool isShow)
    {
        NoteImage.SetActive(isShow);
    }

    //アイテム取得
    public void onGetItem()
    {
        Debug.Log(item + "を取得");

        //itemを値で取得
        int index = (int)item;
        ItemImages[index].SetActive(true);

        if (index == 0)
        {
            KeyImageAction(true);
            CageImageAction(false);
        }
    }

    //アイテム使用
    int keyFlg = 0;
    public void onUseItem()
    {
        if (ItemImages[0].activeSelf == true)
        {
            Debug.Log("鍵があいた");
            NoteImageAction(true);
            ItemImages[0].SetActive(false);
            keyFlg = 1;
            Debug.Log(keyFlg);
        }
        else if (keyFlg == 1)
        {
            NoteImageAction(true);
        }
        else
        {
            Debug.Log("鍵がかかっている");
        }
    }

    //BackButtonアクション
    public void onBackButton()
    {
        Debug.Log("BackButton");
        KeyImageAction(false);
        DoorImageAction(false);
        NoteImageAction(false);
    }


}
