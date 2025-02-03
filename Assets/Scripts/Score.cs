using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject objectX; //Reference to the target object
    float rotationX; //Rotation at start
    float rotationZ; //Rotation at start
    public TMP_Text scoreText; //Text
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        //Rotation at start
        rotationX = objectX.transform.eulerAngles.x;
        rotationZ = objectX.transform.eulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        //Checking if rotation exceeds 20 degrees -> if so: add point, delete the target
        if (objectX.transform.eulerAngles.x > rotationX + 20f || objectX.transform.eulerAngles.x < rotationX - 20f)
        {
            score = int.Parse(scoreText.text);
            score = score + 1;
            scoreText.text = score.ToString();
            Destroy(gameObject);
        }
        if (objectX.transform.eulerAngles.z > rotationZ + 20f || objectX.transform.eulerAngles.z < rotationZ - 20f)
        {
            score = int.Parse(scoreText.text);
            score = score + 1;
            scoreText.text = score.ToString();
            Destroy(gameObject);
        }
    }


}
