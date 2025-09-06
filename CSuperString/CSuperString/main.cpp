// ------------------------------------------------------------------------------------------

// Name: Anghus Henderson

// Class: C 2

// Abstract: CSuperString

// ------------------------------------------------------------------------------------------

// ------------------------------------------------------------------------------------------

// Includes

// ------------------------------------------------------------------------------------------
#include <stdlib.h>
#include <iostream>
#include "CSuperStringHeader.h"
using namespace std;

// ------------------------------------------------------------------------------------------

// Constants

// ------------------------------------------------------------------------------------------

// ------------------------------------------------------------------------------------------

// Prototypes

// ------------------------------------------------------------------------------------------

// ------------------------------------------------------------------------------------------

// Name: main

// Abstract: This is where the program starts

// ------------------------------------------------------------------------------------------

void main()
{
	/*CSuperString ssBuffer("I Love Star Trek");
	CSuperString ssBuffer( 3.14159f );*/

	cout << "------------------------------------------" << endl;
	cout << "CSuperString Tests" << endl;
	cout << "------------------------------------------" << endl;
	cout << endl;

	// #1 - Constructor
	CSuperString ssSource1;
	ssSource1.Print("#1 - Default Constructor");

	// #2 - Assignment Operator
	ssSource1 = "I Love Star Trek";
	ssSource1.Print("#2 - Assignment Constructor");

	// # 2.5 Return String

	cout << ssSource1.ToString();

	// #3 - Length
	cout << "#3 - Length: 16? " << ssSource1.Length() << endl;

	// #4 - Assignment On Same Line
	const char* strTestString = "I Love Star Trek";
	CSuperString ssSource2(strTestString);
	ssSource2.Print("#4 - Assignment On Same Line");

	// #5 - Assign Boolean to String
	bool blnTest = true;
	CSuperString ssSource3(blnTest);
	ssSource3.Print("#5 - Assign Boolean to String");

	// #5.5 - Check to See if String is Boolean and convert to a boolean.

	cout << "#5,5 - Check to See if String is Boolean" << endl;

	cout << ssSource3.ToBoolean() << endl;
	cout << ssSource1.ToBoolean() << endl;

	// #7 Convert Int To String

	CSuperString ssSource4(3);
	ssSource4.Print("#7 Convert Int To String");

	// #7.5 Convert String To Int

	cout << ssSource4.ToInteger();

	// #8 Convert Long To String

	long lngTestNumber = 1345297736;

	CSuperString ssSource5(lngTestNumber);
	ssSource5.Print("#8 Convert Long To String");

	// #9 Convert Short To String

	short shtTestNumber = 32767;

	CSuperString ssSource6(shtTestNumber);
	ssSource6.Print("#9 Convert Short To String");

	// #10 Convert String to Long

	cout << "#10 Convert String to Long: ";
	cout << ssSource5.ToLong() << endl;
	cout << ssSource1.ToLong() << endl;

	// #11 Convert String to Short

	cout << "#10 Convert String to Short: ";
	cout << ssSource6.ToShort() << endl;
	cout << ssSource1.ToShort() << endl;

	// #12 Convert Character To String

	char chrTestLetter = 'e';

	CSuperString ssSource7(chrTestLetter);
	ssSource7.Print("#12 Convert Character To String");

	// #13 Assignment Operator Character

	CSuperString ssSource8;
	ssSource8 = chrTestLetter;
	ssSource8.Print("#13 Assignment Operator Character");


	// #14 Convert Float to String

	CSuperString ssSource9(3.14159f);
	ssSource9.Print("#14 Convert Float to String");

	// #14.5 Convert String to Float

	cout << ssSource9.ToFloat();

	// #15 Convert Double to String
	double dblTestNumber = 3.14159f;
	CSuperString ssSource10(dblTestNumber);
	ssSource9.Print("#15 Convert Double to String");

	// #15.5 Convert String to Double

	cout << ssSource9.ToDouble();

	// #15 Get String From Super String and Send to Another Super String

	CSuperString ssSource11(ssSource1);
	ssSource11.Print("#15 Get String From Super String and Send to Another Super String");

	// #16 Assignment Operator CSuperString

	CSuperString ssSource12 = ssSource1;
	ssSource12.Print("#16 Assignment Operator CSuperString");

	// #17 Concatenate Operators
	const char* strTestString2 = "I Love";
	const char* strTestString3 = "And Star Trek";
	CSuperString ssSource13(strTestString2);
	CSuperString ssSource14(strTestString3);
	ssSource13.Print("#17 Concatenate Operators");
	ssSource13 += " Star Wars";
	ssSource13.Print("");
	ssSource13 += 'b';
	ssSource13.Print("");
	ssSource13 += ssSource14;
	ssSource13.Print("");

	// #18 The Other Concatenate Operators

	CSuperString ssSource15 = ssSource13 + ssSource14;
	ssSource15.Print("#18 The Other Concatenate Operators");
	CSuperString ssSource16 = "I Love Star Wars " + ssSource14;
	ssSource16.Print("");
	CSuperString ssSource17 = "I Love Star Wars ";
	CSuperString ssSource18 = ssSource17 + "And Star Trek Too";
	ssSource18.Print("");

	// #19 Comparison Operators

	CSuperString ssSource19 = "Banana";
	CSuperString ssSource20 = "Apple";
	CSuperString ssSource21 = "A";

	// equals

	ssSource19 == ssSource19;
	ssSource19 == ssSource20;
	ssSource19 == "Banana";
	ssSource19 == "Apple";
	ssSource21 == 'A';
	ssSource21 == 'B';

	// greater than

	ssSource19 > ssSource19;
	ssSource19 > ssSource20;
	ssSource20 > ssSource19;
	ssSource19 > "Banana";
	ssSource19 > "Apple";
	ssSource20 > "Banana";
	ssSource21 > 'A';
	ssSource21 > 'B';

	// lesser than

	ssSource19 < ssSource19;
	ssSource19 < ssSource20;
	ssSource20 < ssSource19;
	ssSource19 < "Banana";
	ssSource19 < "Apple";
	ssSource20 < "Banana";
	ssSource21 < 'A';
	ssSource21 < 'B';

	// Not Equal

	ssSource19 != ssSource19;
	ssSource19 != ssSource20;
	ssSource19 != "Banana";
	ssSource19 != "Apple";
	ssSource21 != 'A';
	ssSource21 != 'B';

	// greater than or equal to

	ssSource19 >= ssSource19;
	ssSource19 >= ssSource20;
	ssSource20 >= ssSource19;
	ssSource19 >= "Banana";
	ssSource19 >= "Apple";
	ssSource20 >= "Banana";
	ssSource21 >= 'A';
	ssSource21 >= 'B';

	// lesser than or equal to

	ssSource19 <= ssSource19;
	ssSource19 <= ssSource20;
	ssSource20 <= ssSource19;
	ssSource19 <= "Banana";
	ssSource19 <= "Apple";
	ssSource20 <= "Banana";
	ssSource21 <= 'A';
	ssSource21 <= 'B';


	// #17 Find First Index of

	cout << "#17 Find First Index of " << ssSource1.FindFirstIndexOf(chrTestLetter) << endl;

	cout << "#18 Find First Index of " << ssSource1.FindFirstIndexOf(chrTestLetter, 6) << endl;

	cout << "#19 Find Last Index of " << ssSource1.FindLastIndexOf(chrTestLetter) << endl;

	// #20 Find First Index of String

	const char* strIndexString = "Love";

	cout << "#20 Find First Index of String " << ssSource1.FindFirstIndexOf(strIndexString) << endl;
	cout << "#21 Find First Index of String " << ssSource1.FindFirstIndexOf(strIndexString, 4) << endl;
	cout << "#21 Find First Index of String " << ssSource1.FindFirstIndexOf(strIndexString, 0) << endl;
	cout << "#22 Find Last Index of String " << ssSource1.FindLastIndexOf(strIndexString) << endl;

	// #23 Uppercase Functionality

	cout << "#23 - Uppercase Functionality " << ssSource1.ToString() << endl;
	cout << "#23 - Uppercase Functionality " << ssSource1.ToUpperCase() << endl;
	cout << "#23 - Uppercase Functionality " << ssSource1.ToString() << endl;

	// #24 Lowercase Functionality

	cout << "#24 - Lowercase Functionality " << ssSource1.ToString() << endl;
	cout << "#24 - Lowercase Functionality " << ssSource1.ToLowerCase() << endl;
	cout << "#24 - Lowercase Functionality " << ssSource1.ToString() << endl;

	// #25 Trim Left

	CSuperString ssSource22 = "        I Love Star Trek        ";

	cout << "#25 - Trim Left " << ssSource22.ToString() << endl;
	cout << "#25 - Trim Left " << ssSource22.TrimLeft() << endl;
	cout << "#25 - Trim Left " << ssSource22.ToString() << endl;

	// #26 Trim Right

	cout << "#26 - Trim Right " << ssSource22.ToString() << endl;
	cout << "#26 - Trim Right " << ssSource22.TrimRight() << endl;
	cout << "#26 - Trim Right " << ssSource22.ToString() << endl;

	// #27 Trim

	cout << "#27 - Trim " << ssSource22.ToString() << endl;
	cout << "#27 - Trim " << ssSource22.Trim() << endl;
	cout << "#27 - Trim " << ssSource22.ToString() << endl;

	// #28 Reverse

	cout << "#28 - Reverse Functionality " << ssSource1.ToString() << endl;
	cout << "#28 - Reverse Functionality " << ssSource1.Reverse() << endl;
	cout << "#28 - Reverse Functionality " << ssSource1.ToString() << endl;

	// #29 Left Copy

	CSuperString ssSource23 = ssSource1.Left(6);
	ssSource23.Print("#29 Left Copy");

	// #30 Right Copy

	CSuperString ssSource24 = ssSource1.Right(6);
	ssSource24.Print("#30 Right Copy");

	// #31 Substring

	CSuperString ssSource25 = ssSource1.Substring(2, 4);
	ssSource25.Print("#31 Substring");

	// #32 Replace

	ssSource23.Print("#32 Replace");
	cout << ssSource23.Replace('L', 'D') << endl;
	ssSource23.Print("");

	// #33 Replace String

	ssSource23.Print("#33 Replace String");
	cout << ssSource23.Replace("Love", "Hate") << endl;
	ssSource23.Print("");

	// #34 Insert

	ssSource23.Print("#34 Insert");
	cout << ssSource23.Insert('L', 3) << endl;
	ssSource23.Print("");

	// #35 Insert String

	ssSource23.Print("#35 Insert String");
	cout << ssSource23.Insert("Hate", 3) << endl;
	ssSource23.Print("");

	// #36 [] operator

	ssSource23.Print("#36 [] operator");
	cout << ssSource23[3] << endl;
	ssSource23.Print("");

	system("Pause");

}

#pragma endregion