using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Vector3 position;
    public float localScaleFold;
    public Color color;
    public float rotationSpeedX;
    
    void Start()
    {
        transform.position = position;
        transform.localScale = Vector3.one * localScaleFold;       
        Material material = Renderer.material;
        material.color = new Color(color.r, color.g, color.b, color.a);
    }
    
    void Update()
    {
        transform.Rotate(rotationSpeedX * Time.deltaTime, 0.0f, 0.0f);
    }
}
