# Substitution Ciphers

Substitution ciphers are the most simple ciphers. Essentially, a substition
cipher replaces a single letter with another. The mapping of cleartext letters
to ciphertext letters does not change over the course of the message. Hence,
substition ciphers do not mask the letter frequency distribution, and this will
be our first technique in cracking them.   

## Caesar Cipher

The Caesar cipher is a [mono-alphabetic](#def:mono-alphabetic) cipher. The Caesar cipher translates
all characters by a given offset. 

Given the cleartext:
```
DO NOT USE PC
```

To mask word boundaries we break the text into groups of 5.

```
DONOT USEPC
```
{#fig:1.1}
![Figure 1.1](images/tab2_mod26-encodings.png)

We can map each letter to a number using [Figure](#fig:1.1). 

```
[3][14][13][14][19] [20][18][4][15][2]
```

We then apply our key of {$$}n = 8{/$$}
{$$}
E(x) = (x + n) mod 26 \\
D(x) = (x - n) mod 26
{/$$}

```
11 22 21 22 1 \\ 2 0 12 23 10
```

Transforming back to text, we have out ciphertext

```
LWVWB CAMXK
```

[Excel](#ref:excel_ciphers) can be a simple tool to automate the arithmetic of this cipher.

| Convert to Number | Apply Tranform            | Convert to Letter |
|-------------------|---------------------------|-------------------|
| =CODE(A1)-65	    | =MOD(A2 + CAESAR_KEY, 26)	| =CHAR(A3 + 65)	|





