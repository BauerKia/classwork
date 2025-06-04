package ApplicationProgram;

import PlayingCard.PlayingCard;
import CardDeck.CardDeck;

public class TestCardDeck {
//
    public static void main(String[] args) {

        System.out.println("Welcome to my Second Java program!");

        //Instantiate a CardDeck
        CardDeck aCardDeck = new CardDeck();

        //Display all the cardsin the deck
        aCardDeck.showDeck();

        System.out.println("\n ---- Removing Jokers ----");

        aCardDeck.removeJokers();
        aCardDeck.showDeck();

        PlayingCard aCard = aCardDeck.dealCard();
        aCard.showCard();

        aCardDeck.shuffleDeck();


    } // End of main() method
} // End of TestPlayingCard CLass