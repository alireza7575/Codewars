#include "new_string.h"
#include <algorithm>

std::vector<std::string> new_string::split(const std::string& input)
{
	std::vector<std::string> result = {};
	for (size_t index = 0; index < input.size(); index += 2)
		result.push_back(input.substr(index, 2));
	if (input.size() % 2 != 0)
		result[result.size() - 1] += '_';
	return result;
}

std::vector<std::string> new_string::in_array(const std::vector<std::string>& first_array,
                                              const std::vector<std::string>& second_array)
{
	std::vector<std::string> result = {};
	for (const auto& first_string : first_array)
		for (const std::string& second_string : second_array)
			if (second_string.find(first_string) != std::string::npos)
			{
				result.push_back(first_string);
				break;
			}
	std::sort(result.begin(), result.end());
	return result;
}


std::map<char, unsigned> new_string::count_characters(const std::string& inputText)
{
	std::map<char, unsigned> result;
	for (auto character : inputText)
		if (result.count(character) == 0)
			result[character] = 1;
		else
			result[character]++;
	return result;
}
