#include "../Codewars/rgb_convertor.cpp"
#include "gtest/gtest.h"


TEST(ConverRgbColorToHex, BlackColor)
{
	ASSERT_EQ(rgb_convertor::to_hex(0,0,0), "000000");
}

TEST(ConverRgbColorToHex, WhiteColor)
{
	ASSERT_EQ(rgb_convertor::to_hex(255,255,255), "FFFFFF");
}

TEST(ConverRgbColorToHex, OtherColors)
{
	ASSERT_EQ(rgb_convertor::to_hex(1,2,3), "010203");
	ASSERT_EQ(rgb_convertor::to_hex(254,253,252), "FEFDFC");
	ASSERT_EQ(rgb_convertor::to_hex(-20,275,125), "00FF7D");
}
