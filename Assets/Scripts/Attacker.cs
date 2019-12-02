using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{

    [Range(0f,5f)] float currentSpeed = 1f;
    [SerializeField] int health = 10;
    [SerializeField] GameObject deathVFX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * currentSpeed);
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void ProcessDamage(int damage)
    {
        DealDamage(damage);
    }

    private void DealDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
           GameObject deathVFXObject = Instantiate(deathVFX, transform.position, transform.rotation);
           Destroy(gameObject); 
           Destroy(deathVFXObject, 1f);
        }
    }
}
