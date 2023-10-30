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
    private bool isChecking = false;

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

    public bool getIsCheking()
    {
        return this.isChecking;
    }

    public bool getIsInvincible()
    {
        return this.isInvincible;
    }

    public void setIsCheking(bool isChecking)
    {
        this.isChecking = isChecking;
    }

    public void setInvincible(bool isInvincible)
    {
        this.isInvincible = isInvincible;
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
        if (other.gameObject.GetComponent<Fruit>()?.getIsCheking() == true || this.isChecking == true) return;
        if (other.gameObject.GetComponent<Fruit>() == null) return;
        if (other.gameObject.GetComponent<Fruit>().getNumber() > 11) return;
        if (this.isInvincible == true || other.gameObject.GetComponent<Fruit>().getIsInvincible() == true) return;


        if (other.gameObject.GetComponent<Fruit>().getNumber() == this.number)
        {
            this.isChecking = true;
            other.gameObject.GetComponent<Fruit>().setIsCheking(true);
            GameManager.instance.CreateFruit(this.number + 1, this.transform.position);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
