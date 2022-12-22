#ifndef STD_H
#define STD_H
#include <iostream>
using namespace std;

class student
{
public:
	float GetSum();
	float GetDif();
	float GetMultiply();
	float GetDivision();
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
	cout << "\nEnter digits C,D: " << endl;
	cin >> c >> d;

	return c - d;
}

float student::GetMultiply()
{
	float e, f;
	cout << "\nEnter digits E,F: " << endl;
	cin >> e >> f;

	return e*f;
}

float student::GetDivision()
{
	float g, h;
	cout << "\nEnter digits G, H: " << endl;
	cin >> g >> h;

	return g/h;
}

#endif 