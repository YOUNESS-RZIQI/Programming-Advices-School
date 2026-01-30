#pragma once

#include "clsString.h"
#include "clsInputValidation.h"
#include "clsPerson.h"
#include <fstream>
#include <iomanip>
#include"clsUtils.h"


class clsBankClient : public clsPerson
{
private:

	enum en_Mode {empty_mode, Update_mode, AddNew_mode};
	en_Mode _Mode;
	bool _MarkForDelete = false;

	string _AccountNumber;
	string _PinCode;
	float  _Balance;

	static clsBankClient _ConvertClientLineToObject(string line, string del="#//#")
	{

		vector <string> client_data = clsString::Split(line, del);
		return clsBankClient(en_Mode::Update_mode, client_data[0], client_data[1], client_data[2], client_data[3], client_data[4], client_data[5], stof(client_data[6]));
	}

	static clsBankClient _GetEmptyClientObject()
	{
		return clsBankClient( en_Mode::empty_mode, "", "", "", "", "", "", 0);
	}

	static clsBankClient _GetAddNewClientEmptyObject(string AccountNumber)
	{
		return clsBankClient(en_Mode::AddNew_mode, "", "", "", "", AccountNumber, "", 0);
	}

	static vector <string> _Load_Clients_info_as_lines(string FileName="Clients.txt")
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
	
	static string _ConverObjectToLine(clsBankClient Client, string sep="#//#")
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

	
	static void _AskForClientInfo(clsBankClient &new_Client)
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
	
	static void _ReadNewClientFullInfo(clsBankClient &new_Client)
	{
		cout << "\n\n    Add Client Data \n";
		cout << "________________________\n\n";
		new_Client.FirstName = clsInputValidate::ReadString("New First Name    : ");
		new_Client.LastName = clsInputValidate::ReadString("New Last Name     : ");
		new_Client.Email = clsInputValidate::ReadString("New Email         : ");
		new_Client.Phone = clsInputValidate::ReadString("New Phone         : ");
		new_Client.AccountNumber = clsInputValidate::ReadString("New AccountNumber : ");
		new_Client.PinCode = clsInputValidate::ReadString("New Pin Code      : ");
		new_Client.Balance = stof(clsInputValidate::ReadString("New Balance       : "));
	}
	
	enum enSavintResult { enSuccess, enFailEmptyObject, enFailAccountNumberExit};

	void _SaveClientDataToFile(vector <clsBankClient> v_Clients)
	{
		fstream fd("Clients.txt", ios::out);

		if (fd.is_open())
		{
			string Dataline = "";

			for (clsBankClient c : v_Clients)
			{	if (c._MarkForDelete == false)
				{
					Dataline = _ConverObjectToLine(c, "#//#");
					fd << Dataline << endl;
				}
			}

			fd.close();
		}
	}
	
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

	void _AddDataLineToFile(string DataLine)
	{
		fstream fd("Clients.txt", ios::app);

		if (fd.is_open())
		{
			fd << DataLine << endl;
			fd.close();
		}

	}

	void _AddNew()
	{
		_AddDataLineToFile(_ConverObjectToLine(*this));
	}

	bool _Delete()// self
	{
		vector <clsBankClient> v_Clients = _Load_Clients_info_as_Objects();

		for (clsBankClient& Client : v_Clients)
		{
			if (Client.AccountNumber == this->AccountNumber)
			{
				Client._MarkForDelete = true;
				break;
			}
		}
		_SaveClientDataToFile(v_Clients);

		*this = _GetEmptyClientObject();

		return true;
	}

	static void _ShowClientAllDataInOneLine(clsBankClient Client)
	{
		cout << setw(20) << left << "| " + Client.AccountNumber;
		cout << setw(20) << left << "| " + Client.FullName();
		cout << setw(20) << left << "| " + Client.Phone;
		cout << setw(20) << left << "| " + Client.Email;
		cout << setw(20) << left << "| " + Client.PinCode;
		cout << setw(20) << left << "| " + to_string(Client.Balance) << "|\n";

	}

	static void _ShowTotalBalancesDataLine(clsBankClient Client)
	{
		cout << setw(20) << left << "| " + Client.AccountNumber;
		cout << setw(40) << left << "| " + Client.FullName();
		cout << setw(20) << left << "| " + to_string(Client.Balance) << "|\n";

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

	void Print()// self
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

	enSavintResult Save()
	{
		switch (_Mode)
		{
		case en_Mode::empty_mode:
			if (isEmptyMode())
			{
				return enSavintResult::enFailEmptyObject;
			}
			break;
		case en_Mode::Update_mode:
			_Update();
			return enSavintResult::enSuccess;
			break;
		case en_Mode::AddNew_mode:
			if (isClienteExist(AccountNumber))
				return enSavintResult::enFailAccountNumberExit;
			_AddNew();
			_Mode = en_Mode::Update_mode;
			return enSavintResult::enSuccess;
			break;
		}
	}

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

		_AskForClientInfo(Client);

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
	}
	
