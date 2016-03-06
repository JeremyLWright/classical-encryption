# Foreword

This book is intended to tackle cryptography, and grow one's understanding of
this unique science. Computer Science treats cryptography with a great deal of
mysticism: There is a bit of magic here, don't try to understand it if you are
not a "crypto" expert. If you are a programmer who likes puzzles, this book is
for you. Together we will tour through simple, ancient ciphers up to World War
II's elegant systems. 

For each system we will design C++ applications to cipher text, and when
appropriate design cracking systems to analyze the weaknesses of the system.
When more power is required, we will deploy our cracking applications on Azure. 

## Frequently Asked Questions

Q> ## Why are you using Windows, and Microsoft? Are you a fan boy?
Q>
Q> Nope. My current job gives me an allowance on Microsoft Azure. I use it because it's free. 

Q> ## Why are you using Visual Studio for the code?
Q>
Q> When I started writing this application, Visual Studio had the only
Q> implementation of C++'s coroutines. By the time you read this, coroutines are
Q> likely implemented in several compilers, but it took a long time to write this book

Q> ## I think I could write the code better than you!
Q>
Q> Well, that wasn't a question, but awesome. I'm always trying to be better. Fork
Q> this book on github, and I'll happily merge your request.

Q> ## What are you drinking?
Q> 
Q> Jameson.

Q> ## What language do I need to know to read this?
Q> 
Q> This book believes in the right tool for the job, and programming languages
Q> are just tools. Most code examples are provided in C# and Python, however
Q> sometimes Scala or R will be used run running on Spark. A few modules are
Q> implemented in C++, since it provides the most intuitive access of the plethora
Q> of C language cryptographic libraries.

Q> ## C# is a horrible language for prototyping. Why did you use that to compare with python's awesome REPL!?
Q>
Q> C# has a REPL too: csi
Q> https://msdn.microsoft.com/en-us/magazine/mt614271.aspx



