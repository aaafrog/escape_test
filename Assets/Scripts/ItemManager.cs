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
    public GameObject CanvasUI;
    public GameObject KeyImage;
    public GameObject NoteImage;
    public GameObject CageImage;
    public GameObject ItemImage1;
    public Image ItemImg1;
    public Sprite ItemImgSprite1;

    //鍵フラグ
    int keyflg = 0;

    //籠アクション
    public void onCageImage()
    {
        if(keyflg == 0){
            Debug.Log("籠をクリック");
            CanvasUI.SetActive(false);
            CageImage.SetActive(false);
            KeyImage.SetActive(true);

            //鍵をアイテムボックスへ収納 
            ItemImg1.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            ItemImg1.sprite = ItemImgSprite1;
            keyflg = 1;
        }
    }

    //アイテムボックスアクション
    public void OnItemImage1()
    {
        if (keyflg == 0)
        {

        }else if (keyflg == 1)
        {
            keyflg = 2;
            ItemImg1.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
            Debug.Log("鍵を選択 cageflg:" + keyflg);
        }
        else if (keyflg == 2)
        {
            keyflg = 1;
            ItemImg1.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            Debug.Log("鍵を選択解除 cageflg:" + keyflg);
        }
    }

    public void OnKeyImage()
    {
        Debug.Log("鍵を入手");
        CanvasUI.SetActive(true);
        KeyImage.SetActive(false);
    }

    //引き出しアクション
    public void onDrawerImage()
    {
        if(keyflg == 0 || keyflg == 1) {
            Debug.Log("鍵がかかっている！");
        } else if(keyflg == 2)
        {
            Debug.Log("鍵があいた！");
            CanvasUI.SetActive(false);
            NoteImage.SetActive(true);
            keyflg = 4;
            ItemImg1.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        }else if(keyflg == 4)
        {
            Debug.Log("ノート再確認");
            CanvasUI.SetActive(false);
            NoteImage.SetActive(true);

        }
    }

    public void onNoteImage()
    {
        Debug.Log("ノートを発見");
        CanvasUI.SetActive(true);
        NoteImage.SetActive(false);
    }

}
