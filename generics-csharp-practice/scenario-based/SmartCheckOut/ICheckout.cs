
namespace SmartCheckout
{
    internal interface ICheckout
    {
        void AddCustomer();
        void RemoveCustomer();
        void ProcessBilling();
        void DisplayQueue();
    }
}
