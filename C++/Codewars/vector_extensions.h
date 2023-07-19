#ifndef VECTOR_EXTENSIONS_H
#define VECTOR_EXTENSIONS_H
#include <vector>

class vector_extensions
{
public:
	static std::vector<unsigned int> remove_smallest(const std::vector<unsigned int>& numbers);
	static long sum_two_smallest_numbers(std::vector<int> numbers);
};
#endif // VECTOR_EXTENSIONS_H
