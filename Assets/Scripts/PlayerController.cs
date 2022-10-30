using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private Rigidbody playerRB;
  private Vector3 moveDirection;
  private float moveSpeed = 11f;
  private float maxPosRight = 10f;
  private float maxPosLeft = 15f;

  // Start is called before the first frame update
  void Awake()
  {
    playerRB = GetComponent<Rigidbody>();

  }

  void Update()
  {
    float moveZ = 0f;

    if (Input.GetKey(KeyCode.A))
    {
      if (transform.position.z >= -maxPosLeft)
      {
        moveZ = -1f;
      }

    }
    if (Input.GetKey(KeyCode.D))
    {
      if (transform.position.z <= maxPosRight)
      {
        moveZ = +1f;
      }

    }

    moveDirection = new Vector3(0, 0, moveZ).normalized;
  }
  // Update is called once per frame
  void FixedUpdate()
  {
    playerRB.velocity = moveDirection * moveSpeed;
  }
}
