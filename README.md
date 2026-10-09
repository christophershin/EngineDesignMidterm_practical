# EngineDesignMidterm_practical

Part 2:

Inheritance:

<img width="423" height="323" alt="image" src="https://github.com/user-attachments/assets/e4df1882-884c-46ad-b467-90d95458ecc6" />

I made a base class of Enemy where all enemies will inherit its properties. The property shown is the Rigidbody variable, which every child will inherit. Additionally, I made the Start function protected so that every child can run that start code. This way, I don't need to write that piece of code over and over again for every child enemy I want to create. This is useful for this game because I noticed there are different kinds of enemies, so I assumed that they all probably have similar aspects to them, which inheritance is useful for. 

Polymorphism:

<img width="267" height="299" alt="image" src="https://github.com/user-attachments/assets/f934d5b1-940f-4951-ae91-4ab20d7142d7" />

Continuing with Polymorphism, I made it so that the base class of Enemy had a function to attack that all other child enemies can inherit. Though what's different is that the attack function is abstracted, so that method can be run in different ways depending on the child enemies. This way, different enemies can perform different attacks while still using that same method and still having the class of Enemy. This is useful for this game because I noticed that one enemy performed a projectile attack while the other didn't, which polymorphism is useful for, as you can have different behavior for the same method. 

Encapsulation:

<img width="227" height="85" alt="image" src="https://github.com/user-attachments/assets/5c41d414-9678-4919-98fe-9fb33eabe9ff" />



Abstraction:

<img width="369" height="58" alt="image" src="https://github.com/user-attachments/assets/e9c83080-06fa-4d59-a1ed-dc44995d7b87" />



Part 3:



Part 4:


