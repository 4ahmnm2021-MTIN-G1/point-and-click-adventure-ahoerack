using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magier : MonoBehaviour
{
        public string nameOfCharacter = "abc";
        public int ageOfCharacter = 7;
        public float sizeOfCharacter = 5.8f;
        public bool isAlive = false;
        public Camera cam;
        public GameObject go;
    // Start is called before the first frame update
    public void Start()
    {
        sizeOfCharacter = 6.2f;
        ageOfCharacter = 15;
        nameOfCharacter = "def";
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
