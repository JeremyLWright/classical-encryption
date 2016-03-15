// Native.Test.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <catch/catch.hpp>
#include <string>
#include <iostream>
#include <Ciphers/Ciphers.h>

TEST_CASE("AddOne")
{
	auto r = AddOne(1);
	REQUIRE(r == 2);
}

TEST_CASE("CaesarCipher_HelloWorld")
{
	auto ciphertext = std::string(CaesarCipher("Hello World"));
//	std::cout << ciphertext << '\n';
	REQUIRE(ciphertext == "UryybJbeyq");
}
