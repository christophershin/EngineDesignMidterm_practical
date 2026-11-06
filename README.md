
# INFR 3110 Make Up Assignment
---
### Name : Christopher Shin
### Student Number : 100974007
---
# Object Oriented Programming
---

### Description
<!-- Briefly describe the classes, their relationships, and how object-oriented programming principles are demonstrated in your implementation. -->
I used inheritance in the fruit script where the apple and lemon can use the "name" variable and change it. Polymorphism is used where the function printname prints out differently based on the fruit but comes from the same class. 

## UML Diagram
<!-- Attach your UML diagram here -->
<img width="163" height="200" alt="Screenshot 2026-11-05 194137" src="https://github.com/user-attachments/assets/d2062688-333b-48bc-8ce9-6ef5ab6d432f" />


---
# Singleton Pattern
---

### Purpose
<!-- Explain why the Singleton pattern is appropriate for this particular system. -->
I used the singleton as a gamemanager to handle spawning of fruits. I used singleton to handle snakelength because I think it would be useful for keeping track of the number of parts and maybe their positions.

### Implementation
<!--Describe how the Singleton pattern is implemented in your project. -->
I made a base singleton and then a gamemanager to inherit it. I also made a snakeLengthManager to keep track of the number of parts. 

---
# Factory Pattern
---


### Purpose
<!-- Explain why the Factory pattern is appropriate for this particular system. -->
I made it because there could be different fruits in the game that can do different things. 

### Implementation
<!-- Describe how the Factory pattern is implemented in your project. -->
I made a base fruit spawner that the two other fruits (apple and lemon) will inherit. Then I made the fruits script that print their names when spawned

---
# References
---
<!-- Identify sources used to create any gameplay logic or programming pattern implementations. -->
https://medium.com/@carol.reed.597/how-to-create-a-snake-game-in-minutes-using-unity-fb340bb4b5b

