using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MeetupsApi.Data;

namespace MeetupsApi.Models
{
    public class MeetupModel
    {   
        
        public List<MeetupResponse> GetAll(int userId)
        {
            Console.WriteLine("MeetupModel.GetAll : START");
            try
            {
                var context = new SantanderChalengeContext();   
                var admin = context.Users.FirstOrDefault(x=> x.Id==userId).Admin;
                var response = (from m in context.Meetups
                            join u in context.Users on m.UserOrganizer equals u.Id
                            select new MeetupResponse{
                                 Meetup = new Meetups{
                                     Id =m.Id,
                                     UserOrganizer = m.UserOrganizer,
                                     Title = m.Title,
                                     Date = m.Date,
                                     Canceled = m.Canceled,
                                     Guests = m.Guests
                                 },
                                 Organizer= new Users{
                                     Id = u.Id,
                                     Name = u.Name,
                                     Admin = u.Admin
                                 },
                                 BirrasCount = admin == -1 ? -1 : CalculateBirra(m.Date,m.Guests),
                                 TempDay = GetTemp(m.Date)
                            }).ToList();
                Console.WriteLine("MeetupModel.GetAll : END");
                return response;
            
            }
            catch(Exception ex)
            {
                Console.WriteLine("MeetupModel.GetAll : ERROR : "+ex.Message);
                return null;
            }
            
        }

        public string Create(int userOrganizer, string title,DateTime date,int guests)
        {
            Console.WriteLine("MeetupModel.Create : START");
            try
            {
                var context = new SantanderChalengeContext();
            
                var permissions = context.Users.SingleOrDefault(x=> x.Id == userOrganizer).Admin;                
                if(permissions == 1)
                {
                    var met = new Meetups();
                    met.UserOrganizer=userOrganizer; 
                    met.Date = date;
                    met.Title=title;
                    met.Canceled=-1;
                    met.Guests=guests;
                    context.Meetups.Add(met);
                    context.SaveChanges();
                    Console.WriteLine("MeetupModel.Create : END");
                    return "";
                }
                else 
                    return "Permisos insuficientes para realizar esta accion.";
            }
            catch(Exception ex)
            {                
                Console.WriteLine("MeetupModel.Create : ERROR : "+ex.Message);
                return ex.Message;
            }
        }
        public string Cancel(int id,int userId )
        {
           Console.WriteLine("MeetupModel.Cancel : START");
            try
            {
                var context = new SantanderChalengeContext();
                var res = context.Meetups.SingleOrDefault(x=> x.Id == id);                        
                var permissions = res.UserOrganizer == userId;                
                if(permissions)
                {                    
                    res.Canceled = 1;                    
                    context.SaveChanges();                  
                    Console.WriteLine("MeetupModel.Cancel : END");                  
                    return "";
                }
                else 
                {
                    Console.WriteLine("MeetupModel.Cancel : END");
                    return "Permisos insuficientes para realizar esta accion.";                    
                }
            }
            catch(Exception ex)
            {                
                Console.WriteLine("MeetupModel.Cancel : ERROR : "+ex.Message);
                return ex.Message;
            }
        }

        public string Update(int id , string title,DateTime date ,int userId )
        {
            Console.WriteLine("MeetupModel.Update : START");
            try
            {
                var context = new SantanderChalengeContext();
                var res = context.Meetups.SingleOrDefault(x=> x.Id == id);
                var permissions = res.UserOrganizer == userId;
                if(permissions)
                {
                    res.Date = date;
                    res.Title = title;
                    context.SaveChanges();
                    Console.WriteLine("MeetupModel.Update : END");
                    return "";
                }
                else 
                {
                    Console.WriteLine("MeetupModel.Cancel : END");
                    return "Solo el Organizador puede realizar esta accion.";                    
                }
            }
            catch(Exception ex)
            {                
                Console.WriteLine("MeetupModel.Update : RROR : "+ex.Message);
                return ex.Message;
            }
        }

        public string Delete(int id,int userId)
        {
            Console.WriteLine("MeetupModel.Delete : START");
            try
            {
                var context = new SantanderChalengeContext();
                var res = context.Meetups.SingleOrDefault(x=> x.Id == id);
                var permissions = res.UserOrganizer == userId;
                if(permissions)
                {
                    context.Remove(context.Meetups.Single(x=> x.Id == id)); 
                    context.SaveChanges();
                    Console.WriteLine("MeetupModel.Delete : END");
                    return "";
                }
                else 
                {
                    Console.WriteLine("MeetupModel.Cancel : END");
                    return "Solo el Organizador puede realizar esta accion.";                    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("MeetupModel.Delete : ERROR : "+ex.Message );
                return ex.Message;
            }
        }
        
        public static double CalculateBirra(DateTime date , int guests)
        {
            var temp = GetTemp(date);
            Console.WriteLine(temp.ToString());
            if(temp!=-1)
            {
                if(temp>24)
                {
                    return guests * 2;              
                }
                else if(temp<20)
                {
                    return guests * 0.75;
                }
                else 
                    return guests;
            }
            else
             return -1;
        }

        public static double GetTemp(DateTime date)
        {   
            var diff = (date - DateTime.Now).Days;
            Console.WriteLine(diff.ToString());
            if(diff<8)
            {
                Random random = new Random();
		        return random.NextDouble() * (35 - 15) + 15;
            }
            else 
                return -1;
        }
    }
}
