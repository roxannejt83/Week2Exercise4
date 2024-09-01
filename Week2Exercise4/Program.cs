using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise4
{
    internal class ATM // Declare class that contains the main method where the execution starts
    {
        static void Main(string[] args)
        {
            double balance = 1000.0; // Initialize the initial balnce to 1000
            int choice; // Variable to store user input
            do // Use a do-while loop to keep showing the menu until the user exits
            {
                //Display the ATM menu
                Console.WriteLine("ATM Menu"); // Display ATM menu title
                Console.WriteLine("1. Check Balance"); // Display option 1
                Console.WriteLine("2. Deposit"); // Display option 2
                Console.WriteLine("3. Withdraw"); // Display option 3
                Console.WriteLine("4. Exit"); // Display option 4
                choice = Convert.ToInt32(Console.ReadLine()); // Read the user's choice and convert it to an integer
                switch (choice) // Use a switch statement to handle the user's choice
                {
                    case 1: // Check balance
                        Console.WriteLine($"Your current balance is: ${balance}"); // Display user's balance
                        break; // Jump out of switch statement
                    case 2: // Deposit
                        Console.Write("Enter the amount to deposit: "); // Prompts user to enter deposit amount
                        double depositAmount = Convert.ToDouble(Console.ReadLine()); // Reads deposit amount from user and converts to a double
                        balance += depositAmount; // Update the balance with the deposit amount
                        Console.WriteLine($"You have deposited: ${depositAmount}"); // Displays the amount deposited
                        Console.WriteLine($"Your new balance is: ${balance}"); // Displays the amount after deposit
                        break; // Jump out of switch statement
                    case 3: // Withdraw
                        Console.Write("Enter the amount to withdraw: "); // Prompts user to enter withdraw amount
                        double withdrawAmount = Convert.ToDouble(Console.ReadLine()); // Reads withdraw amount from user and converts to a double
                        if (withdrawAmount <= balance) // Check if the balance is sufficient for the withdrawal
                        {
                            balance -= withdrawAmount; // Update the balance after the withdrawal
                            Console.WriteLine($"You have withdrawn: ${withdrawAmount}"); // Displays amount user has withdrawn
                            Console.WriteLine($"Your new balance is: ${balance}"); // Displays the user's new balance
                        }
                        else // If not eneough balance, display an error message
                        {
                            Console.WriteLine("Insufficient funds.  Unable to complete the withdrawal."); // Displays insufficient funds to user
                        }
                        break; // Jump out of switch statement
                    case 4: // Exit
                        Console.WriteLine("Thank you for using the ATM.  Goodbye!"); // Displays farewell message to user
                        break; // Jump out of switch statement
                    default: // Invalid choice
                        Console.WriteLine("Invalid option.  Please select a valid option from the menu.");
                        break; // Jump out of the switch statement
                }
                Console.WriteLine(); // Display a line for better formatting
            } while (choice != 4); // Exit the loop when the user chooses option 4
            }
        }
    }
