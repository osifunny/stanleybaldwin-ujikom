using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    [SerializeField] private GameObject cow;
    [SerializeField] private GameObject deer;
    [SerializeField] private GameObject dog;
    [SerializeField] private GameObject horse;

    void Start()
    {
        //StartCoroutine(CountDown(), 2);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void CallAnimal()
    {
        int x = Random.Range(0, 3);
        if (x == 0) Instantiate(cow, cow.transform);
        else if (x == 1) Instantiate(deer, deer.transform);
        else if (x == 2) Instantiate(horse, horse.transform);
        else Instantiate(dog, dog.transform);
    }

    //public IEnumerator CountDown()
    //{
    //    yield return CallAnimal();
    //}
}
