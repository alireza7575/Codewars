#include <iostream>
#include <string>


class rot13_cipher
{
public:
	static std::string encode(const std::string& message)
	{
		std::string result;
		for (const char character : message)
		{
			int encoded = std::isalpha(character) ? character + 13: character;
			if (!std::isupper(character))
			{
				if (encoded > 'z')
					encoded = 'a' + 12 - ('z' - character);
			}
			else
			{
				if (encoded > 'Z')
					encoded = 'A' + 12 - ('Z' - character);
			}
			result += static_cast<char>(encoded);
		}
		return result;
	}
};
