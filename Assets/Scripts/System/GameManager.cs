using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Bartender bartender;
    public CustomerController customerController;

    [Button]
    public void StartGame()
    {
        customerController.GenerateCustomerList();
    }

    [Button]
    public void ServeCocktail()
    {
        Customer customer = customerController.GetCurrentCustomer();
        Cocktail cocktail = bartender.GetCocktail();
        customer.JudgeCocktail(cocktail);
        customerController.IncrementCustomer();
        if(customerController.Completed())
            EndGame();
    }

    private void EndGame()
    {
        
    }
}