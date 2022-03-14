using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public bool enableErrorLogging = true;


    [SerializeField] PlayerStateMoveLeft _moveLeftState;
    [SerializeField] PlayerStateMoveRight _moveRightState;

    private PlayerContext _playerContext;

    private void Start()
    {
        _playerContext = new PlayerContext(this);
    }

    private void Update()
    {
        //when an input event happens to change states 
        //communicate to the context class to do it
        //by calling it's transition method and passing it the 
        //state you want to transition to
        var screenWidth = Screen.width;
        if (Input.GetMouseButton(0))
        {
            var tapPos = Input.mousePosition;

            if (tapPos.x > screenWidth / 2)
            {
                _playerContext.Transition(_moveRightState);
            }
            else if (tapPos.x < screenWidth / 2)
            {
                _playerContext.Transition(_moveLeftState);
            }
        }
    }


}
