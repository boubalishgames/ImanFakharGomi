using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
	
	public static PlayerHealth playerhealth;
	
    //Players Health
    public float Health = 100;
    float MaxHealth = 100;
    float MinHealth = 0;

    public Text HealthText;

    //Players Hunger
    public float Hunger = 100;
    float MaxHunger = 100;
    float MinHunger = 0;

    public Text HungerText;

    //Players Thirst
    public float Thirst = 100;
    float MaxThirst = 100;
    float MinThirst = 0;

    public Text ThirstText;

    //Players Thirst
    public float Stamina = 100;
    float MaxStamina = 100;
    float MinStamina = 0;

    public Text StaminaText;

    void OnEnable()
    {
        playerhealth = this.GetComponent<PlayerHealth>();
        HealthText = GameObject.Find("_Player UI/_Background/_Health").GetComponent<Text>();
        HungerText = GameObject.Find("_Player UI/_Background/_Hunger").GetComponent<Text>();
        ThirstText = GameObject.Find("_Player UI/_Background/_Thirst").GetComponent<Text>();
        StaminaText = GameObject.Find("_Player UI/_Background/_Stamina").GetComponent<Text>();
    }


	void Awake()
	{
		//Player Health
	    Health = Mathf.Clamp(Health, MinHealth, MaxHealth);
	    //Player Hunger
	    Hunger = Mathf.Clamp(Hunger, MinHunger, MaxHunger);
	    //Player Thirst
	    Thirst = Mathf.Clamp(Thirst, MinThirst, MaxThirst);
	    //Player Stamina 
	    Stamina = Mathf.Clamp(Stamina, MinStamina, MaxStamina);
    }

    void Update()
    {
        PlayerUI();
        DamageHunger(1 * Time.deltaTime / 50);
    }

    public void PlayerUI()
    {
        HealthText.text = "Health: " + Health.ToString("f0");
        HungerText.text = "Hunger: " + Hunger.ToString("f1");
        ThirstText.text = "Thirst: " + Thirst.ToString("f0");
        StaminaText.text = "Stamina: " + Stamina.ToString("f0");
    }

    public void OnPlayerUIToggle()
    {

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
