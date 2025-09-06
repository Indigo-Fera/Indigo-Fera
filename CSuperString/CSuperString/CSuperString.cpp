
#include <stdlib.h>
#include <iostream>
#include <sstream>
#include "CSuperStringHeader.h";
using namespace std;


CSuperString::CSuperString()
{
	Initialize("");
}

CSuperString::CSuperString(const char* pstrStringToCopy)
{
	Initialize(pstrStringToCopy);
}

CSuperString::CSuperString(const bool blnBooleanToCopy)
{
	if (blnBooleanToCopy == true)
	{
		const char* pstrStringToCopy = "True";
		Initialize(pstrStringToCopy);
	}
	else
	{
		const char* pstrStringToCopy = "False";
		Initialize(pstrStringToCopy);
	}
}

CSuperString::CSuperString(const char chrLetterToCopy)
{
	char strBuffer[2];

	strBuffer[0] = chrLetterToCopy;
	strBuffer[1] = '\0';

	const char* pstrStringToCopy = strBuffer;

	Initialize(pstrStringToCopy);
}

CSuperString::CSuperString(const int intIntegerToCopy)
{
	char strBuffer[50];
	int intIndex = 0;

	bool isNeg = false;
	if (intIntegerToCopy < 0) {
		isNeg = true;
	}

	unsigned int intIntegerToCopyUnsigned = intIntegerToCopy;

	if (isNeg) {
		intIntegerToCopyUnsigned = -intIntegerToCopy;
	}

	while (intIntegerToCopyUnsigned != 0)
	{
		strBuffer[intIndex++] = intIntegerToCopyUnsigned % 10 + '0';
		intIntegerToCopyUnsigned = intIntegerToCopyUnsigned / 10;
	}

	if (isNeg)
	{
		strBuffer[intIndex++] = '-';
	}

	strBuffer[intIndex] = '\0';

	for (int intIndex2 = 0; intIndex2 < intIndex / 2; intIndex2++)
	{
		strBuffer[intIndex2] ^= strBuffer[intIndex - intIndex2 - 1];
		strBuffer[intIndex - intIndex2 - 1] ^= strBuffer[intIndex2];
		strBuffer[intIndex2] ^= strBuffer[intIndex - intIndex2 - 1];
	}

	if (intIntegerToCopy == 0)
	{
		strBuffer[0] = '0';
		strBuffer[1] = '\0';
	}

	const char* pstrStringToCopy = strBuffer;

	Initialize(pstrStringToCopy);
}

CSuperString::CSuperString(const short shtShortToCopy)
{
	char strBuffer[25];
	int intIndex = 0;

	bool isNeg = false;
	if (shtShortToCopy < 0) {
		isNeg = true;
	}

	unsigned short shtShortToCopyUnsigned = shtShortToCopy;

	if (isNeg) {
		shtShortToCopyUnsigned = -shtShortToCopy;
	}

	while (shtShortToCopyUnsigned != 0)
	{
		strBuffer[intIndex++] = shtShortToCopyUnsigned % 10 + '0';
		shtShortToCopyUnsigned = shtShortToCopyUnsigned / 10;
	}

	if (isNeg)
	{
		strBuffer[intIndex++] = '-';
	}

	strBuffer[intIndex] = '\0';

	for (int intIndex2 = 0; intIndex2 < intIndex / 2; intIndex2++)
	{
		strBuffer[intIndex2] ^= strBuffer[intIndex - intIndex2 - 1];
		strBuffer[intIndex - intIndex2 - 1] ^= strBuffer[intIndex2];
		strBuffer[intIndex2] ^= strBuffer[intIndex - intIndex2 - 1];
	}

	if (shtShortToCopy == 0)
	{
		strBuffer[0] = '0';
		strBuffer[1] = '\0';
	}

	const char* pstrStringToCopy = strBuffer;

	Initialize(pstrStringToCopy);
}

CSuperString::CSuperString(const long lngLongToCopy)
{
	char strBuffer[100];
	long lngIndex = 0;

	bool isNeg = false;
	if (lngLongToCopy < 0) {
		isNeg = true;
	}

	unsigned long shtLongToCopyUnsigned = lngLongToCopy;

	if (isNeg) {
		shtLongToCopyUnsigned = -lngLongToCopy;
	}

	while (shtLongToCopyUnsigned != 0)
	{
		strBuffer[lngIndex++] = shtLongToCopyUnsigned % 10 + '0';
		shtLongToCopyUnsigned = shtLongToCopyUnsigned / 10;
	}

	if (isNeg)
	{
		strBuffer[lngIndex++] = '-';
	}

	strBuffer[lngIndex] = '\0';

	for (long lngIndex2 = 0; lngIndex2 < lngIndex / 2; lngIndex2++)
	{
		strBuffer[lngIndex2] ^= strBuffer[lngIndex - lngIndex2 - 1];
		strBuffer[lngIndex - lngIndex2 - 1] ^= strBuffer[lngIndex2];
		strBuffer[lngIndex2] ^= strBuffer[lngIndex - lngIndex2 - 1];
	}

	if (lngLongToCopy == 0)
	{
		strBuffer[0] = '0';
		strBuffer[1] = '\0';
	}

	const char* pstrStringToCopy = strBuffer;

	Initialize(pstrStringToCopy);
}

CSuperString::CSuperString(const float sngFloatToCopy)
{
	stringstream ssStream;
	ssStream << sngFloatToCopy;
	string strStringConverted = ssStream.str();
	const char* pstrStringToCopy = strStringConverted.c_str();
	Initialize(pstrStringToCopy);
}

