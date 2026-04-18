#pragma once

#include "clsScreen.h"
#include "clsCurrency.h"
#include "clsInputValidate.h"
#include "clsString.h"
#include <string>

class clsCurrencyCalculatorScreen : protected clsScreen
{

	static void _PrintCurrency(clsCurrency Currency)
	{
		cout << "_____________________________\n";
		cout << "\nCountry    : " << Currency.Country();
		cout << "\nCode       : " << Currency.CurrencyCode();
		cout << "\nName       : " << Currency.CurrencyName();
		cout << "\nRate(1$) = : " << Currency.Rate();

		cout << "\n_____________________________\n";

	}

	static float _ExchangeFromUSDToCurrency(string CurCodeFrom, string CurCodeTo, float Amounth)
	{
			clsCurrency Currency = clsCurrency::FindByCode(CurCodeTo);

			float exchange = clsCurrency::FromUSDToCurrency(Amounth, Currency);

			cout << "\nConvert From :\n";

			_PrintCurrency(clsCurrency::FindByCode("usd"));

			cout << "\n" + to_string(Amounth) + " " + CurCodeFrom + " = " + to_string(exchange) + " " + CurCodeTo + "\n";

			return exchange;
	}

	static float _ExchangeFromCurrencyToUSD(string CurCodeFrom, string CurCodeTo, float Amounth)
	{
		
		clsCurrency Currency = clsCurrency::FindByCode(CurCodeFrom);

		float exchange = clsCurrency::FromCurrencyToUSD(Amounth, Currency);

		cout << "\nConvert From :\n";

		_PrintCurrency(Currency);

		cout << "\n" + to_string(Amounth) + " " + CurCodeFrom + " = " + to_string(exchange) + " " + CurCodeTo + "\n";

		return exchange;
	}

	static string _ReadValidCurrencyCode(string Message, string ErrorMessage)
	{
		string CurrencyCode = "";

		cout << Message;
		CurrencyCode = clsInputValidate::ReadString();

		clsCurrency Currency = clsCurrency::FindByCode(CurrencyCode);
		if (!Currency.IsEmpty())
			return CurrencyCode;

		while (1)
		{
			cout << ErrorMessage;
			CurrencyCode = clsInputValidate::ReadString();

			clsCurrency Currency1 = clsCurrency::FindByCode(CurrencyCode);
			if (!Currency1.IsEmpty())
				return CurrencyCode;
		}

	}
		
	static void _CalculateExchange(string CurCodeFrom, string CurCodeTo, float Amounth)
	{
		if (clsString::UpperAllString(CurCodeFrom) == clsString::UpperAllString("usd"))
		{
			_ExchangeFromUSDToCurrency(CurCodeFrom, CurCodeTo, Amounth);
		}
		else if (clsString::UpperAllString(CurCodeTo) == clsString::UpperAllString("usd"))
		{
			_ExchangeFromCurrencyToUSD(CurCodeFrom, CurCodeTo, Amounth);
		}
		else
		{
			Amounth = _ExchangeFromCurrencyToUSD(CurCodeFrom, "usd", Amounth);
			_ExchangeFromUSDToCurrency("usd", CurCodeTo, Amounth);
		}
	}

public:

	static void ShowCurrencyCalculatorScreen()
	{
		string Answer = "";

		do
		{

			system("cls");

			_DrawScreenHeader("   Calculate Currency Screen");

			string CurCodeFrom = "";
			string CurCodeTo = "";

			CurCodeFrom = _ReadValidCurrencyCode("\nPlease Enter Currency Code to Change From : ",
				"\n ! ! ! Try Again ! ! !\n\nPlease Enter a Valid Currency Code to Change From : ");

			CurCodeTo = _ReadValidCurrencyCode("\nPlease Enter Currency Code to Change To : ",
				"\n ! ! ! Try Again ! ! !\n\nPlease Enter a Valid Currency Code to Change To : ");


			cout << "\nSo you want to change from [" << CurCodeFrom << "] To [" << CurCodeTo << "].\n\n";
			cout << "Please Enter Amounth To Exchange : ";
			float Amounth = clsInputValidate::ReadFloatNumberBetween(0.0001, 999999999999);

			_CalculateExchange(CurCodeFrom, CurCodeTo, Amounth);

			cout << "\nDo you wnat to perform an other Operation (y/n) ? ";
			cin >> Answer;

		} while (Answer == "y" || Answer == "Y");


	}

};