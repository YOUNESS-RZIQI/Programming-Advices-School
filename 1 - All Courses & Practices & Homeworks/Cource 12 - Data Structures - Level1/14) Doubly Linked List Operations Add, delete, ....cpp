//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

#include <iostream>
using namespace std;

// Create a node
class Node
{
public:
    int value;
    Node* next;
    Node* prev;
};

void InsertAtBeginning(Node*& head, int value)
{
    Node* new_node = new Node();

    new_node->value = value;
    new_node->next = head;
    new_node->prev = NULL;

    if (!head)
    {
        head = new_node;
        return;
    }

    head->prev = new_node;

    head = new_node;

}


Node* Find(Node* head, int Value)
{

    while (head != NULL) {

        if (head->value == Value)
            return head;

        head = head->next;
    }

    return NULL;
}


void InsertAfter(Node* Prev_node, int Value) {

    if (Prev_node == NULL) {
        cout << "the given Previous node cannot be NULL";
        return;
    }

    Node* new_node = new Node();
    new_node->value = Value;
    new_node->next = Prev_node->next;
    if (Prev_node->next)
        Prev_node->next->prev = new_node;
    new_node->prev = Prev_node;
    Prev_node->next = new_node;
}


void InsertAtEnd(Node*& head, int Value) {

    Node* new_node = new Node();

    new_node->value = Value;
    new_node->next = NULL;
    new_node->prev = NULL;

    if (head == NULL) {
        head = new_node;
        return;
    }

    Node* LastNode = head;
    while (LastNode->next != NULL)
    {
        LastNode = LastNode->next;
    }

    LastNode->next = new_node;
    new_node->prev = LastNode;

}

void DeleteNode(Node*& head, int Value)
{
    Node* node_to_delete = head;
    
    if (!head)
        return;
     //1) First not & have next.
    if (head->next && head->value == Value)
    {
        head->next->prev = NULL;
        head = head->next;
        delete(node_to_delete);

        return;
    }
    // 2) First one and the only one. (so it is the first and last at the same time)
    else if (!head->next && head->value == Value)
    {
        delete(head);
        head = NULL;

        return;
    }

    while (node_to_delete->next && node_to_delete->value != Value)
    {
        node_to_delete = node_to_delete->next;
    }

    // 2) Last one , no next , next is NULL
    if (node_to_delete->next == NULL && node_to_delete->value == Value)
    {
        node_to_delete->prev->next = NULL;
        delete node_to_delete;
        return;
    }

    if (node_to_delete->next == NULL) return;
    // 3) Medel one
    node_to_delete->prev->next = node_to_delete->next;
    node_to_delete->next->prev = node_to_delete->prev;

    delete node_to_delete;

}

void DeleteNode(Node*& head, Node*& NodeToDelete) {


    if (head == NULL || NodeToDelete == NULL) {
        return;
    }
    if (head == NodeToDelete) {
        head = NodeToDelete->next;
    }
    if (NodeToDelete->next != NULL) {
        NodeToDelete->next->prev = NodeToDelete->prev;
    }
    if (NodeToDelete->prev != NULL) {
        NodeToDelete->prev->next = NodeToDelete->next;
    }
    delete NodeToDelete;
}

void DeleteFirstNode(Node*& head) {

    Node* Cur = head;

    if (!head)
        return;

    if (head->next)
        head->next->prev = NULL;
    
    head = head->next;

    delete Cur;
}


void DeleteLastNode(Node*& head) {

    Node* Cur = head;

    if (!head)
        return;
    while (Cur->next)
        Cur = Cur->next;

    if (Cur->prev)
        Cur->prev->next = NULL;
    else
        head = head->next;
    
    delete Cur;

}


void PrintNodeDetails(Node* head)
{

    if (head->prev != NULL)
        cout << head->prev->value;
    else
        cout << "NULL";

    cout << " <--> " << head->value << " <--> ";

    if (head->next != NULL)
        cout << head->next->value << "\n";
    else
        cout << "NULL";

}

void PrintListDetails(Node* head)

{
    cout << "\n\n";
    while (head != NULL) {
        PrintNodeDetails(head);
        head = head->next;
    }
}

void PrintList(Node* head)

{
    cout << "NULL <--> ";
    while (head != NULL) {
        cout << head->value << " <--> ";
        head = head->next;
    }
    cout << "NULL";

}

void DeleteNode2(Node*& head, int Value)
{
    Node* Cur = head;

    while (Cur && Cur->value != Value)
        Cur = Cur->next;
    
    if (!Cur)
        return;
    
    if (Cur->prev)
        Cur->prev->next = Cur->next;
    else
        head = head->next;
    if (Cur->next)
        Cur->next->prev = Cur->prev;
    delete Cur;
}

int main()
{
    Node* head = NULL;

    InsertAtBeginning(head, 5);
    InsertAtBeginning(head, 4);
    InsertAtBeginning(head, 3);
    InsertAtBeginning(head, 2);
    InsertAtBeginning(head, 1);

    cout << "\nLinked List Contenet:\n";
    PrintList(head);


    DeleteNode(head, 3);
    DeleteFirstNode(head);
    DeleteLastNode(head);

    cout << "\n\n\nLinked List Contenet after delete:\n";
    PrintList(head);

    system("pause>0");

    return 0;
}