CSuperString::CSuperString(const double dblDoubleToCopy)
{
	stringstream ssStream;
	ssStream << dblDoubleToCopy;
	string strStringConverted = ssStream.str();
	const char* pstrStringToCopy = strStringConverted.c_str();
	Initialize(pstrStringToCopy);
}

CSuperString::CSuperString(const CSuperString& ssStringToCopy)
{
	const char* pstrStringToCopy = ssStringToCopy.ToString();
	Initialize(pstrStringToCopy);
}

void CSuperString::Initialize(const char* pstrSource)
{
	m_pstrSuperString = 0;

	// funnel all memory allocation through the assignment operator
	*this = pstrSource;
}

long CSuperString::Length() const
{
	long lngLength = 0;

	lngLength = (long)strlen(m_pstrSuperString);


	return lngLength;
}

CSuperString::~CSuperString()
{
	CleanUp();
}

void CSuperString::operator = (const char* pstrStringToCopy)
{
	if(m_pstrSuperString != pstrStringToCopy)
	{ 
		CleanUp();

		DeepCopy(pstrStringToCopy);
	}
}

void CSuperString::operator = (const char chrLetterToCopy)
{
	char strBuffer[2];

	strBuffer[0] = chrLetterToCopy;
	strBuffer[1] = '\0';

	const char* pstrStringToCopy = strBuffer;

	if (m_pstrSuperString != pstrStringToCopy)
	{
		CleanUp();

		DeepCopy(pstrStringToCopy);
	}
}

void CSuperString::operator = (const CSuperString& ssStringToCopy)
{
	const char* pstrStringToCopy = ssStringToCopy.ToString();

	if (m_pstrSuperString != pstrStringToCopy)
	{
		CleanUp();

		DeepCopy(pstrStringToCopy);
	}
}

void CSuperString::operator += (const char* pstrStringToAppend)
{
	stringstream ssStream;
	ssStream << m_pstrSuperString;
	string strSuperStringConverted = ssStream.str();
	ssStream << pstrStringToAppend;
	string strStringConvertedAppend = ssStream.str();
	const char* pstrStringToCopy = strStringConvertedAppend.c_str();
	DeepCopy(pstrStringToCopy);
}

void CSuperString::operator += (const char chrCharacterToAppend)
{
	stringstream ssStream;
	ssStream << m_pstrSuperString;
	string strSuperStringConverted = ssStream.str();
	ssStream << chrCharacterToAppend;
	string strStringConvertedAppend = ssStream.str();
	const char* pstrStringToCopy = strStringConvertedAppend.c_str();
	DeepCopy(pstrStringToCopy);
}

void CSuperString::operator += (const CSuperString& ssStringToAppend)
{
	stringstream ssStream;
	ssStream << m_pstrSuperString;
	string strSuperStringConverted = ssStream.str();
	ssStream << ssStringToAppend.ToString();
	string strStringConvertedAppend = ssStream.str();
	const char* pstrStringToCopy = strStringConvertedAppend.c_str();
	DeepCopy(pstrStringToCopy);
}

CSuperString operator + (const CSuperString& ssLeft, const CSuperString& ssRight)
{
	stringstream ssStream;
	ssStream << ssLeft.ToString();
	string strSuperStringConverted = ssStream.str();
	ssStream << ssRight.ToString();
	string strStringConvertedAppend = ssStream.str();
	const char* pstrStringToCopy = strStringConvertedAppend.c_str();
	return pstrStringToCopy;
}

CSuperString operator + (const char* pstrLeftSide, const CSuperString& ssRightString)
{
	stringstream ssStream;
	ssStream << pstrLeftSide;
	string strSuperStringConverted = ssStream.str();
	ssStream << ssRightString.ToString();
	string strStringConvertedAppend = ssStream.str();
	const char* pstrStringToCopy = strStringConvertedAppend.c_str();
	return pstrStringToCopy;
}

CSuperString operator + (const CSuperString& ssLeftString, const char* pstrRightSide)
{
	stringstream ssStream;
	ssStream << ssLeftString.ToString();
	string strSuperStringConverted = ssStream.str();
	ssStream << pstrRightSide;
	string strStringConvertedAppend = ssStream.str();
	const char* pstrStringToCopy = strStringConvertedAppend.c_str();
	return pstrStringToCopy;
}

void CSuperString::operator == (const char* pstrStringToCompare)
{
	long lngStringLength = Length();
	long lngStringSame = 0;
		for (int intIndex = 0; intIndex < lngStringLength; intIndex += 1)
		{
			if (pstrStringToCompare[intIndex] == m_pstrSuperString[intIndex])
			{
				lngStringSame += 1;
			}
		}

		if (lngStringSame == lngStringLength)
		{
			cout << "" << endl;
			cout << "Yes, Strings Are The Same" << endl;
		}
		else
		{
			cout << "" << endl;
			cout << "No, Strings Are Different " << endl;
		}
}

void CSuperString::operator == (const char chrCharacterToCompare)
{
	long lngStringLength = Length();
	long lngStringSame = 0;
		for (int intIndex = 0; intIndex < lngStringLength; intIndex += 1)
		{
			if (chrCharacterToCompare == m_pstrSuperString[intIndex])
			{
				lngStringSame += 1;
			}
		}

		if (lngStringSame == lngStringLength)
		{
			cout << "" << endl;
			cout << "Yes, Character is The Same";
		}
		else
		{
			cout << "" << endl;
			cout << "No, Character is Different";
		}
}

