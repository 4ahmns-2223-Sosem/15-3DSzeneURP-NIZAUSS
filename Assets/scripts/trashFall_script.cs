using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;

public class trashFall_script : MonoBehaviour
{

    public GameObject trash;
    public int numObjects = 10; // Die Anzahl der zu erstellenden GameObjects
    public float interval = 3f; // Der Zeitabstand zwischen den Erstellungen

    public GameObject[] createdObjects; // Das Array, in dem die GameObjects gespeichert werden
    public int currentIndex = 0; // Der Index des aktuellen GameObjects im Array
    public float timer = 0f;




    void Start()
    {
        createdObjects = new GameObject[numObjects];
    }

    

    void Update()
    {
        

            timer += Time.deltaTime;

        

            if (timer >= interval && currentIndex < numObjects)
            {
                timer = 0f;
                CreateGameObject();
            }

      
    }

    void CreateGameObject()
    
    { 

        Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 20, Random.Range(-10, 11));
        GameObject newObject = Instantiate(trash, randomSpawnPosition, Quaternion.identity);
        createdObjects[currentIndex] = newObject;
        currentIndex++;

            
    }







}
