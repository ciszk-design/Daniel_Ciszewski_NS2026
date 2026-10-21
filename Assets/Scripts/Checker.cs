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
                SpriteRenderer sprite = obj.GetComponent<SpriteRenderer>();
                if (sprite != null)
                {
                    Debug2D(sprite);
                }
                else
                {
                    Transform trans = obj.transform;
                    Debug3D(trans);
                }
            }

        }
    }
    void Debug2D(SpriteRenderer sprite)
    {
        Debug.Log(sprite.gameObject.name + "to 2D (z Debugu2D)");
    }

    void Debug3D(Transform trans)
    {
        Debug.Log(trans.gameObject.name + "to 3D (z Debugu3D)");
    }
}

 