void CSuperString::operator == (const CSuperString& ssStringToCompare)
{
	long lngStringLength = Length();
	const char* pstrStringToCompare = ssStringToCompare.ToString();
	long lngStringSame = 0;
	for (int intIndex = 0; intIndex < lngStringLength; intIndex += 1)
	{
		if (pstrStringToCompare[intIndex] == m_pstrSuperString[intIndex])
		{
			lngStringSame += 1;
		}
	}

	if (lngStringSame == lngStringLength)
	{
		cout << "" << endl;
		cout << "Yes, Strings Are The Same";
	}
	else
	{
		cout << "" << endl;
		cout << "No, Strings Are Different";
	}
}

void CSuperString::operator > (const char* pstrStringToCompare)
{
	long lngStringLength = Length();
	long lngFirstString = 0;
	long lngStringSame = 0;

	for (int intIndex = 0; intIndex < lngStringLength; intIndex += 1)
	{
		if (pstrStringToCompare[intIndex] == m_pstrSuperString[intIndex])
		{
			lngStringSame += 1;
		}
		else if (pstrStringToCompare[intIndex] > m_pstrSuperString[intIndex])
		{
			lngFirstString = 1;
			break;

		}
		else
		{
			break;
		}
	}
	
	if (lngStringSame == lngStringLength)
	{
		cout << "" << endl;
		cout << "No, " << m_pstrSuperString << " Is The Same As " << pstrStringToCompare;
	}
	else if (lngFirstString == 1)
	{
		cout << "" << endl;
		cout << "Yes, " << m_pstrSuperString << " Comes Before " << pstrStringToCompare;
	}
	else
	{
		cout << "" << endl;
		cout << "No, " << m_pstrSuperString << " Comes After " << pstrStringToCompare;
	}

}

void CSuperString::operator > (const char chrCharacterToCompare)
{
	long lngStringLength = Length();
	long lngFirstString = 0;
	long lngStringSame = 0;

	for (int intIndex = 0; intIndex < lngStringLength; intIndex += 1)
	{
		if (chrCharacterToCompare == m_pstrSuperString[intIndex])
		{
			lngStringSame += 1;
		}
		else if (chrCharacterToCompare > m_pstrSuperString[intIndex])
		{
			lngFirstString = 1;
			break;

		}
		else
		{
			break;
		}
	}

	if (lngFirstString == 1)
	{
		cout << "" << endl;
		cout << "Yes, " << m_pstrSuperString << " Comes Before " << chrCharacterToCompare;
	}
	else if (lngStringSame == lngStringLength)
	{
		cout << "" << endl;
		cout << "No, " << m_pstrSuperString << " Is The Same As " << chrCharacterToCompare;
	}
	else
	{
		cout << "" << endl;
		cout << "No, " << m_pstrSuperString << " Comes After " << chrCharacterToCompare;
	}

}

void CSuperString::operator > (const CSuperString& ssStringToCompare)
{
	long lngStringLength = Length();
	const char* pstrStringToCompare = ssStringToCompare.ToString();
	long lngFirstString = 0;
	long lngStringSame = 0;

	for (int intIndex = 0; intIndex < lngStringLength; intIndex += 1)
	{
		if (pstrStringToCompare[intIndex] == m_pstrSuperString[intIndex])
		{
			lngStringSame += 1;
		}
		else if (pstrStringToCompare[intIndex] > m_pstrSuperString[intIndex])
		{
			lngFirstString = 1;
			break;

		}
		else
		{
			break;
		}
	}

	if (lngStringSame == lngStringLength)
	{
		cout << "" << endl;
		cout << "No, " << m_pstrSuperString << " Is The Same As " << pstrStringToCompare;
	}
	else if (lngFirstString == 1)
	{
		cout << "" << endl;
		cout << "Yes, " << m_pstrSuperString << " Comes Before " << pstrStringToCompare;
	}
	else
	{
		cout << "" << endl;
		cout << "No, " << m_pstrSuperString << " Comes After " << pstrStringToCompare;
	}
}

void CSuperString::operator < (const char* pstrStringToCompare)
{
	long lngStringLength = Length();
	long lngFirstString = 0;
	long lngStringSame = 0;

	for (int intIndex = 0; intIndex < lngStringLength; intIndex += 1)
	{
		if (pstrStringToCompare[intIndex] == m_pstrSuperString[intIndex])
		{
			lngStringSame += 1;
		}
		else if (pstrStringToCompare[intIndex] < m_pstrSuperString[intIndex])
		{
			lngFirstString = 1;
			break;

		}
		else
		{
			break;
		}
	}

	if (lngStringSame == lngStringLength)
	{
		cout << "" << endl;
		cout << "No, " << pstrStringToCompare << " Is The Same As " << m_pstrSuperString;
	}
	else if (lngFirstString == 1)
	{
		cout << "" << endl;
		cout << "Yes, " << pstrStringToCompare << " Comes Before " << m_pstrSuperString;
	}
	else
	{
		cout << "" << endl;
		cout << "No, " << pstrStringToCompare << " Comes After " << m_pstrSuperString;
	}

}

void CSuperString::operator < (const char chrCharacterToCompare)
{
	long lngStringLength = Length();
	long lngFirstString = 0;
	long lngStringSame = 0;

	for (int intIndex = 0; intIndex < lngStringLength; intIndex += 1)
	{
		if (chrCharacterToCompare == m_pstrSuperString[intIndex])
		{
			lngStringSame += 1;
		}
		else if (chrCharacterToCompare < m_pstrSuperString[intIndex])
		{
			lngFirstString = 1;
			break;

		}
		else
		{
			break;
		}
	}

	if (lngStringSame == lngStringLength)
	{
		cout << "" << endl;
		cout << "No, " << chrCharacterToCompare << " Is The Same As " << m_pstrSuperString;
	}
	else if (lngFirstString == 1)
	{
		cout << "" << endl;
		cout << "Yes, " << chrCharacterToCompare << " Comes Before " << m_pstrSuperString;
	}
	else
	{
		cout << "" << endl;
		cout << "No, " << chrCharacterToCompare << " Comes After " << m_pstrSuperString;
	}

}

