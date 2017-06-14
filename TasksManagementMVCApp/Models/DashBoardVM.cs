using TasksManagementMVCApp.Models;
using System.Collections.Generic;

namespace TasksManagementMVCApp.Models
{
    public class DashBoardVM
    {
        public IEnumerable<Message> Messages { get; set; }
        public IEnumerable<Task> Tasks { get; set; }
    }
}