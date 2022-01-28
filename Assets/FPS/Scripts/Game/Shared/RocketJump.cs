using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketJump : MonoBehaviour
{
    public float knockbackSpeed = 4f;
    public float playerMass = 3f;
    public Vector3 knockbackImpact = Vector3.zero;

    public CharacterController characterController;

    private void Start()
    {

        //characterController.GetComponent<CharacterController>();

    }

    private void Update()
    {
        // This is to move the player if they are affected by a rocket explosion
        if (knockbackImpact.magnitude > 0.2f)
        {
            characterController.Move(knockbackImpact * Time.deltaTime);
            // moves the character between two vector3 locations per second
            knockbackImpact = Vector3.Lerp(knockbackImpact, Vector3.zero, knockbackSpeed * Time.deltaTime);
        }
    }
    // function to apply force to the player when hit by a rocket explosion
    public void Knockback(Vector3 direction, float force)
    {
        direction.Normalize();
        if (direction.y < 0) direction.y = -direction.y; // reflect down force on the ground
        knockbackImpact += direction.normalized * force / playerMass;
    }
}