void CSuperString::operator < (const CSuperString& ssStringToCompare)
{
	long lngStringLength = Length();
	const char* pstrStringToCompare = ssStringToCompare.ToString();
	long lngFirstString = 0;
	long lngStringSame = 0;

	for (int intIndex = 0; intIndex < lngStringLength; intIndex += 1)
	{
		if (pstrStringToCompare[intIndex] == m_pstrSuperString[intIndex])
		{
			lngStringSame += 1;
		}
		else if (pstrStringToCompare[intIndex] < m_pstrSuperString[intIndex])
		{
			lngFirstString = 1;
			break;

		}
		else
		{
			break;
		}
	}

	if (lngStringSame == lngStringLength)
	{
		cout << "" << endl;
		cout << "No, " << pstrStringToCompare << " Is The Same As " << m_pstrSuperString;
	}
	else if (lngFirstString == 1)
	{
		cout << "" << endl;
		cout << "Yes, " << pstrStringToCompare << " Comes Before " << m_pstrSuperString;
	}
	else
	{
		cout << "" << endl;
		cout << "No, " << pstrStringToCompare << " Comes After " << m_pstrSuperString;
	}
}

void CSuperString::operator != (const char* pstrStringToCompare)
{
	long lngStringLength = Length();
	long lngStringSame = 0;
	for (int intIndex = 0; intIndex < lngStringLength; intIndex += 1)
	{
		if (pstrStringToCompare[intIndex] == m_pstrSuperString[intIndex])
		{
			lngStringSame += 1;
		}
	}

	if (lngStringSame == lngStringLength)
	{
		cout << "" << endl;
		cout << "No, Strings Are The Same";
	}
	else
	{
		cout << "" << endl;
		cout << "Yes, Strings Are Different";
	}
}

void CSuperString::operator != (const char chrCharacterToCompare)
{
	long lngStringLength = Length();
	long lngStringSame = 0;
	for (int intIndex = 0; intIndex < lngStringLength; intIndex += 1)
	{
		if (chrCharacterToCompare == m_pstrSuperString[intIndex])
		{
			lngStringSame += 1;
		}
	}

	if (lngStringSame == lngStringLength)
	{
		cout << "" << endl;
		cout << "No, Character is The Same";
	}
	else
	{
		cout << "" << endl;
		cout << "Yes, Character is Different";
	}
}

void CSuperString::operator != (const CSuperString& ssStringToCompare)
{
	long lngStringLength = Length();
	const char* pstrStringToCompare = ssStringToCompare.ToString();
	long lngStringSame = 0;
	for (int intIndex = 0; intIndex < lngStringLength; intIndex += 1)
	{
		if (pstrStringToCompare[intIndex] == m_pstrSuperString[intIndex])
		{
			lngStringSame += 1;
		}
	}

	if (lngStringSame == lngStringLength)
	{
		cout << "" << endl;
		cout << "No, Strings Are The Same";
	}
	else
	{
		cout << "" << endl;
		cout << "Yes, Strings Are Different";
	}
}

void CSuperString::operator >= (const char* pstrStringToCompare)
{
	long lngStringLength = Length();
	long lngFirstString = 0;
	long lngStringSame = 0;

	for (int intIndex = 0; intIndex < lngStringLength; intIndex += 1)
	{
		if (pstrStringToCompare[intIndex] == m_pstrSuperString[intIndex])
		{
			lngStringSame += 1;
		}
		else if (pstrStringToCompare[intIndex] < m_pstrSuperString[intIndex])
		{
			lngFirstString = 1;
			break;

		}
		else
		{
			break;
		}
	}

	if (lngStringSame == lngStringLength)
	{
		cout << "" << endl;
		cout << "Yes, " << m_pstrSuperString << " Is The Same As " << pstrStringToCompare;
	}
	else if (lngFirstString == 1)
	{
		cout << "" << endl;
		cout << "Yes, " << m_pstrSuperString << " Comes Before " << pstrStringToCompare;
	}
	else
	{
		cout << "" << endl;
		cout << "No, " << m_pstrSuperString << " Comes After " << pstrStringToCompare;
	}

}

void CSuperString::operator >= (const char chrCharacterToCompare)
{
	long lngStringLength = Length();
	long lngFirstString = 0;
	long lngStringSame = 0;

	for (int intIndex = 0; intIndex < lngStringLength; intIndex += 1)
	{
		if (chrCharacterToCompare == m_pstrSuperString[intIndex])
		{
			lngStringSame += 1;
		}
		else if (chrCharacterToCompare < m_pstrSuperString[intIndex])
		{
			lngFirstString = 1;
			break;

		}
		else
		{
			break;
		}
	}

	if (lngFirstString == 1)
	{
		cout << "" << endl;
		cout << "Yes, " << m_pstrSuperString << " Comes Before " << chrCharacterToCompare;
	}
	else if (lngStringSame == lngStringLength)
	{
		cout << "" << endl;
		cout << "Yes, " << m_pstrSuperString << " Is The Same As " << chrCharacterToCompare;
	}
	else
	{
		cout << "" << endl;
		cout << "No, " << m_pstrSuperString << " Comes After " << chrCharacterToCompare;
	}

}

