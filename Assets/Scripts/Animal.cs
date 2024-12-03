using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;
    public string AnimalName {  get { return animalName; } }
    

    public void Init(string Name)
    {
        animalName = Name;
        
    }

    public abstract float CalculateFoodRequirement();

    public virtual void MakeSound() 
    {
        Debug.Log($"The animal makes a sound.");
    }

    public void DisplayName() 
    {
        Debug.Log($"This is a :{animalName}");
    } 
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
