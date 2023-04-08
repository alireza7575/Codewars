#include  "../Codewars/RemoveTheMinimum.cpp"  // NOLINT(bugprone-suspicious-include)
#include "gtest/gtest.h"


TEST(FirstTry, RemoveSmallest)
{
	const std::vector<unsigned int> number = {1, 2, 3, 4, 5};
	const std::vector<unsigned int>
		expected_result = {2, 3, 4, 5};
	const auto result = remove_smallest(number);
	EXPECT_EQ(result.size(), expected_result.size()) << "Vectors have different sizes";
	for (size_t i = 0; i < expected_result.size(); ++i)
	{
		EXPECT_EQ(expected_result[i], result[i]) << "Vectors differ at index " << i;
	}
}

TEST(FirstTry, MakeSureDontChangeOrder)
{
	const std::vector<unsigned int>
		number = {5, 3, 2, 1, 4}, expected_result = {5, 3, 2, 4};

	const auto result = remove_smallest(number);
	EXPECT_EQ(result.size(), expected_result.size()) << "Vectors have different sizes";
	for (size_t i = 0; i < expected_result.size(); ++i)
	{
		EXPECT_EQ(expected_result[i], result[i]) << "Vectors differ at index " << i;
	}
}
