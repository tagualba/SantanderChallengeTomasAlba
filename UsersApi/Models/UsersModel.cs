using System;
using System.Linq;
using UsersApi.DbContexts;
using UsersApi.Data;

namespace UsersApi.Models
{
    public class UsersModels
    {
        public string Create(string userName,string name,string pass,string email,bool admin)
        {
            Console.WriteLine("UsersModel.Create : START");
            try
            {
                SantanderChalengeContext context = new SantanderChalengeContext();
                Users user = new Users()
                {
                    UserName = userName,
                    Name = name,
                    Pass = pass,
                    Email = email,
                    Admin = admin ? 1 : -1
                };

                context.Users.Add(user);
                context.SaveChanges();
                Console.WriteLine("UsersModel.Create : END");
                return "";
            }   
            catch(Exception  ex)
            {
                Console.WriteLine("UsersModel.Create : ERROR : "+ex.Message);
                return ex.Message;
            }            
        }

        public string Delete(int id)
        {
            Console.WriteLine("UsersModel.Delete : START");
            try
            {
                SantanderChalengeContext context = new SantanderChalengeContext();            
                context.Remove(context.Users.Single(x=> x.Id == id)); 
                context.SaveChanges();
                Console.WriteLine("UsersModel.Delete : END");
                return "";
            }   
            catch(Exception  ex)
            {
                Console.WriteLine("UsersModel.Delete : ERROR : "+ex.Message);
                return ex.Message;
            }
        }

        public Users Login(string user,string pass)
        {
            Console.WriteLine("UsersModel.Login : START");
            try
            {
                SantanderChalengeContext context = new SantanderChalengeContext();
                Console.WriteLine("UsersModel.Login : END"); 
                return context.Users.Where(x=> (x.UserName == user) && (x.Pass == pass)).FirstOrDefault();
            }   
            catch(Exception  ex)
            {
                Console.WriteLine("UsersModel.Login : ERROR : "+ex.Message);
                return null;
            }
        }
    }
}