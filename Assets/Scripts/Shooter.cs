using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;
    [SerializeField] int projectileDamage = 10;
    
    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, gun.transform.rotation);
        return;
    }

}
