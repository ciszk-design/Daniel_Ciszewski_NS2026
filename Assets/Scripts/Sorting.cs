using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sorting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> dane = new List<int> { 1, 3, 3, 1, 2, 2, 3, 1, 3, 2 };
        List<int> jedynki = new List<int>();
        List<int> dwojki = new List<int>();
        List<int> trojki = new List<int>();
        foreach (int liczba in dane)
        {
            if (liczba == 1)
            {
                jedynki.Add(liczba);
            }
            else if (liczba == 2)
            {
                dwojki.Add(liczba);
            }
            else if (liczba == 3)
            {
                trojki.Add(liczba);
            }
        }
        dane.Clear();
            
        Debug.Log(dane.Count);
        }
        
    }
