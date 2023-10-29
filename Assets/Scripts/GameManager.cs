using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject fruitPrefab;

    private void CreateFruit(int number)
    {
        fruitPrefab = Resources.Load<GameObject>("Prefabs/Fruit");
        GameObject fruit = Instantiate(fruitPrefab, new Vector3(0, number, 0), Quaternion.identity);
        fruit.AddComponent<Fruit>();
        fruit.GetComponent<Fruit>().setNumber(number);
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
