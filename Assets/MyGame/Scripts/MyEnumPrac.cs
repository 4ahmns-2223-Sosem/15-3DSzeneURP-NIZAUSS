using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum State
{
    Done,
    WIP,
    Cancel
}

public class MyEnumPrac : MonoBehaviour
{
    //Deklaration
    State myState;

    // Start is called before the first frame update
    void Start()
    {
        myState = State.Done;

        switch (myState)
        {
            case State.Done: 
                Debug.Log(State.Done); 
                break;
            case State.WIP: 
                Debug.Log(State.WIP); 
                break;
            case State.Cancel: 
                Debug.Log(State.Cancel);
                break;
        }



        if (myState == State.Done)
        {
            Debug.Log(State.Done);
        }
        else if (myState == State.WIP)
        {
            Debug.Log(State.WIP);
        }
        else
        {
            Debug.Log(State.Cancel);
        }



        int Number = 5;
        Debug.Log("myNumber: " + Number);

        for (int i = 0; i < 10; i++)
        {
            if (i < 5)
            {
                Debug.Log("i is less than 5: " + i);
            }
            else
            {
                Debug.Log("i is greater than or equal to 5: " + i);
            }
        }

        int[] Array = { 1, 2, 3, 4, 5 };
        Debug.Log("Array[3]: " + Array[3]);

        ExampleMethod();

    }

    void ExampleMethod()
    {
        string[] Strings = { "Hello", "World" };
        Debug.Log(Strings[0] + " " + Strings[1]);
    }
}

