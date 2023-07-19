#include  "../Codewars/rot13_cipher.cpp"
#include "gtest/gtest.h"

// a b c d e f g h i j k l m n o p q r s t u v w x y z
TEST(cipherEncode, only_alphabet)
{
	EXPECT_EQ(rot13_cipher::encode("a"), "n");
	EXPECT_EQ(rot13_cipher::encode("b"), "o");
	EXPECT_EQ(rot13_cipher::encode("t"), "g");
	EXPECT_EQ(rot13_cipher::encode("u"), "h");
	EXPECT_EQ(rot13_cipher::encode("A"), "N");
	EXPECT_EQ(rot13_cipher::encode("T"), "G");
}

TEST(cipherEncode, multi_character)
{
	EXPECT_EQ(rot13_cipher::encode("aa"), "nn");
}

TEST(cipherEncode, more_test)
{
	EXPECT_EQ(rot13_cipher::encode("test!"), "grfg!");
	EXPECT_EQ(rot13_cipher::encode("Test"), "Grfg");
	EXPECT_EQ(rot13_cipher::encode("AbCd"), "NoPq");
}