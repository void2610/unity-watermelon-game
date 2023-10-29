using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject fruitPrefab;

    public void CreateFruit(int number)
    {
        GameObject fruit = Instantiate(fruitPrefab, new Vector3(0, number, 0), Quaternion.identity);
        fruit.AddComponent<Fruit>();
        fruit.GetComponent<Fruit>().setNumber(number);
    }

    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        fruitPrefab = Resources.Load<GameObject>("Prefabs/Fruit");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CreateFruit(1);
        }
    }
}
