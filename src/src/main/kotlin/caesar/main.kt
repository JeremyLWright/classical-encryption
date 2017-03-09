package main.kotlin.caesar

val letters = 'A'..'Z'
val alphabet = letters + sequenceOf(' ')
val alphabetMap = alphabet.zip(0..alphabet.count()).toMap()
val reverseAlphabetMap = (0..alphabet.count()).zip(alphabet).toMap()


fun moduloAdd(a: Int, b: Int, modulo: Int) = (((a + b) % modulo) + modulo) % modulo

fun caesar(message: String, shift: Int) =
    message.map {
        c -> moduloAdd(alphabetMap.getOrDefault(c, 0), shift, letters.count())
    }.map {
        n -> reverseAlphabetMap.getOrDefault(n, '$')
    }.joinToString("")


