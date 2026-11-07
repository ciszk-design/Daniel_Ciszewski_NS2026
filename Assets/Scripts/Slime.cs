using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    private const int V = 10;

    //Ta referencja jest pusta, zostaje uzupełniona podczas pierwszego HIT()
    private Rigidbody2D rb;

    public SpriteRenderer sprite;
    public Gradient hpColor;

    public float hp = 100; 

    private void Start()
    {
        hp = 100; 
    }

    //Funkcja wywoływana przy trafieniu
    public void Hit(float dmg)
    {
        if (rb == null || hp == 100)
        {
            //if first hit activate rigidbody
            rb = GetComponent<Rigidbody2D>(); 
            rb.bodyType = RigidbodyType2D.Dynamic;
        }

        hp -= dmg; 

        sprite.color = hpColor.Evaluate((hp / 100)); 

        CheckIfKill();
    }

    //Jeśli życie spadnie poniżej zera obiekt powinien zostać zniszczony
    void CheckIfKill()
    {
        if (hp <= 0) 
        {
            Destroy(gameObject);
        }
    }

    // Funkcja zwraca największego inta z listy
    public int ReturnHighNumber(List<int> data)
    {
        //return 1; 

        int high = V;

        foreach (int i in data)
        {
            if (i > V)
            {
             high = i; 
            } 
        }

        return V; 
    }

  
}