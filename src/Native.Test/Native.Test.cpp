// Native.Test.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <catch/catch.hpp>
#include <string>
#include <iostream>

extern "C" int AddOne(int source);
extern "C" char* CaesarCipher(const char* plaintext);

TEST_CASE("Hello World")
{

	auto r = AddOne(1);
	REQUIRE(r == 2);

	auto ciphertext = std::string(CaesarCipher("Hello World"));
	std::cout << ciphertext << '\n';
	REQUIRE(ciphertext == "UryybJbeyq");
}
