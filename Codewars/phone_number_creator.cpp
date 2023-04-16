#include <string>

class phone_number_creator
{
public:
	static std::string to_string(const int number[10])
	{
		std::string result = "(";
		for (size_t index = 0; index < 10; index++)
		{
			result += std::to_string(number[index]);
			if (index == 2)
				result += ") ";
			else if (index == 5)
				result += "-";
		}
		return result;
	}
};
