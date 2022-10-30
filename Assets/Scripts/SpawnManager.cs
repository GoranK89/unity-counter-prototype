using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  public GameObject[] projectiles;

  // Start is called before the first frame update
  void Start()
  {
    StartCoroutine(SpawnTimer(1f));
  }

  private void SpawnProjectile()
  {
    Instantiate(projectiles[Random.Range(0, projectiles.Length)], new Vector3(0, 15, Random.Range(-8f, 8f)), transform.rotation);
  }

  IEnumerator SpawnTimer(float waitTime)
  {
    while (true)
    {
      yield return new WaitForSeconds(waitTime);
      SpawnProjectile();
    }
  }

}
