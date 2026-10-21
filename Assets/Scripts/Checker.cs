using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework : MonoBehaviour
{
    public List<GameObject> Objects = new List<GameObject>();
    void Start()
    {
       CheckObjects();
    }

    void CheckObjects()
    {
        foreach (GameObject obj in Objects)
        {
            if (obj != null)
            {
                if (obj.GetComponent<SpriteRenderer>() != null)
                {
                    Debug.Log(obj.name + "to 2D");
                }
                else if (obj.GetComponent<MeshRenderer>() != null)
                {
                    Debug.Log(obj.name + "to 3D");
                }
            }
           
            }
        }
    }
