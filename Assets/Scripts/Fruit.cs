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
    private bool isInvincible = false;

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
    }

    public int getNumber()
    {
        return this.number;
    }

    void Awake()
    {
        isInvincible = true;
    }

    void Start()
    {

    }

    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<Fruit>() == null) return;
        if (other.gameObject.GetComponent<Fruit>().getNumber() > 1) return;

        Debug.Log(this.gameObject.name + " " + other.gameObject.name);
        if (other.gameObject.GetComponent<Fruit>().getNumber() == this.number)
        {
            GameManager.instance.CreateFruit(this.number + 1, this.transform.position);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
