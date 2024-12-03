using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    float dailyFoodConsumption;
    int activitylevel;



    
    public override float CalculateFoodRequirement()
    {
        activitylevel = 7;
        dailyFoodConsumption = 0.5f;
        Debug.Log($"{animalName} eat : {dailyFoodConsumption} kg of food dailty with activity :{activitylevel} ");
        Debug.Log($"{animalName}'s weekly food requirement:{dailyFoodConsumption * activitylevel * 7} kg.");
        return dailyFoodConsumption;
    }



    public virtual void Sound()
    {
        base.MakeSound();
        Debug.Log($"สนุขร้อง : Woof woof!!");
    } 

    // Start is called before the first frame update
    public void Start()
    {
        Init("Dog");
        DisplayName();
        Sound();
        CalculateFoodRequirement();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
