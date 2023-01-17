using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CommandManager : MonoSingelton<CommandManager>
{
    private List<ICommand> _commandBuffer = new List<ICommand>();

    //private List<ICommand> _reverseCommandBuffer = new List<ICommand>();

    private WaitForSeconds _commandDelayTime = new WaitForSeconds(1f);
    private WaitForEndOfFrame _endOfFrame = new WaitForEndOfFrame();

    private const string _playRoutine = "PlayRoutine";
    private const string _reverseRoutine = "ReverseRoutine";
    private const string _playMovementRoutine = "PlayMovementRoutine";
    private const string _rewindMovementRoutine = "RewindMovementRoutine";

    [SerializeField] private UserInput _input;

    //method to add commands to the command buffer
    public void AddCommand(ICommand command)
    {
        _commandBuffer.Add(command);

        //foreach (ICommand com in _commandBuffer)
        //{
        //    Debug.Log("The commands in the command buffer are " + com.ToString());
        //}
    }

    //play routine started by play method that plays back all commands with 1 second delay
    public void Play()
    {
        //StopCoroutine(_reverseRoutine);
        StartCoroutine(_playRoutine);
    }

    private IEnumerator PlayRoutine()
    {
        foreach (ICommand command in _commandBuffer)
        {
            command.Execute();
            yield return _commandDelayTime;
        }

        Debug.Log("Finished Playing");
    }
    //rewind routine started by rewind method that plays back all commands in reverse with one second delay
    public void Reverse()
    {
        //StopCoroutine(_playRoutine);
        StartCoroutine(_reverseRoutine);
    }

    private IEnumerator ReverseRoutine()
    {
        //_reverseCommandBuffer = _commandBuffer;
        //_reverseCommandBuffer.Reverse();

        foreach (ICommand command in Enumerable.Reverse(_commandBuffer))
        {
            command.Undo();
            yield return _commandDelayTime;
        }

        Debug.Log("Finished Reversing");
    }

    public void PlayMovement()
    {
        StartCoroutine(_playMovementRoutine);
    }

    private IEnumerator PlayMovementRoutine()
    {
        foreach(ICommand command in _commandBuffer)
        {
            command.Execute();
            yield return _endOfFrame;
        }

        Debug.Log("Finished Playing Movement");
    }

    public void RewindMovement()
    {
        StartCoroutine(_rewindMovementRoutine);
    }

    private IEnumerator RewindMovementRoutine()
    {
        foreach (ICommand command in Enumerable.Reverse(_commandBuffer))
        {
            command.Undo();
            yield return _endOfFrame;
        }

        Debug.Log("Finished Reversing Movement");
    }

    //done. finished chaning colors, reset all cubes to white
    public void Done()
    {
        MeshRenderer[] renderers = _input.MeshRenderers();

        foreach (MeshRenderer renderer in renderers)
        {
            renderer.material.color = Color.white;
        }
    }

    //reset. clear the command buffer
    public void Clear()
    {
        _commandBuffer.Clear();
    }
}
