using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FruitTable : ScriptableObject
{
    [System.Serializable]
    public class FruitData
    {
        public string fruitName;
        public Color fruitColor;
        public float fruitRadius;
    }

    [SerializeField]
    private List<FruitData> fruitList = new List<FruitData>();

    public List<FruitData> FruitList { get { return fruitList; } }
}
