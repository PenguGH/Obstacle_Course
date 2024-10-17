// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Dropper : MonoBehaviour
// {
//     new MeshRenderer renderer;
//     new Rigidbody rigidbody;
//     [SerializeField] float timeToWait;

//     // Start is called before the first frame update
//     void Start()
//     {
//         renderer = GetComponent<MeshRenderer>();
//         rigidbody = GetComponent<Rigidbody>();


//         // used to get an object
//         // want to get the box around it.
//         // dont want object to be visible to the player.
//         renderer.enabled = false;

//         // dont want to use gravity. dont want falling cube immediately
//         // rigidbody deals with the gravity, physics.
//         rigidbody.useGravity = false;


//         // GetComponent<MeshRenderer>().enabled = false;
//         // GetComponent<Rigidbody>().useGravity = false;
//     }

//     // Update is called once per frame
//     void Update()
//     {   
//         if(Time.time > timeToWait){
//             renderer.enabled = true;
//             rigidbody.useGravity = true;
//         }
//     }
// }
