using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    private const string _cube = "Cube";
    private const string _cube1 = "CommandCube1";
    private const string _cube2 = "CommandCube2";
    private const string _cube3 = "CommandCube3";

    [SerializeField] private MeshRenderer[] _cubeRenderers;

    private int _cubeID;

    // Update is called once per frame
    void Update()
    {
        //left click
        //raycast
        //check for cube tag
        //assign random color

        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                if (hitInfo.collider.CompareTag(_cube))
                {
                    //assign random color
                    Color randomColor = new Color(Random.value, Random.value, Random.value);
                    //hitInfo.collider.GetComponent<MeshRenderer>().material.color = randomColor;
                 
                    //if (hitInfo.collider.gameObject.name == _cube1)
                    //{
                    //    _cubeID = 0;
                    //}
                    //else if (hitInfo.collider.gameObject.name == _cube2)
                    //{
                    //    _cubeID = 1;
                    //}
                    //else if (hitInfo.collider.gameObject.name == _cube3)
                    //{
                    //    _cubeID = 2;
                    //}

                    switch (hitInfo.collider.gameObject.name)
                    {
                        case _cube1:
                            _cubeID = 0;
                            break;
                        case _cube2:
                            _cubeID = 1;
                            break;
                        case _cube3:
                            _cubeID = 2;
                            break;
                        default:
                            Debug.LogError("There is no case for this cube ID");
                            break;
                    }

                    //execute click command
                    ICommand click = new ClickCommand(hitInfo.collider.gameObject, randomColor, _cubeRenderers[_cubeID]);
                    click.Execute();

                    CommandManager.Instance.AddCommand(click);
                }
            }
        }
    }

    public MeshRenderer[] MeshRenderers()
    {
        return _cubeRenderers;
    }
}
