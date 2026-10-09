# EngineDesignMidterm_practical

Part 2:

Inheritance:

<img width="423" height="323" alt="image" src="https://github.com/user-attachments/assets/e4df1882-884c-46ad-b467-90d95458ecc6" />

I made a base class of Enemy where all enemies will inherit its properties. The property shown is the Rigidbody variable, which every child will inherit. Additionally, I made the Start function protected so that every child can run that start code. This way, I don't need to write that piece of code over and over again for every child enemy I want to create. This is useful for this game because I noticed there are different kinds of enemies, so I assumed that they all probably have similar aspects to them, which inheritance is useful for. 

Polymorphism:

<img width="267" height="299" alt="image" src="https://github.com/user-attachments/assets/f934d5b1-940f-4951-ae91-4ab20d7142d7" />

Continuing with Polymorphism, I made it so that the base class of Enemy had a function to attack that all other child enemies can inherit. Though what's different is that the attack function is abstracted, so that method can be run in different ways depending on the child enemies. This way, different enemies can perform different attacks while still using that same method and still being of the Enemy class. This is useful for this game because I noticed that one enemy performed a projectile attack while the other didn't, which polymorphism is useful for, as you can have different behavior for the same method. 

Encapsulation:

<img width="310" height="82" alt="image" src="https://github.com/user-attachments/assets/46beab5c-e578-41f3-8da5-b9870cf0b01f" />

For Encapsulation, I made a simple getPlayerSpeed method that returns the player's private speed variable. This is good for keeping information from accidentally being changed by another script. It is also cleaner than just accessing the variable outright. It's useful for this game, as I assume that the player would be able to get around the level, and different objects could inflict status effects like a slow or maybe a power up that can boost the player's speed, among other things.  

Abstraction:

<img width="340" height="74" alt="image" src="https://github.com/user-attachments/assets/e26e7100-ecd1-4c04-a141-cc7e7d988990" />

For Abstraction, I made an abstract SpawnEnemy function inside an abstract EnemySpawner class. This is so that the function is hidden from the user, as well as so that the script inheriting from it can access it. 


Part 3:
Singletons:

<img width="479" height="487" alt="image" src="https://github.com/user-attachments/assets/21bf48ae-047d-4f6c-830d-e42ce8acda21" />
<img width="464" height="444" alt="image" src="https://github.com/user-attachments/assets/df244f3d-87d3-4ef9-9047-66b075277c3f" />




Part 4:


