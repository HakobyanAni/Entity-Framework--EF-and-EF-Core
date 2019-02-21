#include "pch.h"
#include <iostream>
using namespace std;
struct us
{
	char azg[15];
	double gn;
};
struct cuc
{
	us arjeq
	//int arjeq;
	cuc *ptr;
};
cuc *head = 0;
cuc *nor(int a1)
{
	cuc *l = new cuc;
	l->arjeq = a1;
	l->ptr = NULL;
	return l;
};
void addel(cuc *nax, int a1)
{
	cuc *n = new cuc;
	n->ptr = nax->ptr;
	n->arjeq = a1;
	nax->ptr = n;
};
void delel(cuc *nax)
{
	nax->ptr = (nax->ptr)->ptr;
};
void print()
{
	while (head->ptr)
	{
		cout << "arjeq=" << head->arjeq << "  " << head->ptr << endl;
		head = head->ptr;
	}
	cout << "arjeq=" << head->arjeq << "  " << head->ptr << endl;
};
void main()
{
	cuc *k = head;
	head = nor(4);
	for (int i = 1; i < 5; ++i)
		addel(head, i * 2);
	k = head;
	print();
	head = k;
	cout << "*********" << endl << endl;
	while (head->ptr)
	{
		if (head->arjeq > 0) { addel(head, -5); }
		head = head->ptr;
	}
	head = k;
	print();
}