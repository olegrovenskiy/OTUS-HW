using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class UserListData
    {
        [Key]
        public int AccountId { get; set; }
        public string FullPersonName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        //Список групп. Добавить после создания.
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public List<OperationData>? Operations { get; set; }
    }
}
