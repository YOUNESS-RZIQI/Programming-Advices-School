Linked list in stack : 

#include <iostream>
using namespace std;

class node
{
public:

	int Value;
	node* next;

};

int main(void)
{
	node* head;

	node n1;
	node n2;
	node n3;

	n1.Value = 1;
	n2.Value = 2;
	n3.Value = 3;
	
	n1.next = &n2;
	n2.next = &n3;
	n3.next = NULL;

	head = &n1;

	while (head)
	{
		cout << head->Value << endl;
		head = head->next;
	}

	return 0;
}


Linked list in heap (using new it is like malloc in c lan) : 

#include <iostream>
using namespace std;

class node
{
public:

	int Value;
	node* next;

};

int main(void)
{
	node* head;

	node* n1 = new node();
	node* n2 = new node();
	node* n3 = new node();

	n1->Value = 1;
	n1->next = n2;

	n2->Value = 2;
	n2->next = n3;

	n3->Value = 3;
	n3->next = NULL;

	head = n1;

	int i = 1;
	while (head)
	{
		cout << "Node " << head->Value << endl;
		head = head->next;
		i++;
	}

	return 0;
}
