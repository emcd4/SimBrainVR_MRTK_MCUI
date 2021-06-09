using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Management : MonoBehaviour
{
    public bool _isMindPlaceCondition;
    public bool _isMindPlaceShow =false;
    public GameObject mindPlace_notification;
    public GameObject _mindPlace;
    void Start()
    {
        _isMindPlaceCondition = false;
    }

    // Update is called once per frame
    void Update()
    {
        isShowNotification();
    }

    void isShowNotification()
    {
        if(_isMindPlaceCondition == true)
        {
            mindPlace_notification.SetActive(true);
            if (Input.GetKeyDown("space"))
            {
                _isMindPlaceShow = !_isMindPlaceShow;
                _mindPlace.SetActive(_isMindPlaceShow);
            }
        }
        else
        {
            mindPlace_notification.SetActive(false);
            _mindPlace.SetActive(false);
        }
    }
}