void CSuperString::operator >= (const CSuperString& ssStringToCompare)
{
	long lngStringLength = Length();
	const char* pstrStringToCompare = ssStringToCompare.ToString();
	long lngFirstString = 0;
	long lngStringSame = 0;

	for (int intIndex = 0; intIndex < lngStringLength; intIndex += 1)
	{
		if (pstrStringToCompare[intIndex] == m_pstrSuperString[intIndex])
		{
			lngStringSame += 1;
		}
		else if (pstrStringToCompare[intIndex] < m_pstrSuperString[intIndex])
		{
			lngFirstString = 1;
			break;

		}
		else
		{
			break;
		}
	}

	if (lngStringSame == lngStringLength)
	{
		cout << "" << endl;
		cout << "Yes, " << m_pstrSuperString << " Is The Same As " << pstrStringToCompare;
	}
	else if (lngFirstString == 1)
	{
		cout << "" << endl;
		cout << "Yes, " << m_pstrSuperString << " Comes Before " << pstrStringToCompare;
	}
	else
	{
		cout << "" << endl;
		cout << "No, " << m_pstrSuperString << " Comes After " << pstrStringToCompare;
	}
}

void CSuperString::operator <= (const char* pstrStringToCompare)
{
	long lngStringLength = Length();
	long lngFirstString = 0;
	long lngStringSame = 0;

	for (int intIndex = 0; intIndex < lngStringLength; intIndex += 1)
	{
		if (pstrStringToCompare[intIndex] == m_pstrSuperString[intIndex])
		{
			lngStringSame += 1;
		}
		else if (pstrStringToCompare[intIndex] < m_pstrSuperString[intIndex])
		{
			lngFirstString = 1;
			break;

		}
		else
		{
			break;
		}
	}

	if (lngStringSame == lngStringLength)
	{
		cout << "" << endl;
		cout << "Yes, " << pstrStringToCompare << " Is The Same As " << m_pstrSuperString;
	}
	else if (lngFirstString == 1)
	{
		cout << "" << endl;
		cout << "Yes, " << pstrStringToCompare << " Comes Before " << m_pstrSuperString;
	}
	else
	{
		cout << "" << endl;
		cout << "No, " << pstrStringToCompare << " Comes After " << m_pstrSuperString;
	}

}

void CSuperString::operator <= (const char chrCharacterToCompare)
{
	long lngStringLength = Length();
	long lngFirstString = 0;
	long lngStringSame = 0;

	for (int intIndex = 0; intIndex < lngStringLength; intIndex += 1)
	{
		if (chrCharacterToCompare == m_pstrSuperString[intIndex])
		{
			lngStringSame += 1;
		}
		else if (chrCharacterToCompare < m_pstrSuperString[intIndex])
		{
			lngFirstString = 1;
			break;

		}
		else
		{
			break;
		}
	}

	if (lngStringSame == lngStringLength)
	{
		cout << "" << endl;
		cout << "Yes, " << chrCharacterToCompare << " Is The Same As " << m_pstrSuperString;
	}
	else if (lngFirstString == 1)
	{
		cout << "" << endl;
		cout << "Yes, " << chrCharacterToCompare << " Comes Before " << m_pstrSuperString;
	}
	else
	{
		cout << "" << endl;
		cout << "No, " << chrCharacterToCompare << " Comes After " << m_pstrSuperString;
	}

}

void CSuperString::operator <= (const CSuperString& ssStringToCompare)
{
	long lngStringLength = Length();
	const char* pstrStringToCompare = ssStringToCompare.ToString();
	long lngFirstString = 0;
	long lngStringSame = 0;

	for (int intIndex = 0; intIndex < lngStringLength; intIndex += 1)
	{
		if (pstrStringToCompare[intIndex] == m_pstrSuperString[intIndex])
		{
			lngStringSame += 1;
		}
		else if (pstrStringToCompare[intIndex] < m_pstrSuperString[intIndex])
		{
			lngFirstString = 1;
			break;

		}
		else
		{
			break;
		}
	}

	if (lngStringSame == lngStringLength)
	{
		cout << "" << endl;
		cout << "Yes, " << pstrStringToCompare << " Is The Same As " << m_pstrSuperString;
	}
	else if (lngFirstString == 1)
	{
		cout << "" << endl;
		cout << "Yes, " << pstrStringToCompare << " Comes Before " << m_pstrSuperString;
	}
	else
	{
		cout << "" << endl;
		cout << "No, " << pstrStringToCompare << " Comes After " << m_pstrSuperString;
	}
}

void CSuperString::CleanUp()
{
	DeleteString(m_pstrSuperString);
}

void CSuperString::DeleteString(const char*& pstrSource)
{
	if (pstrSource != 0)
	{
		delete pstrSource;
		pstrSource = 0;
	}
}

void CSuperString::DeepCopy(const char* pstrSource)
{
	m_pstrSuperString = CloneString(pstrSource);
}

char* CSuperString::CloneString(const char* pstrSource)
{
	char* pstrClone = 0;
	long lngLength = 0;

	if (pstrSource != 0)
	{
		lngLength = strlen(pstrSource);
		pstrClone = new char[lngLength + 1];
		strcpy_s(pstrClone, lngLength + 1, pstrSource);
	}
	else
	{
		pstrClone = new char[1];
		*(pstrClone + 0) = 0;
	}

	return pstrClone;
}

