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


#include <iostream>
#include <stack>
using namespace std;


int main(void)
{

	stack <int> stkNumbers0;

	stkNumbers0.push(50);
	stkNumbers0.push(40);
	stkNumbers0.push(30);
	stkNumbers0.push(20);
	stkNumbers0.push(10);

	stack <int> stkNumbers1;

	stkNumbers1.push(100);
	stkNumbers1.push(90);
	stkNumbers1.push(80);
	stkNumbers1.push(70);
	stkNumbers1.push(60);


	cout << "stkNumber0:";
	while (!stkNumbers0.empty())
	{
		cout << " " << stkNumbers0.top();

		stkNumbers0.pop();
	}

	cout << "\nstkNumber1:";
	while (!stkNumbers1.empty())
	{
		cout << " " << stkNumbers1.top();

		stkNumbers1.pop();
	}

	system("pause>0");

	return 0;

}