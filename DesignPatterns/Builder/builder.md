### Builder
Builder is a creational design pattern that lets you construct
complex objects step by step. The pattern allows you to
produce different types and representations of an object using
the same construction code.
- used to create complex objects
- it can have a fluent implementation
- it will return the finished object:
- for complex objects you can extract object's construction code in its own class and move it to separate 
objects called builders
- construct complex objects step by step
- you can call the steps necessary to make a certain configuration of the objects
- you might need different builders to produce different kinds of objects
- might work hand in hand with a Director  class -> defines the order in which to call construction steps

e.g. Build a BirthdayCake


### 
