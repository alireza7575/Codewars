#include "NewString.h"

auto NewString::split(const std::string& input) -> std::vector<std::string>
{
	std::vector<std::string> result = {};
	for (auto index = 0; index < input.size(); index += 2)
		result.push_back(input.substr(index, 2));
	if (input.size() % 2 != 0)
		result[result.size()-1]  += '_';
	return result;
}
