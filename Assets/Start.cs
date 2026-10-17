using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{
    List<int> dane = new List<int> { 1, 3, 3, 1, 2, 2, 3, 1, 3, 2 };
    List<int> jedynki = new List<int>();
    List<int> dwojki = new List<int>();
    List<int> trojki = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
       
        foreach (int x in dane)
        {
            if (x == 1)
            {
                jedynki.add(x);

            }
            else if (x == 2)
            {
                dwojki.add(x);

            }
            else if (x == 3)
            {
                trojki.add(x);
            }
        }
        dane.clear();
        debug.log("dane" + dane.count);




















    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