long CSuperString::FindFirstIndexOf(const char chrLetterToFind)
{
	const long intStringLength = Length();

	for (long lngIndex = 0; lngIndex < intStringLength; ++lngIndex)
	{
		if (m_pstrSuperString[lngIndex] == chrLetterToFind)
		{
			return lngIndex + 1;
		}
	}
	cout << "Character not in String, Returning Zero" << endl;
	return 0;
}

long CSuperString::FindFirstIndexOf(const char chrLetterToFind, long lngStartIndex)
{
	const long intStringLength = Length();

	for (long lngIndex = lngStartIndex; lngIndex < intStringLength; ++lngIndex)
	{
		if (m_pstrSuperString[lngIndex] == chrLetterToFind)
		{
			return lngIndex + 1;
		}
	}
	cout << "Character not in String After Specified Index, Returning Zero" << endl;
	return 0;
}

long CSuperString::FindLastIndexOf(const char chrLetterToFind)
{
	const long lngStringLength = Length();

	for (long lngIndex = lngStringLength; lngIndex > 0; --lngIndex)
	{
		if (m_pstrSuperString[lngIndex] == chrLetterToFind)
		{
			return lngIndex + 1;
		}
	}
	cout << "Character not in String, Returning Zero" << endl;
	return 0;
}

long CSuperString::FindFirstIndexOf(const char* pstrSubStringToFind)
{
	const long lngStringLength = Length();
	long lngNumberofCharFound = 0;
	long lngStartofComparison = 0;
	long lngLengthOfSubString = (long)strlen(pstrSubStringToFind);

	for (long lngIndex = 0; lngIndex < lngStringLength; ++lngIndex)
	{
		if (m_pstrSuperString[lngIndex] == pstrSubStringToFind[lngNumberofCharFound])
		{
			lngNumberofCharFound += 1;
			lngStartofComparison = lngIndex + 2;
			if (lngNumberofCharFound == lngLengthOfSubString)
			{
				return lngStartofComparison - lngLengthOfSubString;
			}
		}
		else
		{
			lngNumberofCharFound = 0;
		}
	}
	cout << "String Not In String" << endl;
	return 0;
}

long CSuperString::FindFirstIndexOf(const char* pstrSubStringToFind, long lngStartIndex)
{
	const long lngStringLength = Length();
	long lngNumberofCharFound = 0;
	long lngStartofComparison = 0;
	long lngLengthOfSubString = (long)strlen(pstrSubStringToFind);

	for (long lngIndex = lngStartIndex; lngIndex < lngStringLength; ++lngIndex)
	{
		if (m_pstrSuperString[lngIndex] == pstrSubStringToFind[lngNumberofCharFound])
		{
			lngNumberofCharFound += 1;
			lngStartofComparison = lngIndex + 2;
			if (lngNumberofCharFound == lngLengthOfSubString)
			{
				return lngStartofComparison - lngLengthOfSubString;
			}
		}
		else
		{
			lngNumberofCharFound = 0;
		}
	}
	cout << "String Not In String" << endl;
	return 0;
}

long CSuperString::FindLastIndexOf(const char* pstrSubStringToFind)
{
	const long lngStringLength = Length();
	long lngStartofComparison = 0;
	long lngLengthOfSubString = (long)strlen(pstrSubStringToFind);
	long lngNumberofCharFound = lngLengthOfSubString - 1;

	for (long lngIndex = lngStringLength; lngIndex > 0; --lngIndex)
	{
		if (m_pstrSuperString[lngIndex] == pstrSubStringToFind[lngNumberofCharFound])
		{
			lngStartofComparison = lngIndex;
			lngNumberofCharFound -= 1;
			if (lngNumberofCharFound == 0)
			{
				return lngStartofComparison;
			}
		}
		else
		{
			lngNumberofCharFound = lngLengthOfSubString - 1;
		}
	}
	cout << "String Not In String" << endl;
	return 0;
}

const char* CSuperString::ToUpperCase()
{
	const long lngStringLength = Length();
	char* pstrUpper = new char[lngStringLength + 1];
	for (int intIndex = 0; intIndex < lngStringLength + 1; intIndex++)
	{
		pstrUpper[intIndex] = toupper(m_pstrSuperString[intIndex]);
	}
		return pstrUpper;
}

const char* CSuperString::ToLowerCase()
{
	const long lngStringLength = Length();
	char* pstrLower = new char[lngStringLength + 1];
	for (int intIndex = 0; intIndex < lngStringLength + 1; intIndex++)
	{
		pstrLower[intIndex] = tolower(m_pstrSuperString[intIndex]);
	}
	return pstrLower;
}

const char* CSuperString::TrimLeft()
{
	const long lngStringLength = Length();
	char* pstrLeftTrim = new char[lngStringLength + 1];
	char chrSpace = ' ';
	int intIndex2 = 0;
	int intIndex = 0;
	int intStartFrom = 0;
	
	do{
		intIndex += 1;
	} while (m_pstrSuperString[intIndex] == chrSpace);

	for (intIndex; intIndex < lngStringLength + 1; intIndex++)
	{
			pstrLeftTrim[intIndex2] = m_pstrSuperString[intIndex];
			intIndex2 += 1;
	}
	return pstrLeftTrim;
}

