using System.Collections;
using JetBrains.Annotations;
using UnityEngine;

public class Gakster : MonoBehaviour
{
    public float Speed = 5f;
    public float HitDistance = 2;
    public float Health = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    IEnumerator Need4Speed()
    {
        yield return new WaitForSeconds(0.2f);
        Speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1, 0, 0) * Time.deltaTime * Speed;


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Speed = 0f;
            StartCoroutine(Need4Speed());
            
        }
    }

    public void TakeDamage(int Ammount)
    {
        Health -= Ammount;
        if (Health < 0f)
        {
            Destroy(gameObject);
        }
    }
}
