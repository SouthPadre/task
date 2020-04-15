using System.ComponentModel.Design;

namespace ConsoleApp1
{
    public class EditIssueReviewRootCoordinationDto
    {
        public EmployeeRefDto Reviewer { get; set; }
        public ReviewDepartmentRefDto ReviewDepartment { get; set; }
    }
}