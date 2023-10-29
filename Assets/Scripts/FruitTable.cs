using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NWaterMelonGame
{

    [CreateAssetMenu]
    public class FruitTable : ScriptableObject
    {
        [System.Serializable]
        public class FruitData
        {
            public Color color;
            public float radius;
        }

        [SerializeField]
        private List<FruitData> fruitList = new List<FruitData>();

        public List<FruitData> FruitList { get { return fruitList; } }
    }

}
