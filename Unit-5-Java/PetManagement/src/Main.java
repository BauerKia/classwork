import Pet.Pet; //Give us access to the Pet class stuff

import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        //TIP Press <shortcut actionId="ShowIntentionActions"/> with your caret at the highlighted text
        // to see how IntelliJ IDEA suggests fixing it.
        System.out.printf("Welcome to Pet Managment!");

        // Instantiate a Pet
        Pet cat1 = new Pet(" James", "Cat", 'M', 30, true);

    cat1.displayPet();

    // Instantiate a Pet from the User input - Java uses Scanner for keyboard input
        // Scanner is a class to scan data and break it into variables
        //System.in is a Java defined object to represent the keyboard

        Scanner theKeyboard = new Scanner(System.in); //Create a scanner for the keyboard
        System.out.println("\nWhat is the name of your pet?");
        String thePetName = theKeyboard.nextLine(); // nextLine gets the a line from the keyboard

        System.out.println("\nWhat is the type of your pet?");
        String thePetType = theKeyboard.nextLine(); // nextLine gets the a line from the keyboard

        System.out.println("\nWhat is the gender of your pet?");
        String thePetG = theKeyboard.nextLine(); // nextLine gets the a line from the keyboard

        System.out.println("\nWhat is the weight of your pet?");
        String thePetW = theKeyboard.nextLine(); // nextLine gets the a line from the keyboard

        System.out.println("\nIs your pet spayed or neutered?");
        String thePetSN = theKeyboard.nextLine(); // nextLine gets the a line from the keyboard

        //Instantiate a pet from user input
        //Convert the data required that is not a String to the right type

        char petGender = thePetG.charAt(0); //Take the first char of the String
        int petWeight = Integer.parseInt(thePetW); // Convert the weight from String to int

        boolean petSpayed = false; //assume the pet is not spayed
        if (thePetSN.equals("Y")) { // if it is spayed....
        petSpayed = true;           // set the variable to true
        }

        Pet pet1 = new Pet(thePetName, thePetType, petGender, petWeight, petSpayed);
        pet1.displayPet();
    }
}