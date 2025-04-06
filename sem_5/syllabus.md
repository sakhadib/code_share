## Software Security

1. Lecture 1 - [Note](https://rightful-bakery-2bc.notion.site/Lecture-1-130c52376e4a80d8ab91ee3cc17a48eb?pvs=4)
2. Lecture 3 - [Note](https://rightful-bakery-2bc.notion.site/Lecture-3-1c1c52376e4a80c79114f3e1803e2853?pvs=4)
3. Lecture 5 - [Note](https://rightful-bakery-2bc.notion.site/Lecture-5-130c52376e4a807a801aff04131f756c?pvs=4)
4. Lecture 6 - [Note](https://rightful-bakery-2bc.notion.site/Lecture-6-130c52376e4a800e8ebcde1d5d57d990?pvs=4)
5. Lecture 7 - [Note](https://rightful-bakery-2bc.notion.site/Lecture-7-1acc52376e4a801a9f9dd54be6d54a16?pvs=4)
6. Lecture 8
7. Lecture 9
8. Compound BPF code syntax

--------------------------------------------------------------------

## Server Programming

1. MVC design pattern and flow
2. N-Tier architecture
3. SSO
4. Common Web Concerns
5. Web Vulnerabilities and Attacks
6. Caching and Proxy
7. System design fundamentals
8. System design problems and examples : Messenger, Twitter, Tinder, Youtube, Netflix, Github
9. Back of the envelope calculations
10. Load Balancer
11. Database Replication and CQRS
12. Theories and Concerns of Deployment

--------------------------------------------------------------------

## Machine Learning

1. Support Vector Machine
2. KNN : K-Nearest Neighbors
3. NN : Neural Networks
4. ANN : Artificial Neural Networks
5. CNN : Convolutional Neural Networks
6. RNN : Recurrent Neural Networks
7. Clustering and Un-Supervised Learning
8. Basic ML practices


--------------------------------------------------------------------

## Operating Systems (Sir has not confirmed this yet)

--------------------------------------------------------------------

## Design Patterns (The Full Syllabus)

> Codes for all patterns and scenarios attached in : [https://github.com/sakhadib/Design-Patterns](https://github.com/sakhadib/Design-Patterns)

### Before Mid

1. Strategy Pattern
2. Factory Method Pattern
3. Decorator Pattern
4. Template Method Pattern
5. Composite Pattern
6. Adapter Pattern
7. Singleton Pattern


### After Mid

8. Facade Pattern
9. Proxy Pattern
10. Command Pattern
11. Observer Pattern
12. Prototype Pattern
13. Flyweight Pattern

--------------------------------------------------------------------

## Numerical Methods

Question-1 (32.5 marks):  
From: Lectures 1, 3, and 4  

Make sure you study the introductory stuff about numerical methods from Lecture-1.  
Have a solid understanding of all the root-finding algorithms.  

Formulae (for math and derivations):  
  - Newton–Raphson Method  
  - Secant Method  

Caution:  
  - In the root-finding math, you have to formulate the function after reading the given scenario.  
  - Try to be as careful as you possibly can while working on this question for avoiding silly mistakes.  
  - Note that the equation pertinent to the question consists of a hyperbolic function.

>[!Note]
>Newton Raphson Method and Secant Method
>[https://rightful-bakery-2bc.notion.site/Root-Finding-1ccc52376e4a80c9930ec0f001e20f3b?pvs=4](https://rightful-bakery-2bc.notion.site/Root-Finding-1ccc52376e4a80c9930ec0f001e20f3b?pvs=4)

---

Question-2 (24 marks):  
From: Lectures 2 and 5  

Make sure you study why and when we need each type of error, how they manifest, and also their interpretability (except Truncation error).  
Practise deriving the Maclaurin series of transcendental functions.  
Practise approximating the bounds of error using the Remainder Theorem.  

Formulae (for math and derivations):  
  - Intermediate-level Trigonometric formulae  
  - Logarithmic formulae  
  - Differential Calculus  

Here's a list of formulae that might come in handy (1st column only) — https://www.pas.rochester.edu/~arijit/c02.pdf  

Caution:  
  - Try to remain careful while differentiating in the Maclaurin series question.  
  - You'll have to use the first 5 terms of the Taylor series.  
  - Remember to practise long-division for polynomials.

>[!Note]
>Errors And Significant Digits
>[https://rightful-bakery-2bc.notion.site/Error-Calculation-1ccc52376e4a801f92dbd8ce91b8ce50?pvs=4](https://rightful-bakery-2bc.notion.site/Error-Calculation-1ccc52376e4a801f92dbd8ce91b8ce50?pvs=4)
---

Question-3 (19 marks):  
From: Lectures 6, 7, and 8  

Practise proofs and derivations from the aforementioned lectures (except the 2nd order NDD derivation, of course).  
Have a solid understanding of the theoretical concepts behind the polynomial interpolation methods.  

Formulae (for math and derivations):  
  - NDD method  
  - Lagrangian method (just the 2nd order versions of both)  

Caution:  
  - Be careful while choosing the nearest points in the interpolation math.

---

Question-4 (20.5 marks):  
From: Lectures 10 and 11  

Practise deriving the formulae of the Linear Regression parameters and proving the goodness/badness of different optimization criteria.  
Study the utility of different nonlinear regression models. Which parameter of a nonlinear regression curve controls which property of the curve, how they might overfit/underfit a given data distribution — have a solid idea about these concepts.  
Study the theory behind Variance and Covariance of data distributions.  
Practise linearizing/applying data transformations.  

Formulae (for math, proofs, and derivations):  
  - Linear Regression  
  - 2nd derivative test  
  - Polynomial Model  
  - Logarithmic Model  

Caution:  
  - As I have said before, please learn how to use the “Statistics” mode of your calculator if you haven't already.

---

Question-5 (27 marks):  
From: Lectures 12 and 13  

Practise deriving the Single-segment Trapezoidal Rule (all four methods) and Multi-segment Trapezoidal Rule formulae.  

Formulae (for math and derivations):  
  - Trapezoidal Rule  
  - Simpson's 3/8 Rule  
  - Integral Calculus  
  - True Error  
  - Absolute Relative True Error  

Caution:  
  - Analyze the diagram that accompanies the question with proper intuition.  
  - Please learn how to use the “Table” mode of your calculator if you haven't already. It will help you get the functional values at regular intervals way faster.

---

Question-6 (27 marks):  
From: Lectures 14, 15, 16, 17, and 18  

Learn how Euler's method is used to approximate definite integrals.  
Learn the concepts/derivations behind Eigenvalues and Eigenvectors. Practise finding them out for different matrices.  
Have a solid idea about all 3 methods of solving 1st-order ODEs — Euler's method, RK2 method, and RK4 method.  
Make sure you understand the concept of order and degree of a higher order ODE.  
Practise LU Decomposition of 3×3 matrices.  
Practise approximating the value of ordinary/partial derivatives of a function from a given set of discrete data points.  

Formulae (for math):  
  - Euler's method  
  - Numerical Differentiation (ordinary, partial, 1st-order, higher-order)  

Caution:  
  - This is the easiest and the least time-consuming question in my opinion (even though it is the textually largest question due to various reasons).  
  - So if you want, you can answer it at first to secure 27 marks easily at the beginning of the exam.  
  - You may end up making silly mistakes in a state of hurry if you leave it for later.  
  - The function whose integral you'll approximate has to be formulated from the given scenario.

---

Some observations regarding the question:  
  - If you haven't noticed already, there are no questions from Lecture-9. So you can yeet that off from the syllabus.  
  - The questions do not have equal marks distribution. So manage your time accordingly.  
  - As per the suggestions of the moderation committee, I couldn't include any formulae or hints in the question paper. I have, of course, listed above all the formulae that you will need for answering the mathematical and derivation-type questions. Just practise a lot, keep them in mind, and carefully apply them in the exam.  
  - There are many repeat-questions (of course, subject to the constraints that I have mentioned in our last class). Practise the questions from Quiz-1, 2, 3, 4, Mid Semester exam and the example questions from the Lecture Slides. To augment your preparation, you can choose to solve the previous year questions as well. The questions will seem very familiar if you do so.  
  - Just like in the Mid Semester exam, in Question-1, you have to draw a table and populate it with the correct answers. You have to demonstrate the step-by-step procedure every iteration too, as some partial marks are reserved for that.  
  - For the "Compare and contrast..." type questions, writing any 2 valid comparisons is enough. Answer the other theoretical questions in a similar concise manner. Don't spend too much time on these types of questions.  
  - If possible, try to arrive at the examination hall early and skim through the entire question paper before the exam starts. It will help you strategize nicely for the following 3 hours, insha'Allah.  
  - The question paper may seem big at first glance, but don't worry. Manage your time properly, think swiftly, and write concisely. Insha'Allah you'll do well.
