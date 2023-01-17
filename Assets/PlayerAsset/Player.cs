using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace MyCompany.MyLibrary.MyAsset
{
    public class Player : MonoBehaviour
    {
        public string playerName;
        public int playerID;
        private ICommand _moveUp, _moveDown, _moveLeft, _moveRight;
        [SerializeField] private float _speed = 5f;
        private Vector3 _startingPosition;

        [SerializeField] private MeshRenderer[] _cubeRenderers;

        public static event Action onColorBlue;

        public Player(string name, int id)
        {
            this.playerName = name;
            this.playerID = id;
        }

        private void Start()
        {
            _startingPosition = this.transform.position;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //turn cubes red
                //raise an event
                onColorBlue?.Invoke();
            }

            if (Input.GetKey(KeyCode.W))
            {
                //move up command
                _moveUp = new MoveUpCommand(this.transform, _speed);
                ExecuteCommand(_moveUp);
                CommandManager.Instance.AddCommand(_moveUp);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                //move down command
                _moveDown = new MoveDownCommand(this.transform, _speed);
                ExecuteCommand(_moveDown);
                CommandManager.Instance.AddCommand(_moveDown);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                //move left command
                _moveLeft = new MoveLeftCommand(this.transform, _speed);
                ExecuteCommand(_moveLeft);
                CommandManager.Instance.AddCommand(_moveLeft);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                //move right command
                _moveRight = new MoveRightCommand(this.transform, _speed);
                ExecuteCommand(_moveRight);
                CommandManager.Instance.AddCommand(_moveRight);
            }
        }

        private void ExecuteCommand(ICommand command)
        {
            command.Execute();
        }

        public void ResetPosition()
        {
            this.transform.position = _startingPosition;
        }
    }
}
