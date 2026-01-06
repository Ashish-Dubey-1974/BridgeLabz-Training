
using System.Collections.Generic;

interface IMedicalRecord
{
    void AddRecord(string record);
    List<string> ViewRecords();
}

abstract class Patient
{
    private int patientId;
    protected string name;
    protected int age;

    protected Patient(int id, string name, int age)
    {
        patientId = id;
        this.name = name;
        this.age = age;
    }

    public abstract double CalculateBill();
}

class InPatient : Patient, IMedicalRecord
{
    private List<string> records = new List<string>();

    public InPatient(int id, string name, int age) : base(id, name, age) { }

    public override double CalculateBill() => 5000;
    public void AddRecord(string record) { records.Add(record); }
    public List<string> ViewRecords() => records;
}

class OutPatient : Patient
{
    public OutPatient(int id, string name, int age) : base(id, name, age) { }
    public override double CalculateBill() => 500;
}
