using UnityEngine;

public class HelloWorldAssingmentComplete : MonoBehaviour
{
    // To complete this assignment,
    // write your code in the lines named "Write (#) here".
    //
    // DO NOT CHANGE existing lines of code!
    // You will only need to ADD new lines of code to complete the assignment.
    void Start()
    {
        // 1
        // Print "Hello World!" to the console.
        //
        // Expected output:
        //      Hello World!
        
        // Write (1) here.


        // 2
        // Write a statement that ADDS the values of bonus and attack, and assigns the value to attack.
        //
        // Expected output:
        //      New attack : 15
        float attack = 10.0f;
        float bonus = 5.0f;

        // Write (2) here.

        Debug.Log("New attack : " + attack); 


        // 3
        // Write a statement that checks if attack is higher than defense, and stores the result in a boolean named attackSuccessful.
        //
        // Expected output:
        //      Is attack higher than defense? : True
        float defense = 11.0f;
        bool attackSuccessful = false;

        // Write (3) here.

        Debug.Log("Is attack higher than defense? : " + attackSuccessful);


        // 4 
        // Write BRANCHING statements that do the following:
        //      If the attack was successful:
        //              subtract playerDamage from enemyHealth.
        //              log successMessage and the value of enemyHealth to the Console.
        //      If the attack was NOT successful:
        //              subtract enemyDamage from playerHealth.
        //              log failureMessage and the value of playerHealth to the Console.
        //
        // Expected output:
        //      Attack succeeded! Enemy health : 0.0f
        float playerDamage = 2.0f;
        float enemyDamage = 1.0f;

        float playerHealth = 5.0f;
        float enemyHealth = 2.0f;

        string successMessage = "Attack succeeded! Enemy health : ";
        string failureMessage = "Attack failed! Player health : ";

        // Write (4) here.


        // 5
        // Write BRANCHING statements that do the following:
        //      If attack was GREATER than defense PLUS 10, AND the enemyHealth is LESS THAN OR EQUAL TO to 0:
        //          Log the criticalSuccess message to the Console.
        //      Otherwise, if enemyHealth is LESS THAN OR EQUAL TO 0:
        //          Log the normalSuccess message to the Console.
        //      If neither of these conditions are true:
        //          Log the enemyAlive message to the Console.
        //
        // Expected output:
        //      You vanquished the enemy!
        string criticalSuccess = "You vanquished the enemy with a CRITICAL HIT!";
        string normalSuccess = "You vanquished the enemy!";
        string enemyAlive = "The enemy is still alive!";

        // Write (5) here.
    }

}
