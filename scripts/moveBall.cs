using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBall : MonoBehaviour
{
    [SerializeField]
   
    private Vector2   speedRange;
    
    [SerializeField]

    private GameObject[] sphereArray;

    [SerializeField]
    
    private float[] speeds;

    private float startingSpeed = 1.0f;

    private Vector3 startPosition;
     
    private List<Vector3> pos;
    
    void Start() {
        startPosition = transform.position;

        speeds = new float[10];

        for (int i=0;  i < speeds.Length; i++) {
            speeds[i] = startingSpeed;
            startingSpeed += 0.1f;
        }

        for (int j = 0; j < sphereArray.Length; j++){
            pos.Add(sphereArray[j].transform.position);
        }
    }

    // Update is called once per frame
    void Update() {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizontal, 0, vertical);

        for (int i = 0; i < speeds.Length; i++) {
            sphereArray[i].transform.Translate(movement * Time.deltaTime * speeds[i]);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            for (int i = 0; i < sphereArray.Length; i++) {
                sphereArray[i].transform.position = pos[i];
            }
        }
          
    }
}
