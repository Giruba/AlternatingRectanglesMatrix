# AlternatingRectanglesMatrix
C# program for printing alternate rectangles of X and 0

Problem Statement: Given the number of rows and columns of a matrix, print a matrix with alternating rectangles of X and 0

Example: Let's say the no of rows = 6 and the no of columns = 7

The resultant matrix printed should be 

X X X X X X X
X 0 0 0 0 0 X
X 0 X X X 0 X
X 0 X X X 0 X
X 0 0 0 0 0 X
X X X X X X X


Logic: Print outer rectangle
       Print inner rectangles
       
       
Details of Logic:
  
  1. Fix m=0 [Index of Rows] and n=0 [Index of Columns] and loop until m<rows and n<columns
  2. Print current row by varying n
  3. Since a row is processed, increment m
  4. Print last column by varyng m
  5. Decrement columns as a column is processed
  6. Check whether n is still less than columns and if yes, print the last row varying n
     Decrement rows as a rows has been processed
  7. Check whether m is still less than rows and if yes, print the column entries varying m
  
  Repeat until loop exits.
