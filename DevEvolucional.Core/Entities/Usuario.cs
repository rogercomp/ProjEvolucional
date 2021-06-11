using System;
using System.Collections.Generic;

namespace DevEvolucional.Core.Entities
{
    public class Usuario : BaseEntity
    {
        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;

            //FullName = fullName;
            //Email = email;
            //BirthDate = birthDate;
            //CreatedAt = DateTime.Now;
            //Active = true;
            //Password = password;
            //Role = role;

            //Skills = new List<UserSkill>();
            //OwnedProjects = new List<Project>();
            //FreelanceProjects = new List<Project>();
        }

        public string Login { get; private set; }
        public string Senha { get; private set; }

        //public string FullName { get; private set; }
        //public string Email { get; private set; }
        //public DateTime BirthDate { get; private set; }
        //public DateTime CreatedAt { get; private set; }
        //public bool Active { get; set; }
        //public string Password { get; private set; }
        //public string Role { get; private set; }


        //public List<UserSkill> Skills { get; private set; }
        //public List<Project> OwnedProjects { get; private set; }
        //public List<Project> FreelanceProjects { get; set; }
        //public List<ProjectComment> Comments { get; private set; }
    }
}
