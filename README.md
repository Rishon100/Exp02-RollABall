# Exp02-RollABall
## AIM :
 To Roll a Ball using C# program in unity .
## ALGORITHM 
## Step 1 :
Open Unity and create a New Project.

## Step 2 :
In the Hierarchy, right-click and select 3D Object > Plane, select 3D Object > Sphere (this will be your rolling ball).

## Step 3 :
Add a Rigidbody component to the ball:
Select Player in the Hierarchy and In the Inspector, click Add Component > Search for Rigidbody > Add it.

## Step 4 :
Assets -> Create -> # Script 

## Step 5 :
Create a folder name Coding and create a C# file to add the coding in it.

## Step 6 :
To attach the C# script to a selected object, click on the script file and drag it onto the desired object in the Hierarchy window, then run the application.

## Step 7 :
Play the Game – Control the ball using Arrow Keys or WASD.

## Step 8 :
Stop

## PROGRAM :
```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roll : MonoBehaviour
{
    // Start is called before the first frame update
    public float xforce = 5.0f, yforce = 200.0f, zforce = 5.0f;
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        float x = 0.0f, y = 0.0f, z = 0.0f;
        if (Input.GetKey(KeyCode.A))
        {
            x = x - xforce;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x = x + xforce;
        }
        if (Input.GetKey(KeyCode.W))
        {
            z = z + zforce;
        }
        if (Input.GetKey(KeyCode.S))
        {
            z = z - zforce;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            y = yforce;
        }
        GetComponent<Rigidbody>().AddForce(x, y, z);

    }
}
```
## OUTPUT :
![alt text](<Screenshot 2025-04-22 113424.png>)
![alt text](<Screenshot 2025-04-22 114652.png>)
## RESULT :
Thus the experiment was successful. The ball moved as expected using Rigidbody physics and force-based movement.
