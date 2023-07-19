#include "../Codewars/new_string.cpp"
#include "gtest/gtest.h"


TEST(StringShouldSplitTwoByTwo, EmptyString)
{
	const std::vector<std::string> result = new_string::split("");
	ASSERT_EQ(result.size(), 0);
}

TEST(StringShouldSplitTwoByTwo, StringWithOnlyTwoChar)
{
	const auto result = new_string::split("AB");
	ASSERT_EQ(result.size(), 1);
}

TEST(StringShouldSplitTwoByTwo, SttingWIthOneChar)
{
	const auto result = new_string::split("A");
	ASSERT_EQ(result.size(), 1);
	ASSERT_EQ(result.front(), "A_");
}

TEST(StringShouldSplitTwoByTwo, MoreTests)
{
	const std::vector<std::string> expected_result = {"ab", "cd", "e_"};
	const auto result = new_string::split("abcde");
	ASSERT_EQ(result.size(), expected_result.size());
	for (size_t index = 0; index < result.size(); index++)
		ASSERT_EQ(result[index], expected_result[index]);
}

TEST(WhichAreIn, FindFirstArrayInSecond)
{
	const std::vector<std::string> first_array = {"arp", "live", "strong"};
	const std::vector<std::string> second_array = {"lively", "alive", "harp", "sharp", "armstrong"};
	const std::vector<std::string> expected_result = {"arp", "live", "strong"};
	ASSERT_EQ(new_string::in_array(first_array, second_array), expected_result);
}

TEST(CharacterCounter, EmptyString)
{
	using expectedResult = std::map<char, unsigned>;
	ASSERT_EQ(new_string::count_characters(""), expectedResult{});
}

TEST(CharacterCounter, StringWithOneCharacter)
{
	const std::map<char, unsigned> expected_result{{'a', 1}};
	ASSERT_EQ(new_string::count_characters("a"), expected_result);
}

TEST(CharacterCounter, StringWithMoreThanOneCharacter)
{
	const std::map<char, unsigned> expected_result{{'a', 4}};
	ASSERT_EQ(new_string::count_characters("aaaa"), expected_result);
}

TEST(CharacterCounter, StringWithMoreThanOneTypeOfCharacter)
{
	const std::map<char, unsigned> expected_result{{'a', 4}, {'b', 2}};
	ASSERT_EQ(new_string::count_characters("aaaabb"), expected_result);
}
