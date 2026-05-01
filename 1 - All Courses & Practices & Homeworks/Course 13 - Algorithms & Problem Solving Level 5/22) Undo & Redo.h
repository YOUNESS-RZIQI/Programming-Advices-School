#pragma once

#include <stack>

using namespace std;

class clsMyString
{

private:

	stack <string> _Undo;
	stack <string> _Redo;
	string _Value;

public:

	void Set(string value)
	{
		_Undo.push(_Value);
		_Value = value;
	}

	string Get()
	{
		return _Value;
	}

	__declspec(property(get = Get, put = Set)) string Value;


	void Undo()
	{

		if (!_Undo.empty())
		{
			_Redo.push(_Value);
			_Value = _Undo.top();
			_Undo.pop();
		}

	}

	void Redo()
	{

		if (!_Redo.empty())
		{
			_Undo.push(_Value);
			_Value = _Redo.top();
			_Redo.pop();
		}


	}
};



/*

//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

#include <iostream>
#include "clsMyString.h"

using namespace std;

int main()
{

	cout << "\n\n\t\t\t\t\t\t Undo/Redo Project\n\n";

	clsMyString S1;

	cout << "\nS1  = " << S1.GetValue() << "\n";

	S1.SetValue("Mohammed");

	cout << "S1  = " << S1.GetValue() << "\n";

	S1.SetValue("Mohammed2");

	cout << "S1  = " << S1.GetValue() << "\n";

	S1.SetValue("Mohammed3");

	cout << "S1  = " << S1.GetValue() << "\n";

	cout << "\n\nUndo: ";
	cout << "\n__________\n";

	S1.Undo();
	cout << "\nS1  after undo = " << S1.GetValue() << "\n";

	S1.Undo();
	cout << "S1  after undo = " << S1.GetValue() << "\n";

	S1.Undo();
	cout << "S1  after undo = " << S1.GetValue() << "\n";


	cout << "\n\nRedo: ";
	cout << "\n__________\n";

	S1.Redo();
	cout << "\nS1  after Redo = " << S1.GetValue() << "\n";

	S1.Redo();
	cout << "S1  after Redo = " << S1.GetValue() << "\n";

	S1.Redo();
	cout << "S1  after Redo = " << S1.GetValue() << "\n";

	system("pause>0");

	return 0;
}


*/