using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControl : MonoBehaviour
{
    
    const int NUM_MPL_JOINT_ANGLES = 7;
    private vMPLMovementArbiter arbiter = null;

    //an array created for controlling the rotation of different joints on vMPL. 
    //The 1st and 4th element in the array, i.e. joint_angles[0] and joint_angles[3], represent the joint angle that upper-arm and forearm rotates in frame respectively
    private float [] joint_angles = new float[NUM_MPL_JOINT_ANGLES];

    // Start is called before the first frame update
    void Start()
    {
        arbiter = GameObject.Find("vMPLMovementArbiter").GetComponent<vMPLMovementArbiter>();
    }

    // Update is called once per frame
    void Update()
    {
        // control channel selection
      

        // Rotation through keyboard control
      
        


        //Transfer the rotation angles to vMPL
        arbiter.SetRightUpperArmAngles( joint_angles );

       

       
    }
}
