
using System;
using System.Collections.Generic;

class BankingSystem
{
    Dictionary<int,double> accounts = new Dictionary<int,double>();
    Queue<int> withdrawalQueue = new Queue<int>();

    public void AddAccount(int id,double bal)
    {
        accounts[id]=bal;
    }

    public void RequestWithdrawal(int id)
    {
        withdrawalQueue.Enqueue(id);
    }
}
