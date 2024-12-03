using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    float dailyFoodConsumption;
    float weigth;



    
    public override float CalculateFoodRequirement()
    {
        weigth = 0.8f;
        dailyFoodConsumption = 0.2f;
        Debug.Log($"{animalName} eats {dailyFoodConsumption} kg of food daily and weight {weigth} kg");
        Debug.Log($"{animalName}'s weekly food requiremant :{dailyFoodConsumption * weigth * 7}kg");
        return dailyFoodConsumption;
    }



    public virtual void Sound()
    {
        base.MakeSound();
        Debug.Log($"{animalName} say : Caek Caek!!");
    }




    // Start is called before the first frame update
    void Start()
    {
        Init("Bird");
        DisplayName();
        Sound();
        CalculateFoodRequirement();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
