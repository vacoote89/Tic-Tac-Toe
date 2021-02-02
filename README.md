# Tic Tac Toe

Create a class TicTacToe that will enable you to write a program to play TicTac-Toe. The class contains a private 3-by-3 two-dimensional array. Use an enumeration to represent the value in each cell of the array. The enumeration's constants should be named X, O and EMPTY (for a position that does not contain an X or an O). The constructor should initialize the board elements to EMPTY. Allow two human players. Wherever the first player moves, place an X in the specified square, and place an O wherever the second player moves. Each move must be to an empty square. After each move, determine whether the game has been won and whether it’s a draw. 

You are provided a graphical layout containing 9 buttons representing the board; a reset button to clear the board and restart the game; and  label to display the winner or draw.

After a player clicks on a button, the button should be disabled. When the game ends the entire board should be disabled until the reset button is used.

**Hint: an enumeration value is accessed using the name of the enum and the name of the value, ie. Marker.X**