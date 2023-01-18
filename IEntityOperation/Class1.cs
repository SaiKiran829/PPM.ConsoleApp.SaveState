using MODEL;
using System.Diagnostics.Metrics;

namespace IEntityOperation
{
    public interface IEntityOperationProject 
    {
        void AddingProjects(Project project);
        void DisplayProject(Project project);
        void DisplayAllProjects();
        List<Employee> SearchForEmployee(int readingProjectId);
        void DisplayEmployeesInProjectById(int readingProjectId);

        void AddingEmployeeToProject(int pid, Employee ename);

        void DeleteProject(int pid, Project project);

        void EmployeeFromProject(int pid, Employee ename);

        void ShowProject(int eid);

        void SearchProjectByName(string search);
    }

    public interface IEntityOperationEmployee
    {
        void AddEmployee(Employee emp);
        void DisplayEmployee(Employee emp);
        void ShowEmployees();
        void ShowEmployee(int eid);
        void DeleteEmployee(int employeeId, Employee employee);

    }

    public interface IEntityOperationRole
    {
        void RoleAdd(Role role);

        void DisplayRole();

        void ListRoleById(int roleId);
        void DeleteRole(int roleId);
    }
}