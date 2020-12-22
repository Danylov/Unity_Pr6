using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float speed = 1.0f;
    private const float periodChangeScale = 1.0f;
    private float oldTime = 0.0f;
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
        if (periodChangeScale < (Time.time - oldTime)) {
            var curScale = Random.Range(0.2f, 1.0f);
            transform.localScale = new Vector3(curScale, curScale, curScale);
            oldTime = Time.time;
        }
    }
}