using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    private int number = -1;
    private float radius = 1;
    private Color color = Color.red;

    public void setNumber(int number)
    {
        if (number == -1) return;
        this.number = number;
        this.radius = number;
        this.transform.localScale = new Vector3(radius, radius, radius);
        this.GetComponent<Renderer>().material.color = color;
    }

    public int getNumber()
    {
        return this.number;
    }

    void Awake()
    {

    }

    void Start()
    {

    }

    void Update()
    {

    }
}
