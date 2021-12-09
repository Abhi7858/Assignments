namespace OfficeApplication
{
    interface IEmployeeManagementService
    {
        void AddEmployee(TblEmployee employee);
        void UpdateEmployee(int updateId);
        void RemoveEmployee(int removeId);

    }
}
