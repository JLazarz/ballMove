using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lecture : MonoBehaviour {
   
   [SerializeField]
   
   private Vector2   speedRange;
   
   private Transform[] items;
   
   [SerializeField]
   
   private List<Transform> itemList;

   private Dictionary<string, Transform> itemDict;
   
   private void Awake() {

        itemList = new List<Transform>();

        itemDict = new Dictionary<string, Transform>();

        for (int i = 0; i < items.Length; i++) {
            Random.Range(speedRange.x, speedRange.y);
            itemDict.Add(items[1].name, items[i]);
        }

        itemDict["Transform"].position = new Vector3(1, 2, 3);

   }

   private void Start() {
        

   }

   private void Update(){
        
        
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(1f, 0f, 0f);  
        }
        
   }

}
