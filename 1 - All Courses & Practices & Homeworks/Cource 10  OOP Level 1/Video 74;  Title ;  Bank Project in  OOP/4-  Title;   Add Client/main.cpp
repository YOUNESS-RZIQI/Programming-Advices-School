#include <iostream>
#include "clsBankClient.h"

int main()
{

    clsBankClient Client = clsBankClient::Find("A103");
   
    Client.Update();

    system("pause>0");
    return 0;
}