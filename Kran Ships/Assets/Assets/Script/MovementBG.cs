using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBG : MonoBehaviour
{
    [Range(-2f, 1f)] // Zarówno jest to suwak, jak i ogranicznik wartoœci zadklarowanych zmiennych, 
    public float scrollSpeed = 0.5f; // Bazowa prêdkoœæ scrolowania 
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
        //Dziêki pobraniu Rendereru.material mo¿emy ustawiæ teksture któr¹ chcemy poruszaæ "_MainTex" jest lokaln¹ tekstur¹ do przemieszczania 
        //SetTextureOffset - Metoda Pozwalaj¹ca przesuwaæ tekstury X/Y na obiektcie. 
    }
}
    