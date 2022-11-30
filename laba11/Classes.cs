using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace laba11
{
    public enum gender { Male, Female }
    public enum user_type { Employee, Guest, Abiturient}
    public class Subject
    {
        public string Name { get; set; }
        public int Score { get; set; }
        Subject(string name,int score)
        {
            if (score > 100 || score < 1)
                throw new ArgumentException("Неверно введено значение балла!");
            Score = score;
            Name = name;
        }
    }
    public abstract class User
    {
        public string Password { get; set; }
        public string Login { get; set; }
        public string AuthCode { get; set; }
        public virtual void Auth()
        {
        }
    }
    public class Person : User
    {
        public user_type Type { get; set; }
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
            string path = (@"\lab10\users\" + Login + ".acc");
            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                var user = new Employee();
                using (System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.OpenOrCreate)) //bin
                {
                    try { user = formatter.Deserialize(fs) as Employee; }
                    catch (Exception ex) { }
                    fs.Close();
                }
                if (Password == user.Password)
                {
                    //base_form form = new base_form(user);
                    //form.Show();
                }
                else throw new Exception("Неверный логин или пароль!");
            }
            else throw new Exception("Неверный логин или пароль!");
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
            string path = (@"\lab10\users\" + Login + ".acc");
            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                var user = new Employee();
                using (System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.OpenOrCreate)) //bin
                {
                    try { user = formatter.Deserialize(fs) as Employee; }
                    catch { }
                    fs.Close();
                }
                if (Password == user.Password)
                {
                    //base_form form = new base_form(user);
                    //form.Show();
                }
                else throw new Exception("Неверный логин или пароль!");
            }
            else throw new Exception("Неверный логин или пароль!");
        }
    }
    public class Abiturient : Person
    {
        private List<Subject> subjects { get; }
        private List<short> directions { get; }
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
            string path = (@"\lab10\users\" + Login + ".acc");
            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                var user = new Abiturient();
                using (System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.OpenOrCreate)) //bin
                {
                    try { user = formatter.Deserialize(fs) as Abiturient; }
                    catch {}
                    fs.Close();
                }
                if (Password == user.Password)
                {
                    //base_form form = new base_form(user);
                    //form.Show();
                }
                else throw new Exception("Неверный логин или пароль!");
            }
            else throw new Exception("Неверный логин или пароль!");
        }
    }
}
