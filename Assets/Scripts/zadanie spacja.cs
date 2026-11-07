using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class zadaniespacja : MonoBehaviour
{
    public float speed = 5;
    public bool follow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            follow = !follow;

        }

        if (follow == true)

        {
            Vector2 worldPos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(worldPos.x, worldPos.y, transform.position.z);
        }
          

    }
}
