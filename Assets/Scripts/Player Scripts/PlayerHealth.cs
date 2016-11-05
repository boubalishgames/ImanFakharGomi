using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    //Players Health
    public float Health;
    float MaxHealth = 100;
    float MinHealth = 0;

    //Players Hunger
    public float Hunger;
    float MaxHunger = 100;
    float MinHunger = 0;

    //Players Thirst
    public float Thirst;
    float MaxThirst = 100;
    float MinThirst = 0;

    //Players Thirst
    public float Stamina;
    float MaxStamina = 100;
    float MinStamina = 0;

    void Update()
    {
	    Health = Mathf.Clamp(Health, MinHealth, MaxHealth);
	    //Player Hunger
	    Hunger = Mathf.Clamp(Hunger, MinHunger, MaxHunger);
	    //Player Thirst
	    Thirst = Mathf.Clamp(Thirst, MinThirst, MaxThirst);
	    //Player Stamina 
	    Stamina = Mathf.Clamp(Stamina, MinStamina, MaxStamina);
    }


    public void KillPlayer()
    {
        if (Health <= MinHealth)
        {
            print("Kill Player");
        }
    }

    //Player Health
    public void DamageHealth(float Damage)
    {
        Health -= Damage;
    }
    public void HealHealth(float Heal)
    {
        Health += Heal;
    }

    //Players Hunger
    public void DamageHunger(float Damage)
    {
        Hunger -= Damage;
    }
    public void HealHunger(float Heal)
    {
        Hunger += Heal;
    }

    //Players Thirst
    public void DamageThirst(float Damage)
    {
        Hunger -= Damage;
    }
    public void HealThirst(float Heal)
    {
        Thirst += Heal;
    }

    //Players Stamina
    public void DamageStamina(float Damage)
    {
        Stamina -= Damage;
    }
    public void HealStamina(float Heal)
    {
        Stamina -= Heal;
    }

}
