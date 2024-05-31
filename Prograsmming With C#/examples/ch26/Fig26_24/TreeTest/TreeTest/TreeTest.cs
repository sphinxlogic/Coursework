// Fig. 26.24: TreeTest.cs
// Testing class Tree with IComparable objects.
using System;
using BinaryTreeLibrary2;

// class TreeTest declaration
public class TreeTest
{
   // test class Tree
   public static void Main( string[] args )
   {
      int[] intArray = { 8, 2, 4, 3, 1, 7, 5, 6 };
      double[] doubleArray = { 8.8, 2.2, 4.4, 3.3, 1.1, 7.7, 5.5, 6.6 };
      string[] stringArray = { "eight", "two", "four", 
         "three", "one", "seven", "five", "six" };

      // create int Tree
      Tree intTree = new Tree();
      populateTree( intArray, intTree, "intTree" );
      traverseTree( intTree, "intTree" );

      // create double Tree
      Tree doubleTree = new Tree();
      populateTree( doubleArray, doubleTree, "doubleTree" );
      traverseTree( doubleTree, "doubleTree" );

      // create string Tree
      Tree stringTree = new Tree();
      populateTree( stringArray, stringTree, "stringTree" );
      traverseTree( stringTree, "stringTree" );
   } // end Main

   // populate Tree with array elements
   private static void populateTree( Array array, Tree tree, string name )
   {
      Console.WriteLine( "\n\n\nInserting into " + name + ":" );

      foreach ( IComparable data in array )
      {
         Console.Write( data + " " );
         tree.InsertNode( data );
      } // end foreach
   } // end method populateTree

   // insert perform traversals
   private static void traverseTree( Tree tree, string treeType )
   {
      // perform preorder traveral of tree
      Console.WriteLine( "\n\nPreorder traversal of " + treeType );
      tree.PreorderTraversal();

      // perform inorder traveral of tree
      Console.WriteLine( "\n\nInorder traversal of " + treeType );
      tree.InorderTraversal();

      // perform postorder traveral of tree
      Console.WriteLine( "\n\nPostorder traversal of " + treeType );
      tree.PostorderTraversal();
   } // end method traverseTree
} // end class TreeTest

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