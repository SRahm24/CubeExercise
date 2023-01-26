using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{


    public GameObject cubePreFab;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        //Instantiate(cubePreFab);
        GameObject CubeGO = Instantiate<GameObject>(cubePreFab);
        Material cubeMaterial = CubeGO.GetComponent<Renderer>().material;
        cubeMaterial.color = UnityEngine.Random.ColorHSV(0, 1, 0.5f, 1, 0.75f, 1);

    }
}
