#include <sstream>
#include <iomanip>

class rgb_convertor
{
public:
	static std::string to_hex(int r, int g, int b)
	{
		r = std::max(0, std::min(255, r));
		g = std::max(0, std::min(255, g));
		b = std::max(0, std::min(255, b));
		std::stringstream hex_version;
		hex_version << std::uppercase << std::setfill('0') << std::setw(2) << std::hex << r
			<< std::setfill('0') << std::setw(2) << std::hex << g
			<< std::setfill('0') << std::setw(2) << std::hex << b;
		return hex_version.str();
	}
};
