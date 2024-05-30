using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesManager : MonoBehaviour
{
    public GameObject[] cubes;
    public int currentIndex = -1;
    // Start is called before the first frame update
    void Start()
    {
        //Desactivar todos los elemtos del array
        DeactivateAll();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        { 
            currentIndex++;
            if(currentIndex >= cubes.Length)
            {
                currentIndex = 0;
            }
            DeactivateAll();
            ActivaByIndex(currentIndex);
        }
    }

    void DeactivateAll()
    {
        for (int i = 0; i < cubes.Length; i++)
        {
            cubes[i].SetActive(false);
        }
    }

    void ActivaByIndex(int index)
    {
        cubes[index].SetActive(true);
    }
}
