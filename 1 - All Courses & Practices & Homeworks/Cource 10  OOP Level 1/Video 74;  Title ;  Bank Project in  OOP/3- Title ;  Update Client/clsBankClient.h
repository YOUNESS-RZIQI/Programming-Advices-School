#pragma once

#include "clsString.h"
#include "clsInputValidation.h"
#include "clsPerson.h"
#include <fstream>


class clsBankClient : public clsPerson
{
private:


	enum en_Mode { empty_mode, Update_mode };
	en_Mode _Mode;

	string _AccountNumber;
	string _PinCode;
	float  _Balance;

	static clsBankClient _ConvertClientLineToObject(string line, string del = "#//#")
	{

		vector <string> client_data = clsString::Split(line, del);
		return clsBankClient(en_Mode::Update_mode, client_data[0], client_data[1], client_data[2], client_data[3], client_data[4], client_data[5], stof(client_data[6]));
	}

	static clsBankClient _GetEmptyClientObject()
	{
		return clsBankClient(en_Mode::empty_mode, "", "", "", "", "", "", 0);
	}

	static vector <string> _Load_Clients_info_as_lines(string FileName = "Clients.txt")
	{
		fstream fd;
		fd.open(FileName, ios::in);// read mode (ios::in)

		vector <string> Clients_Info;
		if (fd.is_open())
		{
			string line;
			while (getline(fd, line))
			{
				Clients_Info.push_back(line);
			}
		}
		return Clients_Info;
	}

	// Added
	static vector <clsBankClient> _Load_Clients_info_as_Objects(string FileName = "Clients.txt")
	{
		fstream fd;
		fd.open(FileName, ios::in);

		vector <clsBankClient> v_Clients;
		if (fd.is_open())
		{
			string line;
			clsBankClient Client = _GetEmptyClientObject();
			while (getline(fd, line))
			{
				Client = _ConvertClientLineToObject(line);
				v_Clients.push_back(Client);
			}
		}
		return v_Clients;
	}

	// Added
	static string _ConverObjectToLine(clsBankClient Client, string sep = "#//#")
	{
		string Line;

		Line = Line + Client.FirstName + sep;
		Line = Line + Client.LastName + sep;
		Line = Line + Client.Email + sep;
		Line = Line + Client.Phone + sep;
		Line = Line + Client.AccountNumber + sep;
		Line = Line + Client.PinCode + sep;
		Line = Line + to_string(Client.Balance);

		return Line;
	}

	// Added
	static void _AskForNewClientInfo(clsBankClient& new_Client)
	{
		cout << "\n\n    UpDate Client Data \n";
		cout << "________________________\n\n";
		new_Client.FirstName = clsInputValidate::ReadString("New First Name    : ");
		new_Client.LastName = clsInputValidate::ReadString("New Last Name     : ");
		new_Client.Email = clsInputValidate::ReadString("New Email         : ");
		new_Client.Phone = clsInputValidate::ReadString("New Phone         : ");
		new_Client.PinCode = clsInputValidate::ReadString("New Pin Code      : ");
		new_Client.Balance = stof(clsInputValidate::ReadString("New Balance       : "));

	}

	// Added
	enum enSavintResult { enSuccess, enFailEmptyObject };

	void _SaveClientDataToFile(vector <clsBankClient> v_Clients)
	{
		fstream fd("Clients.txt", ios::out);

		if (fd.is_open())
		{
			string Dataline = "";

			for (clsBankClient& c : v_Clients)
			{
				Dataline = _ConverObjectToLine(c, "#//#");
				fd << Dataline << endl;
			}

			fd.close();
		}
	}
	// Added
	void _Update()
	{
		vector <clsBankClient> v_Clients;

		v_Clients = _Load_Clients_info_as_Objects();
		for (clsBankClient& c : v_Clients)
		{
			if (c.AccountNumber == AccountNumber)
			{
				c = *this;
				break;
			}
		}

		_SaveClientDataToFile(v_Clients);

	}



public:

