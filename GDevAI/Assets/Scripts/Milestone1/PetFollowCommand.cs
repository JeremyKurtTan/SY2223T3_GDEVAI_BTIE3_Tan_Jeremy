using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetFollowCommand : MonoBehaviour
{
    public Transform Player;
    float moveSpeed = 3;
    float rotationSpeed = 5;
    // Start is called before the first frame update

    private void LateUpdate()
    {
        Vector3 lookatGoal = new Vector3(Player.position.x, this.transform.position.y, Player.position.z);

        Vector3 Direction = lookatGoal - transform.position;


        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(Direction), Time.deltaTime * rotationSpeed);


        if(Vector3.Distance(lookatGoal, transform.position) > 1)
        {
            transform.Translate(0, 0, moveSpeed* Time.deltaTime);
        }
    }
}
