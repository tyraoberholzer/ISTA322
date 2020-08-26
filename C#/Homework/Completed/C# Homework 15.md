#<center>C# Homework 05</center>

1. What is the difference between property and field?
    - A property is a cross between a field and a method- it looks like a field but acts as a method. A field is a variable that is declared directly in  a class or struct. A property is a member that provides a flexible mechnism to read, write, or compute the value of a private field.

2. What is the difference between a property and a method?
    - Property is a valued stored in the hash key, whereas method is a function stored in hash key. 

3. What is your understanding of encapsulation?
    - It is defined as the process of enclosing one or more items within a physical or logical package. It prevents access to implementation details.

4. Some languages are case insensitive, that is, an `a" and an \A" are considered to be the same letter. C# is case sensitive. What implications does this have regarding the naming of variables, methods, and other identifiers? Do you think that the difference in case in the initial character of two different identiffiers is sufficient to distinguish them?
    - Lowercase _x and _y are private fi elds.
    - Uppercase X and Y are public properties.

5. Give an example that is not in the book of an instance where you might want to use a read-only property. Give an example not in the book of an instance where you might want to use s write-only property.

6. Can you think of a reason why you might ever want to make getters and setters private? Give an example. Also, make a case why getters and setters should never be private.
    - The reason for making the getters and setters private is to make the corresponding part of the object's abstract state private. That's largely in dependnt of the decision to use getters and setters or not. They can provide a place for adding your debug code.

7. What are restrictions on the use of properties?
    - You can assign a value through a property of a structure or class only after the structure or class has been initialized.
    - You can't use a property as a ref or an out argument to a method (although you can use a writable field as a ref or an out argument).This makes snese because the property doesn't really point to a memory location; rather, it points to an accessor method.
    - A property can contain at most one get accessor and one set accessor. A property cannot contain other methods, fields, or properties.
    - The get and set accessor cannot take any parameters. The data being assinged is passed to the set accessor automatically by using the value variable.
    - You can't declare properties by using const.

8. What is an object initializer? What is the syntax for an object initializer?
    - the C# compiler generates code that calls the default constructor and then calls the set accessor of each named property to initialize it with the value specifi ed. You can specify object initializers in combination with non-default constructors as well.
    - Triangle tri5 = new Triangle("Equilateral triangle")
      {
            Side1Length = 3,
            Side2Length = 3,
            Side3Length = 3
      }

