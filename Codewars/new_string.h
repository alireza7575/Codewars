#pragma once
#include <map>
#include <string>
#include <vector>

class new_string
{
public:
	static std::vector<std::string> split(const std::string& input);

	static std::vector<std::string> in_array(const std::vector<std::string>& first_array,
	                                         const static std::vector<std::string>& second_array);
	static std::map<char, unsigned> count_characters(const std::string& inputText);
};
