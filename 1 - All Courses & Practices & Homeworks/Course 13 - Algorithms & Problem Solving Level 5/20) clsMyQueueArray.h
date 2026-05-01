#pragma once

#include <iostream>
#include "clsDynamicArray.h"

using namespace std;
template <class T>

class clsMyQueueArr
{

protected:
	clsDynamicArray <T> _MyArray;

public:

	void push(T Item)
	{
		_MyArray.InsertAtEnd(Item);
	}


	void pop()
	{
		_MyArray.DeleteFirstItem();
	}

	void Print()
	{
		_MyArray.PrintList();
	}

	int Size()
	{
		return _MyArray.Size();
	}

	bool IsEmpty()
	{
		return _MyArray.IsEmpty();
	}

	T front()
	{
		return _MyArray.GetItem(0);
	}

	T back()
	{
		return _MyArray.GetItem(Size() - 1);
	}

	T GetItem(int Index)
	{
		return _MyArray.GetItem(Index);
	}

	void Reverse()
	{
		_MyArray.Reverse();
	}

	bool UpdateItem(int Index, T NewValue)
	{
		return _MyArray.SetItem(Index, NewValue);
	}

	bool InsertAfter(int Index, T value)
	{
		return _MyArray.InsertAfter(Index, value);
	}

	void InsertAtFront(T value)
	{
		_MyArray.InsertAtBeginning(value);
	}

	void InsertAtBack(T value)
	{
		_MyArray.InsertAtEnd(value);
	}

	void Clear()
	{
		_MyArray.Clear();
	}


};

