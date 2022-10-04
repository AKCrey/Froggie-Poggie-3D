using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthController : MonoBehaviour
{
    public int startingHealthPoints = 3;
    public string lethalBulletTag = "ENTER LETHAL BULLET TAG HERE";
    //public AudioSource deathSoundPrefab;
    //public ExplosionController explosionPrefab;
    public bool isPlayerHealthController = false;
    public UnityEvent onDeathEvent;//UnityEvent is a list of methods inside of Unity! Reverse method sort off

    private int _currentHealthPoints = 0;

    //GameObject shield;

    //KillCounterUI killCounter = new KillCounterUI();
    

    public int GetCurrentHealth()
    {
        return _currentHealthPoints;
    }


    private void Start()
    {
        /*shield = transform.Find("Shield").gameObject;
        DeactivateShield();*/

        _currentHealthPoints = startingHealthPoints;
    }

    public void RecieveDamage(int reduceHealthBy)
    {
        if (_currentHealthPoints > 0)
        {
            _currentHealthPoints -= reduceHealthBy;
        }
        if (_currentHealthPoints <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        //We die here

        onDeathEvent.Invoke();//Call every function that is in the list

        /*int counter = KillCounterUI.counter;
        int maxKilledUnits = KillCounterUI.maxKilledUnits;
        
        if (isPlayerHealthController == true)
        {
            if (counter == maxKilledUnits)
            {
                ActivateShield();
            }
        }*/

        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other) //other == what we collide with
    {
        const int DAMAGE_POINTS = 1;

        if(other.CompareTag(lethalBulletTag))
        {

            RecieveDamage(DAMAGE_POINTS);
            
        }

    }
}
