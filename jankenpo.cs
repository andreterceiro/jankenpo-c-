using System;

public class Jankenpo
{
    public static void Main(string[] args) {
        Console.WriteLine ("Jankenpo");
        Console.WriteLine ("########\n");
        Char userChoice = Jankenpo.getUserChoice()[0];
        Char computerChoice = getComputerChoice();

        Console.WriteLine("");

        if (userChoice == computerChoice) {
            Console.WriteLine("Draw!");
        } else if ((userChoice == 'p' && computerChoice == 'r') || (userChoice == 'r' && computerChoice == 's') || (userChoice == 's' && computerChoice == 'p')) {
            Console.WriteLine("User win!");
        } else {
            Console.WriteLine("Computer win!");   
        }

        Console.WriteLine("");

        Console.WriteLine("Computer selected: " + getCompleteStringChoice(computerChoice));
        Console.WriteLine("User selected: " + getCompleteStringChoice(userChoice));   
    }

    static String getUserChoice() {
        String userChoice = " ";

        while (userChoice != "p" && userChoice != "r" & userChoice != "s") {
            Console.WriteLine("Please type 'p' for paper or 'r' for rock or 's' for scissors: ");
            userChoice = Console.ReadLine();
        }
        return userChoice;
    }

    static Char getComputerChoice() {
        Random randomNumber = new Random();
        int integerComputerChoice = randomNumber.Next() % 3;

        if (integerComputerChoice == 0) {
            return 'p';
        } else if (integerComputerChoice == 1) {
            return 'r';
        }
        return 's';
    }

    static String getCompleteStringChoice(Char choice) {
        if (choice == 'p') {
            return "Paper";
        } else if (choice == 'r') {
            return "Rock";
        }
        return "Scissors";
    }
}