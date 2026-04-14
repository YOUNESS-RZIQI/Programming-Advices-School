#include <iostream>
#include "clsLoginScreen.h"
#include "clsLoginRegisterScreen.h"
clsUser CurrentUser = clsUser::Find("", "");


int main()
{

    while (true)
    {
        if(!clsLoginScreen::ShowLoginScreen())
        {
            break;
        }
    }

    return 0;
}