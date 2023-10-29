using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject fruitPrefab;

    void Start()
    {
        fruitPrefab = Resources.Load<GameObject>("Prefabs/Fruits");
        GameObject fruit = Instantiate(fruitPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        fruit.AddComponent<Fruits>();
        fruit.GetComponent<Fruits>().setNumber(5);
    }

    void Update()
    {

    }
}
