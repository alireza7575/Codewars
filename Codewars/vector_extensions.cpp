#include <algorithm>
#include <vector>

class vector_extensions
{
public:
	static std::vector<unsigned int> remove_smallest(const std::vector<unsigned int>& numbers)
	{
		if (numbers.empty())
			return {};
		std::vector<unsigned int> result(numbers);
		result.erase(std::min_element(result.begin(), result.end()));
		return result;
	}

	static long sum_two_smallest_numbers(std::vector<int> numbers)
	{
		std::sort(numbers.begin(), numbers.end());
		return numbers[0] + numbers[1];
	}
};
