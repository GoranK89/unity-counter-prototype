using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private float moveSpeed = 10;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    movePlayer();
  }

  private void movePlayer()
  {
    if (Input.GetKey("a"))
    {
      transform.Translate(new Vector3(0f, 0f, 1f) * -moveSpeed * Time.deltaTime);
    }
    if (Input.GetKey("d"))
    {
      transform.Translate(new Vector3(0f, 0f, 1f) * moveSpeed * Time.deltaTime);
    }
  }
}
