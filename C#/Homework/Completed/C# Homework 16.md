#<center>C# Homework 16</center>

1. Give five examples (using valid C# code) of the five bitwise operators listed in the text.
    - NOT operator ~
        + uint a = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
        + uint b = ~a;
        + Console.WriteLine(Convert.ToString(b, toBase: 2));
        + // Output:
        + // 11110000111100001111000011110011
    - Left-shift operator <<
        + uint x = 0b_1100_1001_0000_0000_0000_0000_0001_0001;
        + Console.WriteLine($"Before: {Convert.ToString(x, toBase: 2)}");
        + uint y = x << 4;
        + Console.WriteLine($"After:  {Convert.ToString(y, toBase: 2)}");
        + // Output:
        + // Before: 11001001000000000000000000010001
        + // After:  10010000000000000000000100010000
    - Logical AND operator &
        + uint a = 0b_1111_1000;
        +  uint b = 0b_1001_1101;
        +  uint c = a & b;
        +  Console.WriteLine(Convert.ToString(c, toBase: 2));
        +  // Output:
        +  // 10011000
    - Logical exclusive OR operator ^
        + uint a = 0b_1111_1000;
        + uint b = 0b_0001_1100;
        + uint c = a ^ b;
        + Console.WriteLine(Convert.ToString(c, toBase: 2));
        + // Output:
        + // 11100100
    - Logical OR operator |
        + uint a = 0b_1010_0000;
        + uint b = 0b_1001_0001;
        + uint c = a | b;
        + Console.WriteLine(Convert.ToString(c, toBase: 2));
        + // Output:
        + // 10110001
2. Does C# implement the right-shift (>>) operator? If so, give an example of its operation using valie C# code.
    - Right-shift operator >>
        + uint x = 0b_1001;
        + Console.WriteLine($"Before: {Convert.ToString(x, toBase: 2), 4}");
        + uint y = x >> 2;
        + Console.WriteLine($"After:  {Convert.ToString(y, toBase: 2), 4}");
        + // Output:
        + // Before: 1001
        + // After:    10
3. Explain in detail this code: bits & (1 << index);.
    - The & operator computes the bitwise logical AND of its operands: For bool operands, the & operator computes the logical AND of its operands. The unary & operator is the address-of operator
    - expresion on the right will be evaluated first then move left. adding zeros to the end of 1.
    - testing to see if the bit in this place is turned on or off
    - it will return either true or false; 1 or 0
4. Explain in detail this code: bits |= (1 << index);.
    - set the bit in this place to one regardless if it is one or not
    - this turns the bit on
    - equivalent to a setter
5. Explain in detail this code: bits &= (1 << index);.
    - bits &= ~(1 << 5)
    - 00000001
    - 00100000
    - 11011111 (NOT operator result)
    - turns the index bit OFF




- 42 = 00101010
- 37 = 00100101
- 42 & 37 = 00100000 (32)
- 42 | 37 = 00101111 (47)
- 42 ^ 37 = 00001111 (15)



- 122 = 01111010
- 91  = 01011011
- ------------------------
- 122 & 91 = 01011010 (90)
- & (1 over 0 or 0 over 1 turns into 0)
- -------------------------------------
- 122 | 91 = 01111011 (123)
- | (1 0ver 0 or 0 over 1 turns into 1)
- -----------------------------------------
- 122 ^ 91 = 00100001 (33)
- ^ (1 over 0 or 0 over 1 turns into 1 all the rest is zero)








- 69  = 01000101
- 145 = 10010001
- ----------------------------
- 69 & 145 = 00000001 (1)
- ------------------------------------
- 69 | 145 = 11010101 (213)
- ----------------------------------
- 69 ^ 145 = 11010100 (212)













