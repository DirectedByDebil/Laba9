#ifndef STD_H
#define STD_H
#include <iostream>
using namespace std;

class student
{
public:
	float GetSum();
};

float student::GetSum()
{
	float a = 0, b = 0;

	cout << "\nEnter digits A,B:" << endl;
	cin >> a >> b;

	return a + b;
}


#endif 