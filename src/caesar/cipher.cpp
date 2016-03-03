#include <string>
#include <algorithm>
#include <iterator>
#include <iostream>

template <typename Iter, typename OutputIter>
void caesar_cipher(Iter& begin,
		const Iter& end,
		OutputIter& sink)
{
	for( ; begin != end; ++begin)
	{
        //Doesn't need to be here, but I'm lazy and don't like
        //typing *begin over and over again.
        char& c = *begin;

        if (c >= 'a' && c <= 'm') {
            *sink = c + 13;
        } else if (c >= 'n' && c <= 'z') {
            *sink = c - 13;
        } else if (c >= 'A' && c <= 'M') {
            *sink = c + 13;
        } else if (c >= 'N' && c <= 'Z') {
            *sink = c - 13;
        }
    }
}

int main(int argc, const char *argv[])
{
	std::string plaintext{"DO NOT USE PC"};
	std::string ciphertext;

	caesar_cipher(std::begin(plaintext),
			std::end(plaintext),
			std::inserter(ciphertext, ciphertext.begin()));
	
	std::cout << ciphertext <<'\n';
	
	std::string plaintext2;
	caesar_cipher(std::begin(ciphertext),
			std::end(ciphertext),
			std::inserter(plaintext2, plaintext2.begin()));
	std::cout << plaintext2 << '\n';

	return 0;
}
