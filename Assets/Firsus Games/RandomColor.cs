using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    public Material material;
    private void Awake()
    {
        material = this.GetComponent<Renderer>().material;
        var r = Random.Range(0, 255)/100;
        var g = Random.Range(0, 255)/100;
        var b = Random.Range(0, 255)/100;
        material.color = new Color(r, g, b, 1);
    }
}
