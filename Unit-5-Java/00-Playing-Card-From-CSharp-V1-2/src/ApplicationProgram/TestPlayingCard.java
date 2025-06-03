package ApplicationProgram; // Java is organized in packages
                            // C# is organized using namespaces
                            // Java PackageName should match the folder containing the
                            //      package components

import PlayingCard.PlayingCard;

public class TestPlayingCard {
    // C3 Main() is spelled with uppercase M
    //  string may be spelled with lowercase or uppercase "S"
    //  (uppercase was added in .Net version 6)
    // Console.WriteLine() to display a line to screen

    //Java: main() is spelled with a lowercase "m"
    //      String is always spelled with uppercase "S"
    //      (because it is a Class - has data methods)
    //      System.out.println() to display a line to the screen

    public static void main(String[] args) {

        System.out.println("Hello, World!");

        //Define an Ace of Spades
        //Syntac is just like in C3
        // Class    objectName  = new ClassName(); // Calling a constructor for the class
        PlayingCard aceOfSpades = new PlayingCard(PlayingCard.CardValue.Ace, PlayingCard.CardSuit.Spade);

    } // End of main() method
} // End of TestPlayingCard CLass