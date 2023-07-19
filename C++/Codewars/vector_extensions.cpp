#include <algorithm>
#include "../Codewars/vector_extensions.h"

std::vector<unsigned int> vector_extensions::remove_smallest(const std::vector<unsigned int>& numbers)
{
	if (numbers.empty())
		return {};
	std::vector<unsigned int> result(numbers);
	result.erase(std::min_element(result.begin(), result.end()));
	return result;
}

long vector_extensions::sum_two_smallest_numbers(std::vector<int> numbers)
{
	std::sort(numbers.begin(), numbers.end());
	return numbers[0] + numbers[1];
}
