#include "../Codewars/NewString.cpp"
#include "gtest/gtest.h"


NewString new_string = NewString::NewString();

TEST(StringShouldSplitTwoByTwo, EmptyString)
{
	const std::vector<std::string> result = new_string.split("");
	ASSERT_EQ(result.size(), 0);
}

TEST(StringShouldSplitTwoByTwo, StringWithOnlyTwoChar)
{
	const auto result = new_string.split("AB");
	ASSERT_EQ(result.size(), 1);
}


TEST(StringShouldSplitTwoByTwo, SttingWIthOneChar)
{
	const auto result = new_string.split("A");
	ASSERT_EQ(result.size(), 1);
	ASSERT_EQ(result.front(), "A_");
}


TEST(StringShouldSplitTwoByTwo, MoreTests)
{
	const std::vector<std::string> expected_result = {"ab", "cd", "e_"};
	const auto result = new_string.split("abcde");
	ASSERT_EQ(result.size(), expected_result.size());
	for (size_t index = 0; index < result.size(); index++)
		ASSERT_EQ(result[index], expected_result[index]);
}
