using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject fruitPrefab;

    private void CreateFruit(int number)
    {
        GameObject fruit = Instantiate(fruitPrefab, new Vector3(0, number, 0), Quaternion.identity);
        fruit.AddComponent<Fruit>();
        fruit.GetComponent<Fruit>().setNumber(number);
    }

    void Awake()
    {
        fruitPrefab = Resources.Load<GameObject>("Prefabs/Fruit");
    }

    void Start()
    {
        CreateFruit(1);
        CreateFruit(2);
        CreateFruit(3);
        CreateFruit(4);
        CreateFruit(5);
        CreateFruit(6);
        CreateFruit(7);
        CreateFruit(8);
        CreateFruit(9);
        CreateFruit(10);
    }

    void Update()
    {

    }
}
