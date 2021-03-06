﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeleceCharacter : MonoBehaviour
{

    public GameObject[] characterList;
    private int index;

    // Start is called before the first frame update

    void Start()
    {
        characterList = new GameObject[transform.childCount];
        for(int i=0;i<transform.childCount;i++)
            characterList[i] = transform.GetChild(i).gameObject;

        foreach (GameObject go in characterList)
            go.SetActive(false);

        if (characterList[0])
            characterList[0].SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        RotateObject();
    }

    public void RotateObject()
    {
        characterList[index].transform.Rotate(0.0f, 0.8f, 0.0f);
    }

    public void ToggleLeft()
    {
        characterList[index].SetActive(false);

        index--;
        if(index < 0)
           index = characterList.Length - 1;

        characterList[index].SetActive(true);
    }
    public void ToggleRight()
    {
        characterList[index].SetActive(false);

        index++;
        if (index == characterList.Length)
            index = 0;

        characterList[index].SetActive(true);
    }
}

   
   