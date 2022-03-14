using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMoveRight : MonoBehaviour, IPlayerState
{
    [SerializeField] Animator _playerCharacterAnimator;
    [SerializeField] float _lerpRate;
    [SerializeField] float _rightExtent;

    private PlayerController _playerController;
    public void Handle(PlayerController playerController)
    {
        if(_playerController == null)
        {
            _playerController = playerController;
        }

        _playerCharacterAnimator.SetTrigger("moveRight");
        var currentPos = _playerController.transform.position;
        var newPos = new Vector3(_rightExtent,_playerController.transform.position.y,
            _playerController.transform.position.z);
        _playerController.transform.position = Vector3.Lerp(currentPos, newPos, Time.deltaTime * _lerpRate);
    }
}
