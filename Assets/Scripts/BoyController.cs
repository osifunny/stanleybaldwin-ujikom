using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class BoyController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private KeyCode A;
    [SerializeField] private KeyCode D;
    [SerializeField] private KeyCode space;

    void Update()
    {
        MoveSet();
    }

    public void MoveSet()
    {
        
    }
}