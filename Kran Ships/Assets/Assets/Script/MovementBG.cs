using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBG : MonoBehaviour
{
    [Range(-2f, 1f)]
    public float scrollSpeed = 0.5f;
    private float ofset;
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
    }
}