	static clsBankClient AddNew()
	{
		string AccountNumber = "";

		cout << "\nPlease Enter Account Number: ";
		AccountNumber = clsInputValidate::ReadString("Pleas Enter Account Number :");
		while (clsBankClient::isClienteExist(AccountNumber))
		{
			AccountNumber = clsInputValidate::ReadString("\nAccount Number Is Already Used, Choose another one: ");
		}
		 
		clsBankClient NewClient = clsBankClient::_GetAddNewClientEmptyObject(AccountNumber);

		_ReadNewClientFullInfo(NewClient);

		clsBankClient::enSavintResult SavingResult;

		SavingResult = NewClient.Save();

		switch (SavingResult)
		{
		case clsBankClient::enSuccess:
			cout << "Accoutn added Successuly ;)\n";
			NewClient.Print();
			return NewClient;
			break;
		case clsBankClient::enFailEmptyObject:
			cout << "Fail Because Account Number Oject was empty\n";
			return _GetEmptyClientObject();
		case clsBankClient::enFailAccountNumberExit:
			return _GetEmptyClientObject();
		}
	}
	
	void DeletClient()
	{
		string AccountNumber = "";

		cout << "\nPlease Enter Account Number: ";
		AccountNumber = clsInputValidate::ReadString("Pleas Enter Account Number To Delete: ");
		while (!clsBankClient::isClienteExist(AccountNumber))
		{
			AccountNumber = clsInputValidate::ReadString("\nAccount Number Is Noe Exist, Choose another one: ");
		}

		clsBankClient ClientToDelete = Find(AccountNumber);

		ClientToDelete.Print();

		string Answer = clsInputValidate::ReadString("Are you sur you want to Delet this Client \"" + ClientToDelete.FullName() + "\" (y/n) ? ");

		if (Answer == "y" || Answer == "Y" || Answer == "yes" || Answer == "Yes")
		{
			if (ClientToDelete._Delete())// self
			{
				cout << "\n\nClient" + ClientToDelete.FullName() + " Deleted Successfuly\n\n";
				ClientToDelete.Print();
			}
			else
				cout << "\n\nError , Cliet Did not Delet  ! !  !\n\n";
		}

	}

	static void ShowClientsList()
	{
		vector <clsBankClient> v_Clients = _Load_Clients_info_as_Objects();

		cout << "\t\t\t\t\t\tClients List(" << v_Clients.size() << ") Client (s).\n";
		cout << "-------------------------------------------------------------------------------------------------------------------------\n";
		cout << setw(20) << left << "| Account Number";
		cout << setw(20) << left << "| Client Name";
		cout << setw(20) << left << "| Phone ";
		cout << setw(20) << left << "| Email ";
		cout << setw(20) << left << "| Pin Code ";
		cout << setw(20) << left << "| Balance " << "|\n";
		cout << "-------------------------------------------------------------------------------------------------------------------------\n";

		if (v_Clients.size() == 0)
		{
			cout << "\n\t\t\t\t\t\t   There is No Clients \n\n";
		}
		else
		{
			for (clsBankClient& Client : v_Clients)
			{
				_ShowClientAllDataInOneLine(Client);
			}
		}
		cout << "-------------------------------------------------------------------------------------------------------------------------\n";
	}

	// Added
	static double  TotalBalances()
	{
		vector <clsBankClient> v_Clients = _Load_Clients_info_as_Objects();

		double Total = 0;

		for (clsBankClient& Client : v_Clients)
			Total += Client.Balance;

		return Total;
	}
	// Added
	static void ShowTotalBalances()
	{
		vector <clsBankClient> v_Clients = _Load_Clients_info_as_Objects();


		cout << "\t\t\t\tClients List(" << v_Clients.size() << ") Client (s).\n";
		cout << "--------------------------------------------------------------------------------\n";
		cout << setw(20) << left << "| Accout Number ";
		cout << setw(40) << left << "| Client Name ";
		cout << setw(20) << left << "| Balance " << "|\n";
		cout << "--------------------------------------------------------------------------------\n";


		if (v_Clients.size() == 0)
		{
			cout << "\n\t\t\t\t  Total Balances = 0 \n\n";
		}
		else
		{
			for (clsBankClient& Client : v_Clients)
			{
				_ShowTotalBalancesDataLine(Client);
			}

			cout << "--------------------------------------------------------------------------------\n";
			long total = clsBankClient::TotalBalances();
			cout << "\n\t\t\t\tTotal Balances is : " << total << "\n";
			cout << "\n\t\t\t\t  " << clsUtils::NumberToText(total) << "\n";
		}
		
		cout << "\n--------------------------------------------------------------------------------\n";


	}


};