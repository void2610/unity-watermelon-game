using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NWaterMelonGame;

public class Fruit : MonoBehaviour
{
    public FruitTable fruitsTable;
    private List<FruitTable.FruitData> fruitData;
    private int number = -1;
    private float radius = 1;
    private Color color = Color.red;

    public void setNumber(int number)
    {
        if (number == -1) return;
        fruitsTable = Resources.Load<FruitTable>("ScriptableObjects/FruitTable");
        fruitData = fruitsTable.FruitList;

        this.number = number;
        this.radius = fruitData[number - 1].radius;
        this.color = fruitData[number - 1].color;

        this.transform.localScale = new Vector3(radius, radius, radius);
        this.GetComponent<Renderer>().material.color = color;
        Debug.Log(color);
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
