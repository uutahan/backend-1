# Backend Study - Question 1

- Firstly we create two dictionaries<char, int> and one set<char>. Each dictionary has chars in string as its keys and that chars occurance number as value of the key.
- Set<char> has all chars from two different strings.
- Then we create two bool variables(named map1Bigger and map2Bigger), these variables says for each char in string if string1 or string2's occurance for that variable is bigger.
- If both of these variables evaluated to true then this means string1 has some char that its occurance in string1 is more than string2, and string2 has some char that its occurance in string2 is more than string1.
- After creating these, then we loop through the set we created and check occurance of each char in dictiories so that we can evaluate map1Bigger and map2Bigger's values.
- If both of them true then this means both has some parts that other dont, so ones permutation can not be included in other. Otherwise it can be included.