const char* CSuperString::TrimRight()
{
	const long lngStringLength = Length();
	char* pstrBuffer = new char[lngStringLength + 1];
	char chrSpace = ' ';
	int intIndex2 = 0;
	int intLastNonSpaceCharacter = 0;
	for (int intIndex = 0; intIndex < lngStringLength; intIndex++)
	{
			pstrBuffer[intIndex2] = m_pstrSuperString[intIndex];
			intIndex2 += 1;

			if (m_pstrSuperString[intIndex] != chrSpace)
			{
				intLastNonSpaceCharacter = intIndex;
			}
	}

	char* pstrRightTrim = new char[intLastNonSpaceCharacter + 1];
	intIndex2 = 0;
	for (int intIndex = 0; intIndex < intLastNonSpaceCharacter + 1; intIndex++)
	{
		pstrRightTrim[intIndex2] = pstrBuffer[intIndex];
		intIndex2 += 1;
	}
	pstrRightTrim[intLastNonSpaceCharacter + 1] = '\0';
	return pstrRightTrim;
}

const char* CSuperString::Trim()
{
	const long lngStringLength = Length();
	char* pstrLeftTrim = new char[lngStringLength + 1];
	char chrSpace = ' ';
	int intIndex2 = 0;
	int intIndex = 0;
	int intStartFrom = 0;
	int intLastNonSpaceCharacter = 0;

	do {
		intStartFrom += 1;
		intIndex += 1;
	} while (m_pstrSuperString[intIndex] == chrSpace);

	for (intIndex = intStartFrom; intIndex < lngStringLength; intIndex++)
	{
		pstrLeftTrim[intIndex2] = m_pstrSuperString[intIndex];
		intIndex2 += 1;

		if (m_pstrSuperString[intIndex] != chrSpace)
		{
			intLastNonSpaceCharacter = intIndex - intStartFrom;
		}
	}

	char* pstrTrim = new char[intLastNonSpaceCharacter + 1];
	intIndex2 = 0;
	for (int intIndex = 0; intIndex < intLastNonSpaceCharacter + 1; intIndex++)
	{
		pstrTrim[intIndex2] = pstrLeftTrim[intIndex];
		intIndex2 += 1;
	}
	pstrTrim[intLastNonSpaceCharacter + 1] = '\0';

	return pstrTrim;
}

const char* CSuperString::Reverse()
{
	const long lngStringLength = Length();
	char* pstrRightTrim = new char[lngStringLength + 1];
	int intIndex2 = 0;
	int intIndex = 0;
	for (intIndex = lngStringLength - 1; intIndex > -1; --intIndex)
	{
			pstrRightTrim[intIndex2] = m_pstrSuperString[intIndex];
			intIndex2 += 1;
	}
	pstrRightTrim[lngStringLength] = '\0';

	return pstrRightTrim;
}

const char* CSuperString::Left(long lngCharactersToCopy)
{
	const long lngStringLength = Length();
	char* pstrLeftCopy = new char[lngCharactersToCopy + 1];
	int intIndex = 0;
	for (intIndex = 0; intIndex < lngCharactersToCopy; intIndex++)
	{
		pstrLeftCopy[intIndex] = m_pstrSuperString[intIndex];
	}
	pstrLeftCopy[lngCharactersToCopy] = '\0';

	return pstrLeftCopy;
}

const char* CSuperString::Right(long lngCharactersToCopy)
{
	const long lngStringLength = Length();
	char* pstrRightCopy = new char[lngCharactersToCopy + 1];
	int intIndex = 0;
	int intIndex2 = 0;
	int intNumberofCharactersOver = lngStringLength - lngCharactersToCopy;
	for (intIndex = intNumberofCharactersOver; intIndex < lngStringLength; intIndex++)
	{
		pstrRightCopy[intIndex2] = m_pstrSuperString[intIndex];
		intIndex2 += 1;
	}
	pstrRightCopy[lngCharactersToCopy] = '\0';

	return pstrRightCopy;
}

const char* CSuperString::Substring(long lngStart, long lngSubStringLength)
{
	const long lngStringLength = Length();
	char* pstrSubStringCopy = new char[lngSubStringLength + 1];
	int intIndex = 0;
	int intIndex2 = 0;
	for (intIndex = lngStart; intIndex < lngStringLength; intIndex++)
	{
		pstrSubStringCopy[intIndex2] = m_pstrSuperString[intIndex];
		intIndex2 += 1;
	}
	pstrSubStringCopy[lngSubStringLength] = '\0';

	return pstrSubStringCopy;
}

const char* CSuperString::Replace(char chrLetterToFind, char chrReplace)
{
	const long lngStringLength = Length();
	char* pstrReplacedCopy = new char[lngStringLength + 1];

	for ( int intIndex = 0; intIndex < lngStringLength + 1; intIndex += 1)
	{
		if (m_pstrSuperString[intIndex] == chrLetterToFind)
		{
			pstrReplacedCopy[intIndex] = chrReplace;
		}
		else
		{
			pstrReplacedCopy[intIndex] = m_pstrSuperString[intIndex];
		}
	}

	return pstrReplacedCopy;
}

const char* CSuperString::Replace(const char* pstrFind, const char* pstrReplace)
{
	const long lngStringLength = Length();
	long lngReplaceLength = strlen(pstrReplace);
	long lngFindLength = strlen(pstrFind);
	long lngReplacedLength = (lngStringLength - lngFindLength) + lngReplaceLength;
	char* pstrReplacedCopy = new char[lngReplacedLength + 1];
	long lngIndex2 = 0;
	long lngIndex3 = 0;
	long lngStartIndex = 0;
	int intIndex = 0;

	for (intIndex = 0; intIndex < lngStringLength + 1; intIndex += 1)
	{
		if (m_pstrSuperString[intIndex] == pstrFind[lngIndex2])
		{
			lngIndex2 += 1;
			if (lngIndex2 == lngFindLength)
			{
				lngStartIndex = intIndex - lngFindLength;
			}
			
		}
		else
		{
			lngIndex2 = 0;
		}
	}

	for (intIndex = 0; intIndex < lngReplacedLength + 1; intIndex += 1)
	{
		if (intIndex == lngStartIndex + 1)
		{
			for (lngIndex2 = 0; lngIndex2 < lngReplaceLength; lngIndex2 += 1)
			{
				pstrReplacedCopy[lngIndex3] = pstrReplace[lngIndex2];
				lngIndex3 += 1;
			}
			intIndex += lngFindLength;
		}
		pstrReplacedCopy[lngIndex3] = m_pstrSuperString[intIndex];
		lngIndex3 += 1;
	}

	pstrReplacedCopy[lngReplacedLength + 1] = '\0';
	return pstrReplacedCopy;
}

