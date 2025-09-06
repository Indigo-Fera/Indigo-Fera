// --------------------------------------------------------------------------------
// Class: CSuperString 
// --------------------------------------------------------------------------------



#include <stdlib.h>
#include <iostream>
using namespace std;


class CSuperString
{

public:

protected:

private:
	const char* m_pstrSuperString;

public:
	// Constructors
	CSuperString();
	CSuperString(const char* pstrStringToCopy);
	CSuperString(const bool blnBooleanToCopy);
	CSuperString(const char chrLetterToCopy);
	CSuperString(const short shtShortToCopy);
	CSuperString(const int intIntegerToCopy);
	CSuperString(const long lngLongToCopy);
	CSuperString(const float sngFloatToCopy);
	CSuperString(const double dblDoubleToCopy);
	CSuperString(const CSuperString& ssStringToCopy);

	// Destructor
	virtual ~CSuperString();

	long Length() const;

	// Assignment Operators
	void operator = (const char* pstrStringToCopy);
	void operator = (const char chrLetterToCopy);
	void operator = (const CSuperString& ssStringToCopy);

	// Concatenate Operators
	void operator += (const char* pstrStringToAppend);
	void operator += (const char chrCharacterToAppend);
	void operator += (const CSuperString& ssStringToAppend);

	friend CSuperString operator + (const CSuperString& ssLeft, const CSuperString& ssRight);
	friend CSuperString operator + (const char* pstrLeftSide, const CSuperString& ssRightString);
	friend CSuperString operator + (const CSuperString& ssLeftString, const char* pstrRightSide);

	// Comparison Operators
	 void operator == (const char* pstrStringToCompare);
	 void operator == (const char chrCharacterToCompare);
	 void operator == (const CSuperString& ssStringToCompare);
	 void operator > (const char* pstrStringToCompare);
	 void operator > (const char chrCharacterToCompare);
	 void operator > (const CSuperString& ssStringToCompare);
	 void operator < (const char* pstrStringToCompare);
	 void operator < (const char chrCharacterToCompare);
	 void operator < (const CSuperString& ssStringToCompare);
	 void operator != (const char* pstrStringToCompare);
	 void operator != (const char chrCharacterToCompare);
	 void operator != (const CSuperString& ssStringToCompare);
	 void operator >= (const char* pstrStringToCompare);
	 void operator >= (const char chrCharacterToCompare);
	 void operator >= (const CSuperString& ssStringToCompare);
	 void operator <= (const char* pstrStringToCompare);
	 void operator <= (const char chrCharacterToCompare);
	 void operator <= (const CSuperString& ssStringToCompare);

	long FindFirstIndexOf(const char chrLetterToFind);
	long FindFirstIndexOf(const char chrLetterToFind, long lngStartIndex);
	long FindLastIndexOf(const char chrLetterToFind);

	long FindFirstIndexOf(const char* pstrSubStringToFind);
	long FindFirstIndexOf(const char* pstrSubStringToFind, long lngStartIndex);
	long FindLastIndexOf(const char* pstrSubStringToFind);

	const char* ToUpperCase();
	const char* ToLowerCase();
	const char* TrimLeft();
	const char* TrimRight();
	const char* Trim();
	const char* Reverse();

	const char* Left(long lngCharactersToCopy);
	const char* Right(long lngCharactersToCopy);
	const char* Substring(long lngStart, long lngSubStringLength);

	const char* Replace(char chrLetterToFind, char chrReplace);
	const char* Replace(const char* pstrFind, const char* pstrReplace);
	const char* Insert(const char chrLetterToInsert, long lngIndex);
	const char* Insert(const char* pstrSubString, long lngIndex);

	// Subscript operator
	char& operator [ ] (long lngIndex);
	const char& operator [ ] (long lngIndex) const;

	const char* ToString();
	const char* ToString() const;
	bool ToBoolean();
	short ToShort();
	int ToInteger();
	long ToLong();
	float ToFloat();
	double ToDouble();

	//friend ostream& operator << (ostream& osOut, const CSuperString& ssOutput);
	//friend istream& operator >> (istream& isIn, CSuperString& ssInput);

	void Print(const char* pstrCaption) const;

protected:
	void Initialize(const char* pstrSource);
	void DeepCopy(const char* pstrSource);
	void CleanUp();
	void DeleteString(const char*& pstrSource);
	char* CloneString(const char* pstrSource);

private:
};