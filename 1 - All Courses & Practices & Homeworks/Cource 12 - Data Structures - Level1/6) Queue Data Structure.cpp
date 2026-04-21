#include <iostream>
#include <queue>

using namespace std;


int main(void)
{
	queue <int> MyQueue0;

	MyQueue0.push(10);
	MyQueue0.push(20);
	MyQueue0.push(30);
	MyQueue0.push(40);

	cout << "Size of Queue : " << MyQueue0.size();
	cout << "\nFront (head) of Queue : " << MyQueue0.front();
	cout << "\nBack (tail) of Queue : " << MyQueue0.back();

	cout << "\nMyQueue0 Elements :";
	while (!MyQueue0.empty())
	{
		cout << " " << MyQueue0.front();
		MyQueue0.pop();
	}


	queue <int> MyQueue01;

	MyQueue01.push(50);
	MyQueue01.push(60);
	MyQueue01.push(70);
	MyQueue01.push(80);

	MyQueue0.push(10);
	MyQueue0.push(20);
	MyQueue0.push(30);
	MyQueue0.push(40);

	MyQueue0.swap(MyQueue01);

	cout << "\nAfter Swap Queues Elements :\n";

	cout << "\nMyQueue0 Elements :";
	while (!MyQueue0.empty())
	{
		cout << " " << MyQueue0.front();
		MyQueue0.pop();
	}

	cout << "\nMyQueue01 Elements :";
	while (!MyQueue01.empty())
	{
		cout << " " << MyQueue01.front();
		MyQueue01.pop();
	}

	system("pause>0");
	return 0;
}