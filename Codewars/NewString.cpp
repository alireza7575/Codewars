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

static std::vector<std::string> inArray(std::vector<std::string> &array1, std::vector<std::string> &array2){
	std::vector<std::string> result = {};
    for(auto first_string : array1){
      for(auto second_string : array2){
        if(second_string.compare(first_string)){
					result.push_back(first_string);
					break;
      }
    }
			return result;
  }};
