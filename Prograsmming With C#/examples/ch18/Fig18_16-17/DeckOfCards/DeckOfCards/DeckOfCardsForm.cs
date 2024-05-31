// Fig. 18.17: DeckForm.cs
// Simulating card shuffling and dealing.
using System;
using System.Windows.Forms;

namespace DeckOfCards
{
   public partial class DeckOfCardsForm : Form
   {
      private Card[] deck = new Card[ 52 ]; // deck of 52 cards
      private int currentCard; // count which card was just dealt
      // default constructor
      public DeckOfCardsForm()
      {
         // Required for Windows Form Designer support
         InitializeComponent();
      } // end constructor

      // handles form at load time
      private void DeckForm_Load( object sender, EventArgs e )
      {
         string[] faces = { "Ace", "Deuce", "Three", "Four", "Five",
            "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen",
            "King" };
         string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

         currentCard = -1; // no cards have been dealt

         // initialize deck
         for ( int i = 0; i < deck.Length; i++ )
            deck[ i ] = new Card( faces[ i % 13 ], suits[ i / 13 ] );
      } // end method DeckForm_Load

      // handles dealButton Click
      private void dealButton_Click( object sender, EventArgs e )
      {
         Card dealt = DealCard();

         // if dealt card is null, then no cards left
         // player must shuffle cards
         if ( dealt != null )
         {
            displayLabel.Text = dealt.ToString();
            statusLabel.Text = "Card #: " + currentCard;
         } // end if
         else
         {
            displayLabel.Text = "NO MORE CARDS TO DEAL";
            statusLabel.Text = "Shuffle cards to continue";
         } // end else
      } // end method dealButton_Click

      // shuffle cards
      private void Shuffle()
      {
         Random randomNumber = new Random();
         Card temporaryValue;

         currentCard = -1;

         // swap each card with randomly selected card (0-51)
         for ( int i = 0; i < deck.Length; i++ )
         {
            int j = randomNumber.Next( 52 );

            // swap cards
            temporaryValue = deck[ i ];
            deck[ i ] = deck[ j ];
            deck[ j ] = temporaryValue;
         } // end for

         dealButton.Enabled = true; // shuffled deck can now deal cards
      } // end method Shuffle

      // deal a card if the deck is not empty
      private Card DealCard()
      {
         // if there is a card to deal then deal it
         // otherwise signal that cards need to be shuffled by
         // disabling dealButton and returning null
         if ( currentCard + 1 < deck.Length )
         {
            currentCard++; // increment count
            return deck[ currentCard ]; // return new card
         } // end if
         else
         {
            dealButton.Enabled = false; // empty deck cannot deal cards
            return null; // do not return a card
         } // end else
      } // end method DealCard

      // handles shuffleButton Click
      private void shuffleButton_Click( object sender, EventArgs e )
      {
         displayLabel.Text = "SHUFFLING...";
         Shuffle();
         displayLabel.Text = "DECK IS SHUFFLED";
      } // end method shuffleButton_Click
   } // end class DeckForm
}

/**************************************************************************
 * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/