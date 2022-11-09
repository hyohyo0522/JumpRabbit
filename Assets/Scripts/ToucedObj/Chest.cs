using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Chest : MonoBehaviour,ITouchedObj
{

    private bool touchOn;
    public Collider2D directIcon;
    float rotateSpeed = 0.5f;
    float moveTimeCycle = 1.2f;
    bool iconmoveUp = false;


    
    // Start is called before the first frame update
    void Start()
    {
        //iscamera = Camera.main;
        touchOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        //directIcon.transform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);
        //if ()
        //{
        //if(moveTimeCycle<=0)
        //{
        //    moveTimeCycle -= Time.deltaTime;
        //    directIcon.transform.Translate(Vector3.up * rotateSpeed * Time.deltaTime);

        //}
        //else
        //{

        //}

        if (iconmoveUp)
        {
            moveTimeCycle -= Time.deltaTime;
            directIcon.transform.Translate(Vector3.up * rotateSpeed * Time.deltaTime);
            if (moveTimeCycle<=0)
            {
                iconmoveUp = false;
                moveTimeCycle = 1.2f;
            }
        }
        else
        {
            moveTimeCycle -= Time.deltaTime;
            directIcon.transform.Translate(Vector3.down * rotateSpeed * Time.deltaTime);
            if (moveTimeCycle <= 0)
            {
                iconmoveUp = true;
                moveTimeCycle = 1.2f;
            }
        }
        //}


    }



    public void Touch()
    {
        touchOn = true;
        Debug.Log("상자가 클릭되었다!!!!!! 인터페이스 터치 작동!!");
        //여기에 상자 Touch 되었을 때의 동작을 넣는다.
    }

    //private void OnMouseDown()
    //{
    //    Debug.Log("상자가 눌렸다!!");
    //}
    


}
