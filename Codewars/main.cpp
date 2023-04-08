#include <vector>
#include "RemoveTheMinimum.h"
#include "iostream"

using namespace std;

int main()
{
	const vector<unsigned int> number = {1, 2, 3, 4, 5};
	const std::vector<unsigned int>
		expected_result = {2, 3, 4, 5};
	const auto result = remove_smallest(number);
	for (const auto value : result)
		cout << value;
	return 0;
}
