#ifndef STD_H
#define STD_H
#include <iostream>
using namespace std;

class student
{
public:
	float GetSum();
	float GetDif();
};

float student::GetSum()
{
	float a = 0, b = 0;

	cout << "\nEnter digits A,B:" << endl;
	cin >> a >> b;

	return a + b;
}

float student::GetDif()
{
	float c, d;
	cout << "\nEnter digits C,D; " << endl;
	cin >> c >> d;

	return c - d;
}


#endif 