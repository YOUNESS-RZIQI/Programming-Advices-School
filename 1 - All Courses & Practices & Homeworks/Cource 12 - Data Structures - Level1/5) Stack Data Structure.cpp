#include <iostream>
#include <stack>
using namespace std;


int main(void)
{

	stack <int> stkNumbers;

	stkNumbers.push(50);
	stkNumbers.push(40);
	stkNumbers.push(30);
	stkNumbers.push(20);
	stkNumbers.push(10);


	while (!stkNumbers.empty())
	{
		cout << stkNumbers.top() << endl;

		stkNumbers.pop();
	}

	return 0;

}