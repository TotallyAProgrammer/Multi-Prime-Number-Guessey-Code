#include <stdio.h>
#include <conio.h>
#include <time.h>
#include <Winsock2.h>


int main()
{
	int foo;
	int var1;
	int maximum;
	int numbertotest;

	unsigned long int t;
    FILETIME Begin;
    FILETIME End;
	ULARGE_INTEGER CalcBegin;
	ULARGE_INTEGER CalcEnd;


	maximum = 100000;

	GetSystemTimeAsFileTime(&Begin);

	for (numbertotest = 2; numbertotest <= maximum; numbertotest++)
	{
		//Test Code Below
		for (foo = numbertotest / 2; foo >= 2; foo--)
		{
			var1 = numbertotest % foo;
			if (var1 == 0)
			{
				break;
			}
//			if(foo == 2)
//			{
//			}
		}
	}
	GetSystemTimeAsFileTime(&End);

	CalcBegin.HighPart = Begin.dwHighDateTime;
	CalcBegin.LowPart = Begin.dwLowDateTime;
	CalcEnd.HighPart = End.dwHighDateTime;
	CalcEnd.LowPart = End.dwLowDateTime;

	t = CalcEnd.QuadPart - CalcBegin.QuadPart;

	printf("usecs: %u\n", t);

	getch();
	return 0;
}