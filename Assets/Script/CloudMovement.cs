using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float speed = 21f;
    private float distanceBeforeRotation = 200f;
    private float rotationAngle = 90f;
    public GameObject myPrefab;
    private bool isStart = true;

    public float distanceTraveled = 0f;

    private void Update()
    {
        //Instantiate
        int random = Random.Range(0, 500);

        if (random == 1)
        {
            Instantiate(myPrefab, transform.position, Quaternion.identity);
        }

        // Track distance traveled
        distanceTraveled += speed * Time.deltaTime;

        // Move the object forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //First turn
        if ((isStart == true) && (distanceTraveled >= 80))
        {
            RotateCar();
            isStart = false;
        }

        // Check if the object has traveled the specified distance
        if (distanceTraveled >= distanceBeforeRotation)
        {
            RotateCar();
        }

        void RotateCar()
        {
            transform.Rotate(Vector3.up, rotationAngle);
            distanceTraveled = 0f;
        }
    }
}
