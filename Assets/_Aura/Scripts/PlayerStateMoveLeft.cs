using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMoveLeft : MonoBehaviour, IPlayerState
{
    [SerializeField] float _leftExtent;
    [SerializeField] float _lerpRate;
    [SerializeField] Animator _animator;

    private PlayerController _playerController;
    public void Handle(PlayerController playerController)
    {
        if(_playerController == null)
        {
            _playerController = playerController;
        }

        //set the animation here
        _animator.SetTrigger("moveRight");
        var currentPos = _playerController.transform.position;
        var newPos = new Vector3(_leftExtent,
            _playerController.transform.position.y,
            _playerController.transform.position.z);
        _playerController.transform.position = Vector3.Lerp(currentPos,newPos,Time.deltaTime * _lerpRate);
    }
}
