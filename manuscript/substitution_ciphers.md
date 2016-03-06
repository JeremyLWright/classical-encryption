# Substitution Ciphers

Substitution ciphers are the most simple ciphers. Essentially, a substitution
cipher replaces a single letter with another. The mapping of cleartext letters
to ciphertext letters does not change over the course of the message. Hence,
substitution ciphers do not mask the letter frequency distribution, and this will
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
E(x) = (x + n) \mod{26}
{/$$}

{$$}
D(x) = (x - n) \mod{26}
{/$$}

```
11 22 21 22 1 \\ 2 0 12 23 10
```

Transforming back to text, we have our ciphertext

```
LWVWB CAMXK
```

[Excel](#ref:excel_ciphers) can be a simple tool to automate the arithmetic of this cipher.

| Convert to Number | Apply Transform            | Convert to Letter |
|-------------------|---------------------------|-------------------|
| =CODE(A1)-65	    | =MOD(A2 + CAESAR_KEY, 26)	| =CHAR(A3 + 65)	|

### Analyzing Caesar
The key technique for analyzing Caesar ciphers is frequency analysis. One counts
the occurrences of each given letter, and assumes the distribution matches the
English language. 

![Distribution](images/English_letter_frequency_alphabetic.svg)

Let us cipher a paragraph and see how this works.

```
IN CRYPTANALYSIS, FREQUENCY ANALYSIS IS THE STUDY OF THE FREQUENCY OF LETTERS OR
GROUPS OF LETTERS IN A CIPHERTEXT. THE METHOD IS USED AS AN AID TO BREAKING
CLASSICAL CIPHERS.

FREQUENCY ANALYSIS IS BASED ON THE FACT THAT, IN ANY GIVEN STRETCH OF WRITTEN
LANGUAGE, CERTAIN LETTERS AND COMBINATIONS OF LETTERS OCCUR WITH VARYING
FREQUENCIES. MOREOVER, THERE IS A CHARACTERISTIC DISTRIBUTION OF LETTERS THAT IS
ROUGHLY THE SAME FOR ALMOST ALL SAMPLES OF THAT LANGUAGE. FOR INSTANCE, GIVEN
A SECTION OF ENGLISH LANGUAGE, E, T, A AND O ARE THE MOST COMMON, WHILE Z, Q AND
X ARE RARE. LIKEWISE, TH, ER, ON, AND AN ARE THE MOST COMMON PAIRS OF LETTERS
(TERMED BIGRAMS OR DIGRAPHS), AND SS, EE, TT, AND FF ARE THE MOST COMMON
REPEATS.[1] THE NONSENSE PHRASE "ETAOIN SHRDLU" REPRESENTS THE 12 MOST FREQUENT
LETTERS IN TYPICAL ENGLISH LANGUAGE TEXT.

IN SOME CIPHERS, SUCH PROPERTIES OF THE NATURAL LANGUAGE PLAINTEXT ARE PRESERVED
IN THE CIPHERTEXT, AND THESE PATTERNS HAVE THE POTENTIAL TO BE EXPLOITED IN
A CIPHERTEXT-ONLY ATTACK.
```

~~~ python
>>> from collections import Counter
>>> f = open("wikipedia_paragraph.txt", "r").read()
>>> f2 = Counter(f)
>>> f2.most_common()
[(' ', 156), ('E', 111), ('T', 88), ('A', 72), ('S', 63), ('N', 59), ('R', 59),
('I', 53), ('O', 47), ('H', 37), ('L', 33), ('C', 29), ('P', 21), (',', 20), ('G
', 20), ('F', 20), ('M', 19), ('U', 19), ('D', 18), ('\n', 17), ('Y', 13), ('.',
 8), ('X', 7), ('B', 6), ('Q', 6), ('V', 6), ('W', 4), ('K', 3), ('"', 2), ('1',
 2), (')', 1), ('(', 1), ('-', 1), ('2', 1), ('[', 1), ('Z', 1), (']', 1)]
~~~

~~~ c#
int[] c = new int[(int)char.MaxValue];
> string s = File.ReadAllText("wikipedia_paragraph.txt");
> foreach(char t in s)
.       c[(int)t]++;
> for(int i = 0; i < (int)char.MaxValue; i++)
.       if(c[i] > 0 && char.IsLetterOrDigit((char)i))
.               Console.WriteLine($"Letter {(char)i} Frequency {c[i]}");
Letter 1 Frequency 2
Letter 2 Frequency 1
Letter A Frequency 72
Letter B Frequency 6
Letter C Frequency 29
Letter D Frequency 18
Letter E Frequency 111
Letter F Frequency 20
Letter G Frequency 20
Letter H Frequency 37
Letter I Frequency 53
Letter K Frequency 3
Letter L Frequency 33
Letter M Frequency 19
Letter N Frequency 59
Letter O Frequency 47
Letter P Frequency 21
Letter Q Frequency 6
Letter R Frequency 59
Letter S Frequency 63
Letter T Frequency 88
Letter U Frequency 19
Letter V Frequency 6
Letter W Frequency 4
Letter X Frequency 7
Letter Y Frequency 13
Letter Z Frequency 1
~~~






