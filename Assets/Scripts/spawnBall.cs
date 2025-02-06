using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction.OVR.Input;
using UnityEngine;

public class spawnBall : MonoBehaviour
{
    public GameObject prefab;
    public float spawnSpeed = 5;
    public OVRInput.RawButton shootingButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(shootingButton))
        {
            GameObject spawnedBall = Instantiate(prefab, transform.position, Quaternion.identity);
            Rigidbody spawnBallRB = spawnedBall.GetComponent<Rigidbody>();
            spawnBallRB.velocity = transform.forward*spawnSpeed;
        }
    }
}
