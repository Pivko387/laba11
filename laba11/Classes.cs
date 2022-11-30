using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace laba11
{
    [Serializable]
    public enum gender { Male, Female }
    [Serializable]
    public enum user_type { Employee, Guest, Abiturient}
    [Serializable]
    public class Subject
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public Subject(string name,int score)
        {
            if (score > 100 || score < 1)
                throw new ArgumentException("Неверно введено значение балла!");
            Score = score;
            Name = name;
        }
    }
    public class AuthManager
    {
        public void Register(User user)
        {
            if(user.Login.Trim() != "" && System.IO.File.Exists(@"\lab10\users\" + user.Login.Trim() + ".acc")==false)
            {
                var path1 = @"\lab10\users\" + user.Login.Trim() + ".acc";
                var path2 = @"\lab10\users\" + user.Login.Trim() + ".acinf";
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                using (System.IO.FileStream fs = new System.IO.FileStream(path1, System.IO.FileMode.OpenOrCreate)) //bin
                {
                    formatter.Serialize(fs, new UserAuth(user));
                    fs.Close();
                }
                user.RegInfo();
            }
        }
        public void Log_In(string login, string pass)
        {
            string path = (@"\lab10\users\" + login + ".acc");
            string path2 = (@"\lab10\users\" + login + ".acinf");
            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                var user = new UserAuth();
                using (System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.OpenOrCreate)) //bin
                {
                    try { user = formatter.Deserialize(fs) as UserAuth; }
                    catch (Exception ex) { }
                    fs.Close();
                }
                if (pass == user.Password)
                {
                    User des_user;
                    using (System.IO.FileStream fs = new System.IO.FileStream(path2, System.IO.FileMode.OpenOrCreate)) //bin
                    {
                        if (user.Type == user_type.Employee)
                        {
                            try 
                            { 
                                des_user = formatter.Deserialize(fs) as Employee;
                                des_user.Auth();
                            }
                            catch (Exception ex) { }
                        }
                        else
                        {
                            try 
                            { 
                                des_user = formatter.Deserialize(fs) as Abiturient; 
                                des_user.Auth(); 
                            }
                            catch (Exception ex) { }
                        }
                        fs.Close();
                    }
                }
                else throw new Exception("Неверный логин или пароль!");
            }
            else throw new Exception("Неверный логин или пароль!");
        }
    }
    [Serializable]
    public abstract class User
    {
        public string Password { get; set; }
        public string Login { get; set; }
        public string AuthCode { get; set; }
        public user_type Type { get; set; }
        public virtual void Auth()
        {
        }
        public virtual void RegInfo()
        {
            var path2 = @"\lab10\users\" + this.Login.Trim() + ".acinf";
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            using (System.IO.FileStream fs = new System.IO.FileStream(path2, System.IO.FileMode.OpenOrCreate)) //bin
            {
                formatter.Serialize(fs, this);
                fs.Close();
            }
        }
    }
    [Serializable]
    public class UserAuth : User
    {
        public UserAuth(string login, string password, string AuthCode_, user_type tp)
        {
            Login = login;
            Password = password;
            AuthCode = AuthCode_;
            Type = tp;
        }
        public UserAuth(User user)
        {
            Login = user.Login;
            Password = user.Password;
            AuthCode = user.AuthCode;
            Type = user.Type;
        }
        public UserAuth() { }
    }
    [Serializable]
    public class Person : User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronim { get; set; }
        public gender Gender { get; set; }
        public DateTime Birth { get; set; }
        public Person() { }
        public Person(string name, string lastname, string patronim, short gendr,DateTime brth)
        {
            Name = name;
            Surname = lastname;
            Patronim = patronim;
            Birth = brth;
            if (gendr == 0) Gender = gender.Male;
            if (gendr == 1) Gender = gender.Female;
        }
        public override void Auth()
        {
            
        }
    }
    [Serializable]
    public class Employee : Person
    {
        public short FacultyID { get; set; }
        public short Worker { get; set; }
        public Employee(string Log, string pass, string name, string lastname, string patronim, short gendr, short facul, DateTime brth, short work)
        {
            Type = user_type.Employee;
            Name = name;
            Surname = lastname;
            Patronim = patronim;
            Login = Log;
            Password = pass;
            Birth = brth;
            if (gendr == 0) Gender = gender.Male;
            if (gendr == 1) Gender = gender.Female;
            FacultyID = facul;
            Worker = work;
            Random rnd = new Random();
            AuthCode = rnd.Next(1000, 9999).ToString() + "-" + rnd.Next(1000, 9999).ToString() + "-" + rnd.Next(1000, 9999).ToString()
                + "-" + rnd.Next(1000, 9999).ToString();
        }
        public Employee() 
        {
            Type = user_type.Employee;
        }
        public override void Auth()
        {
            //System.Windows.Forms.MessageBox.Show("Вы вошли как преподаватель!");
            employe_form form = new employe_form(this);
            form.Show();
        }
    }
    [Serializable]
    public class Abiturient : Person
    {
        public List<Subject> subjects { get; }
        public List<short> directions { get; }
        public Abiturient() 
        {
            subjects = new List<Subject>();
            directions = new List<short>();
            Type = user_type.Abiturient;
        }
        public Abiturient(string Log, string pass, string name, string lastname, string patronim, short gendr, DateTime brth)
        {
            subjects = new List<Subject>();
            directions = new List<short>();
            Type = user_type.Abiturient;

            Name = name;
            Surname = lastname;
            Patronim = patronim;
            Login = Log;
            Password = pass;
            Birth = brth;
            if (gendr == 0) Gender = gender.Male;
            if (gendr == 1) Gender = gender.Female;
            Random rnd = new Random();
            AuthCode = rnd.Next(1000, 9999).ToString() + "-" + rnd.Next(1000, 9999).ToString() + "-" + rnd.Next(1000, 9999).ToString()
                + "-" + rnd.Next(1000, 9999).ToString();
        }
        public void AddSubject(Subject sub)
        {
            if (subjects.Contains(sub) == false)
                subjects.Add(sub);
            else
                throw new Exception("Данный предмет уже добавлен!");
        }
        public void AddDirection(short id)
        {
            if(directions.Count < 5)
                if(directions.Contains(id)==false)
                    directions.Add(id);
                else
                    throw new Exception("Данное направление уже добавлено!");
            else
                throw new Exception("Невозможно выбрать более 5 направлений!");
        }
        public void RemoveSubject(int id)
        {
            if(id >= 0 && id < subjects.Count)
            {
                subjects.RemoveAt(id);
            }
            else throw new Exception("Неверно указан идентификатор предмета для удаления!");
        }
        public void RemoveDirection(int id)
        {
            if (id >= 0 && id < directions.Count)
            {
                directions.RemoveAt(id);
            }
            else throw new Exception("Неверно указан идентификатор направления для удаления!");
        }
        public override void Auth()
        {
            System.Windows.Forms.MessageBox.Show("Вы вошли как абитуриент!");
            abitur_form form = new abitur_form(this);
            form.Show();
        }
    }
}
