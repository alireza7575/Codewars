#include "gtest/gtest.h"
#include "../Codewars/phone_number_creator.cpp"


TEST(GetPhoneNumberAsString, NumberShouldBeValid)
{
	constexpr int number[10] = {1, 2, 3};
	ASSERT_EQ(phone_number_creator::to_string(number), "(123) 000-0000");
}