const char* CSuperString::Insert(const char chrLetterToInsert, long lngIndex)
{
	const long lngStringLength = Length();
	char* pstrReplacedCopy = new char[lngStringLength + 2];
	int intIndex = 0;
	int intIndex2 = 0;

	for (intIndex = 0; intIndex < lngStringLength + 2; intIndex += 1)
	{
		if (intIndex == lngIndex)
		{
			pstrReplacedCopy[intIndex2] = chrLetterToInsert; 
			intIndex2 += 1;
		}
			pstrReplacedCopy[intIndex2] = m_pstrSuperString[intIndex];
			intIndex2 += 1;
	}

	return pstrReplacedCopy;
}

const char* CSuperString::Insert(const char* pstrSubString, long lngIndex)
{
	const long lngStringLength = Length();
	long lngSubStringLength = strlen(pstrSubString);
	char* pstrReplacedCopy = new char[lngStringLength + lngSubStringLength + 1];
	int intIndex = 0;
	int intIndex2 = 0;

	for (intIndex = 0; intIndex < lngStringLength + 1; intIndex += 1)
	{
		if (intIndex == lngIndex)
		{
			for (int intIndex3 = 0; intIndex3 < lngSubStringLength; intIndex3 += 1)
			{
				pstrReplacedCopy[intIndex2] = pstrSubString[intIndex3];
				intIndex2 += 1;
			}
		}
			pstrReplacedCopy[intIndex2] = m_pstrSuperString[intIndex];
			intIndex2 += 1;
	}

	return pstrReplacedCopy;
}

char& CSuperString::operator [ ] (long lngIndex)
{

	char chrAtIndex = m_pstrSuperString[lngIndex];

	return chrAtIndex;
}

const char& CSuperString::operator [ ] (long lngIndex) const
{
	const char chrAtIndex = m_pstrSuperString[lngIndex];

	return chrAtIndex;
}

const char* CSuperString::ToString()
{
	return m_pstrSuperString;
}

const char* CSuperString::ToString() const
{
	return m_pstrSuperString;
}

bool CSuperString::ToBoolean()
{
	const char* strTrue = "True";
	const char* strFalse = "False";


		if (strcmp(m_pstrSuperString, strTrue) == 0)
		{
			return true;
		}
		else if (strcmp(m_pstrSuperString, strFalse) == 0)
		{
			return false;
		}
		else
		{
			cout << "Not The Right Data Type" << endl;
		}

}

short CSuperString::ToShort()
{
	const char* strZero = "0";

	short shtShortConverted = atoi(m_pstrSuperString);

	if (shtShortConverted == 0)
	{
		if (strcmp(m_pstrSuperString, strZero) != 0)
		{
			cout << "Not The Right Data Type" << endl;
		}
		else
		{
			return shtShortConverted;
		}
	}
	else
	{
		return shtShortConverted;
	}
}

int CSuperString::ToInteger()
{
	const char* strZero = "0";

	int intIntegerConverted = atoi(m_pstrSuperString);


	if (intIntegerConverted == 0)
	{
		if (strcmp(m_pstrSuperString, strZero) != 0)
		{
			cout << "Not The Right Data Type" << endl;
		}
		else
		{
			return intIntegerConverted;
		}
	}
	else
	{
		return intIntegerConverted;
	}
}

long CSuperString::ToLong()
{
	const char* strZero = "0";

	long lngLongConverted = atol(m_pstrSuperString);


	if (lngLongConverted == 0)
	{
		if (strcmp(m_pstrSuperString, strZero) != 0)
		{
			cout << "Not The Right Data Type" << endl;
		}
		else
		{
			return lngLongConverted;
		}
	}
	else
	{
		return lngLongConverted;
	}
}

float CSuperString::ToFloat()
{
	const char* strZero = "0";

	float sngFloatConverted = stof(m_pstrSuperString);


	if (sngFloatConverted == 0)
	{
		if (strcmp(m_pstrSuperString, strZero) != 0)
		{
			cout << "Not The Right Data Type" << endl;
		}
		else
		{
			return sngFloatConverted;
		}
	}
	else
	{
		return sngFloatConverted;
	}
}

double CSuperString::ToDouble()
{
	const char* strZero = "0";

	double dblDoubleConverted = stod(m_pstrSuperString);


	if (dblDoubleConverted == 0)
	{
		if (strcmp(m_pstrSuperString, strZero) != 0)
		{
			cout << "Not The Right Data Type" << endl;
		}
		else
		{
			return dblDoubleConverted;
		}
	}
	else
	{
		return dblDoubleConverted;
	}
}

void CSuperString::Print(const char* pstrCaption) const
{
	cout << endl;
	cout << pstrCaption << endl;
	cout << "--------------------------------" << endl;

	if (Length() > 0)
	{
		cout << m_pstrSuperString << endl;
	}
	else
	{
		printf("-Empty string\n");
	}

	cout << endl;
}

