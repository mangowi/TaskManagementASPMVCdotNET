using TasksManagementMVCApp.Models;
using System.Collections.Generic;

namespace TasksManagementMVCApp.Models
{
    public class DashBoardVM
    {
        public IEnumerable<MessageThread> Threads { get; set; }
        public IEnumerable<Task> Tasks { get; set; }
    }
}