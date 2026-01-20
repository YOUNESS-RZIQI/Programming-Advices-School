#include <iostream>
#include "clsBankClient.h"

int main()
{

    clsBankClient Client = clsBankClient::Find("A103");
   
    Client.Print();

    system("pause>0");
    return 0;
}