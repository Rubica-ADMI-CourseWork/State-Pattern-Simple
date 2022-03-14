using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContext
{
    public IPlayerState _currentState;

    private readonly PlayerController _playerController;

    public PlayerContext(PlayerController controller)
    {
        _playerController = controller;
    }

    public void Transition()
    {
        _currentState.Handle(_playerController);
    }

    public void Transition(IPlayerState stateToTransitionTo)
    {
        _currentState = stateToTransitionTo;
        _currentState.Handle(_playerController);
    }
}
