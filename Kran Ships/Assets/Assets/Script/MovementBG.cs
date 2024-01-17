using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBG : MonoBehaviour
{
    [Range(-2f, 1f)] // Zar�wno jest to suwak, jak i ogranicznik warto�ci zadklarowanych zmiennych, 
    public float scrollSpeed = 0.5f; // Bazowa pr�dko�� scrolowania 
    private float ofset; //Suma scrollu w danym kiernku potrzebnego do SetTextureoffest
    private Material mat; 

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        ofset += (Time.deltaTime * scrollSpeed) / 10f;
        mat.SetTextureOffset("_MainTex",new Vector2(ofset,0));
        //Dzi�ki pobraniu Rendereru.material mo�emy ustawi� teksture kt�r� chcemy porusza� "_MainTex" jest lokaln� tekstur� do przemieszczania 
        //SetTextureOffset - Metoda Pozwalaj�ca przesuwa� tekstury X/Y na obiektcie. 
    }
}
    