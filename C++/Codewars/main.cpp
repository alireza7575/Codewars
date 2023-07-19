#include "vector_extensions.h"
#include <vector>
#include "iostream"

using namespace std;

int main()
{
	const vector<unsigned int> number = {1, 2, 3, 4, 5};
	const std::vector<unsigned int>
		expected_result = {2, 3, 4, 5};
	for (const auto value : vector_extensions::remove_smallest(number))
		cout << value;
	return 0;
}
