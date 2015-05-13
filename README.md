# BF-Game-Engine
A Game Engine for Brainf*ck

Usage
---
Step 1. Write your source code into a plain text file

Step 2. *BFEngine srcfile.dbs* (where srcfile.dbs is your source file)

Step 3. Type input into the console window

BFGE Visualizes the 1024 byte array that Brainf*ck uses in a 32x32 square grid.
To stop tearing and flashing an extra command is added "*" used for updating the screen.
Otherwise the langauge is indentical. Tutorials for learning Brainf*ck can be found online but the commands are:

1. ">" Increment the pointer
 
2. "<" Decrement the pointer

3. "+" Increment the value at the pointer

4. "-" Decrement the value at the pointer
 
5. "[" Begins while loop
 
6. "]" Goes to corresponding begin loop if pointer is not 0, otherwise it continues to the next instruction

7. "." Output the current byte to the screen (Not usually used in this case)

8. "," Waits for next key typed into console and stores it into byte at pointer

9.  "*" Used for drawing the current array to the screen


**Examples**
---
+[++++++++++++++++++++++++++++++++++++++++++>>++*] <- Draws a checkboard pattern

+[>,*] <- Shows the text the user types color coded
