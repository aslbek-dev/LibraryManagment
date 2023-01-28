using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace LibraryManagment.Models
{
   public class User
   {
    public int UserId { get; set; }
    public string Name { get; set; } 
    public Gender Gender { get; set; }
    public DateTime Birthday { get; set; }
    public UserType UserType { get; set; }
    public override string ToString()=>
      $"{UserId} | {Name} | {Enum.GetName(Gender)} | {Birthday} | {Enum.GetName(UserType)}";
   }
   public enum UserType
   {
    Student,
    Librariant
   }
   public enum Gender
   {
    Male,
    Female
   }

}