#include <iostream>
using namespace std;

class node
{
public:

	int Value;
	node* next;

};

void InsertAtteBeginig(node*& head, int Value)
{
	node* n;

	n = new node();

	n->Value= Value;

	n->next = head;

	head = n;
}

int main(void)
{
	node* head;

	head = NULL;
	InsertAtteBeginig(head, 1);
	InsertAtteBeginig(head, 2);
	InsertAtteBeginig(head, 3);

	while (head)
	{
		cout << head->Value << endl;
		head = head->next;
	}


	return 0;
}