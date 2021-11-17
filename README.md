# NoConfuseBool

This is an attempt to make a simple c# console app that helps new students learn boolean logic through a silly logic game. I pose this question to my students to 
see if they have a grasp on compound boolean expressions. Here is the scenerio:

We were all partying last night and you decided to crash at my place. I say to you, "I'm going to go to the grocery store. `If I buy bacon and eggs`, I'll make you breakfast." As I am leaving for the grocery store, you remember that I am an extremely literal person. `I come back with just eggs`. Am I making you breakfast?

I have my student's answer "yes" or "no" based off of how I phrased my statement. In the above example, I could translate the dialogue to be:
```
if (bacon && eggs)
{
  Console.WriteLine("I'm making you breakfast!");
}
else
{
  Console.WriteLine("I'm not making you breakfast!");
}

```
 
Since `I come back with just eggs`, we can assume:
```
bool bacon = false
bool eggs = true
if (false && true)
{
  Console.WriteLine("I'm making you breakfast!");
}
else
{
  Console.WriteLine("I'm not making you breakfast!");
}

```
which translates to false since both side of an && operator must be true. I will then repeat this scenerio interchanging 'or' and 'and' while 'coming home with' one, the other, or both. NoConfuseBool is my way of translating a difficult concept into a real world analogy using c# code. Enjoy! 
