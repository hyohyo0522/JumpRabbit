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
        Debug.Log("���ڰ� Ŭ���Ǿ���!!!!!! �������̽� ��ġ �۵�!!");
        //���⿡ ���� Touch �Ǿ��� ���� ������ �ִ´�.
    }

    //private void OnMouseDown()
    //{
    //    Debug.Log("���ڰ� ���ȴ�!!");
    //}
    


}
