#include "RemoveTheMinimum.h"

#include <algorithm>

std::vector<unsigned int> remove_smallest(const std::vector<unsigned int>& numbers)
{
	if (numbers.empty())
		return {};
	std::vector<unsigned int> result(numbers);
	result.erase(std::min_element(result.begin(), result.end()));
	return result;
}

long sumTwoSmallestNumbers(std::vector<int> numbers)
{
	std::sort(numbers.begin(), numbers.end());
	return numbers[0] + numbers[1];
}
