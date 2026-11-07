using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class Homework : MonoBehaviour
{
    public List<GameObject> objects = new List<GameObject>();
    [SerializeField] public Gradient gradient = new Gradient();
    public float maxY = 15f;
    void Start()
    {
        objects.Add(GameObject.Find("1"));
        objects.Add(GameObject.Find("2"));
        objects.Add(GameObject.Find("a"));
        objects.Add(GameObject.Find("b"));
        objects.Add(GameObject.Find("c"));
    }
    void Update()
    {
        CheckObjects();

    }

    void CheckObjects()
    {
        foreach (GameObject obj in objects)
        {




            if (obj.GetComponent<SpriteRenderer>() != null)
            {


                SpriteColor(obj.GetComponent<SpriteRenderer>());
            }
            else if (obj.GetComponent<MeshRenderer>() != null)
            {

                Cube(obj.GetComponent<MeshRenderer>().transform);
            }


        }
    }
    void SpriteColor(SpriteRenderer sprite)
    {

        float normalizedY = sprite.transform.position.y / maxY;
        sprite.color = gradient.Evaluate(normalizedY);
    }
    public void Cube(Transform transformCube)
    {
        float currentX = transformCube.position.x;
        float rotationY = currentX * 36f;
        float rotationX = currentX * 36f;
        transformCube.rotation = Quaternion.Euler(rotationX, 0, 0);
    }
}