# Singleton
## Description
- takes care of concurrent access to a shared resource
- used to share common data
- to reduce the overhead of instantiating a heavy object again and again- 
- to ensure that your class has only one instance with a global access point
- it can be of several types
    - Eager
    - Lazy
    - Thread-Safe
    - No Thread-Safe
    - Using Lazy< T  >
-  as a guidance should be sealed, since it cannot be instanciated because it has a private constructor
### Implementations
- private parametereless constructor
- static method that returns the instance
### Usage Scenarios
- Service Proxies 
- Data Sharing - when you have constant values or configurations
- Caching - to keep things in memory

### Disadvantages:
- dificult testing 
- reduces the parallelism potential
