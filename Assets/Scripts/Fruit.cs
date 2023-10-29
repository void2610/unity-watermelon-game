using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
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

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.GetComponent<Fruit>() != null)
        {
            if (other.gameObject.GetComponent<Fruit>().getNumber() == this.number)
            {
                Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
        }
    }
}
