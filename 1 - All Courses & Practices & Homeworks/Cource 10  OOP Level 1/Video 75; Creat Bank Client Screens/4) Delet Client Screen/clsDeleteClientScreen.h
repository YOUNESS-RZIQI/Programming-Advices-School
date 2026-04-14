#pragma once
#include "clsScreen.h"
#include "clsBankClient.h"


class clsDeleteClientScreen : protected clsScreen
{

private:

    static void _PrintClient(clsBankClient Client)
    {
        cout << "\nClient Card:";
        cout << "\n___________________";
        cout << "\nFirstName   : " << Client.FirstName;
        cout << "\nLastName    : " << Client.LastName;
        cout << "\nFull Name   : " << Client.FullName();
        cout << "\nEmail       : " << Client.Email;
        cout << "\nPhone       : " << Client.Phone;
        cout << "\nAcc. Number : " << Client.AccountNumber();
        cout << "\nPassword    : " << Client.PinCode;
        cout << "\nBalance     : " << Client.AccountBalance;
        cout << "\n___________________\n";

    }

public:

	static void ShowDeleteClientScreen()
	{

        _DrawScreenHeader("\t  Delete Client Screen");

        string AccountNumber = "";

        cout << "\nPlease Enter Account Number: ";
        AccountNumber = clsInputValidate::ReadString();
        while (!clsBankClient::IsClientExist(AccountNumber))
        {
            cout << "\nAccount Number Is not Exist, Choose another one: ";
            AccountNumber = clsInputValidate::ReadString();
        }

        clsBankClient Client = clsBankClient::Find(AccountNumber);

        _PrintClient(Client);

        char answer = 'n';
        cout << "\nAre you sure you wnat to delete the Client wiht Account Number '" << AccountNumber << "' ? (y/n) : ";
        cin >> answer;

        if (Client.Delete() && answer)
        {
            _PrintClient(Client);
            cout << "\n Client whit Accout Number '" << AccountNumber << "' Deleted Successfoly.\n";
        }
        else
            cout << "\n Client whit Accout Number '" << AccountNumber << "' has not Deleted.\n";

	}

};