	clsBankClient(en_Mode mode, string FirstName, string LastName, string Email, string PhoneNumber, string AccountNumber, string PinCode, float Balance)
		: clsPerson(FirstName, LastName, Email, PhoneNumber)
	{
		_Mode = mode;
		this->_AccountNumber = AccountNumber;
		this->_PinCode = PinCode;
		this->_Balance = Balance;
	}

	bool isEmptyMode()
	{
		return (_Mode == en_Mode::empty_mode);
	}

	void SetAccountNumber(string AccountNumber)
	{
		_AccountNumber = AccountNumber;
	}

	string GetAccountNumber()
	{
		return _AccountNumber;
	}

	__declspec(property(get = GetAccountNumber, put = SetAccountNumber)) string AccountNumber;

	void SetPinCode(string PinCode)
	{
		_PinCode = PinCode;
	}

	string GetPinCode()
	{
		return _PinCode;
	}

	__declspec(property(get = GetPinCode, put = SetPinCode)) string PinCode;

	void SetBalance(float Balance)
	{
		_Balance = Balance;
	}

	float GetBalance()
	{
		return _Balance;
	}

	__declspec(property(get = GetBalance, put = SetBalance)) float Balance;

	string FullName()
	{
		return FirstName + " " + LastName;
	}

	void Print()
	{
		cout << "\nClient Card:";
		cout << "\n___________________";
		cout << "\nFirstName   : " << FirstName;
		cout << "\nLastName    : " << LastName;
		cout << "\nFull Name   : " << FullName();
		cout << "\nEmail       : " << Email;
		cout << "\nPhone       : " << Phone;
		cout << "\nAcc. Number : " << _AccountNumber;
		cout << "\nPassword    : " << _PinCode;
		cout << "\nBalance     : " << _Balance;
		cout << "\n___________________\n";

	}

	static clsBankClient Find(string AccountNumber)
	{
		fstream fd;
		fd.open("Clients.txt", ios::in);// read mode (ios::in)

		if (fd.is_open())
		{
			string line;

			while (getline(fd, line))
			{
				clsBankClient Client = _ConvertClientLineToObject(line, "#//#");
				if (Client._AccountNumber == AccountNumber)
				{
					fd.close();
					return Client;
				}
			}


			fd.close();
		}
		return _GetEmptyClientObject();
	}

	static clsBankClient Find(string AccountNumber, string PinCode)
	{
		fstream fd;
		fd.open("Clients.txt", ios::in);// read mode (ios::in)

		if (fd.is_open())
		{
			string line;

			while (getline(fd, line))
			{
				clsBankClient Client = _ConvertClientLineToObject(line, "#//#");
				if (Client._AccountNumber == AccountNumber && Client.PinCode == PinCode)
				{
					fd.close();
					return Client;
				}
			}


			fd.close();
		}
		return _GetEmptyClientObject();
	}

	static bool isClienteExist(string AccountNumber)
	{
		clsBankClient Client = clsBankClient::Find(AccountNumber);
		return (!Client.isEmptyMode());
	}

	// Added
	enSavintResult Save()
	{
		switch (_Mode)
		{
		case clsBankClient::empty_mode:
			return enSavintResult::enFailEmptyObject;
			break;
		case clsBankClient::Update_mode:
			_Update();
			return enSavintResult::enSuccess;
			break;
		}
	}

	// Added
	static clsBankClient Update()
	{
		string AccountNumber;

		AccountNumber = clsInputValidate::ReadString("Please enter Account Number :");

		while (!clsBankClient::isClienteExist(AccountNumber))
		{
			AccountNumber = clsInputValidate::ReadString("\t\t!!! Error!!!\nPlease enter a Valid Account Number :");
		}

		clsBankClient Client = Find(AccountNumber);


		Client.Print();

		_AskForNewClientInfo(Client);

		clsBankClient::enSavintResult  SaveResult;

		SaveResult = Client.Save();

		switch (SaveResult)
		{
		case clsBankClient::enSuccess:
			cout << "\nAccount Update Successfully ;-)\n";
			Client.Print();
			break;
		case clsBankClient::enFailEmptyObject:
			cout << "Account Update Faile Object Empty :_(\n";
			break;
		default:
			break;
		}


		return Client;
	};

};