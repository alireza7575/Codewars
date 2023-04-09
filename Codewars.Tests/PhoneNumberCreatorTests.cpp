#include "gtest/gtest.h"
#include "../Codewars/PhoneNumberCreator.cpp"


TEST(GetPhoneNumberAsString, NumberShouldBeValid)
{
	constexpr int number[10] = {1, 2, 3};
	ASSERT_EQ(PhoneNumberCreator::to_string(number), "(123) 000-0000");
}
